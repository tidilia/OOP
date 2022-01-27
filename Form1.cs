using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using laba07.Shape;
using laba07.Observer;

namespace laba07
{
    public partial class Form1 : Form
    {
        int selected = 0;
        List<ShapeCl> shapes = new List<ShapeCl>();
        List<ShapeCl> selected_shapes = new List<ShapeCl>();
        bool isCtrlPressed = false;
        ShapeFactory shapeFactory = new ShapeFactory();
        ShapeStorage shapeStorage = new ShapeStorage();
        TreeViewObserver observer;
        

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < selected_shapes.Count; ++i)
                {
                    shapes.Remove(selected_shapes[i]);
                    shapeStorage.del_el(selected_shapes[i]);
                }
                selected_shapes.Clear();
                selected = 0;
            }
        }


        public Form1()
        {
            InitializeComponent();
            observer = new TreeViewObserver(treeView1);
            shapeStorage.addObserver(observer);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int xDiff, yDiff;
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    {
                        isCtrlPressed = true;
                        break;
                    }
                case Keys.Up:
                    {
                        xDiff = 0; yDiff = -1;
                        change_Middle(xDiff, yDiff);
                        break;
                    }
                case Keys.Down:
                    {
                        xDiff = 0; yDiff = 1;
                        change_Middle(xDiff, yDiff);
                        break;
                    }
                case Keys.Left:
                    {
                        xDiff = -1; yDiff = 0;
                        change_Middle(xDiff, yDiff);
                        break;
                    }
                case Keys.Right:
                    {
                        xDiff = 1; yDiff = 0;
                        change_Middle(xDiff, yDiff);
                        break;
                    }
            }
            Refresh();

        }

        private void change_Middle(int xDiff, int yDiff)
        {
            Point newMiddle;
            for (int i = 0; i < shapes.Count; ++i)
            {
                if (shapes[i].IsSelected)
                {
                    newMiddle = new Point(shapes[i].Middle.X + xDiff, shapes[i].Middle.Y + yDiff);
                    if (shapes[i].isOutOfBounds(pictureBox1, newMiddle))
                        shapes[i].Middle = newMiddle;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) isCtrlPressed = false;
        }

        bool valueSelected()
        {
            if (ShapeComboBox.SelectedItem != null && SizeTrackBar.Value != 0 &&
                ColorComboBox.SelectedItem != null) return true;
            else return false;
        }


        private void Shape_Creator(object sender, MouseEventArgs e)
        {
            bool hit = false;
            for (int i = 0; i < shapes.Count; ++i)
                if (shapes[i].Hittest(e.X, e.Y))
                {
                    if (!isCtrlPressed)
                    {
                        for (int j = 0; j < shapes.Count; ++j)
                        {
                            shapes[j].IsSelected = false;
                            shapeStorage.sel_change(shapes[j]);
                        }
                        selected_shapes.Clear();
                        selected = 0;
                    }
                    sel(i);
                    shapeStorage.sel_change(shapes[i]);
                    hit = true;
                }
            if (!hit)
            {
                add_el(e);
            }
   

            Refresh(); //ручной вызов PaintEvent
        }

        private void add_el(MouseEventArgs e)
        {
            if (CreatingCheckBox.Checked && valueSelected())
            {
                Color c = Color.FromName(ColorComboBox.Text.ToString());
                int s = Convert.ToInt32(SizeTrackBar.Value);
                MyRectangle new_rect;
                Triangle new_triangle;
                MyCircle new_circle;
                Point p = new Point(e.X, e.Y);
                string type = ShapeComboBox.Text.ToString();
                switch (type)
                {
                    case "Rectangle":
                        {
                            new_rect = new MyRectangle(p, s, c);
                            if (new_rect.isOutOfBounds(pictureBox1, p))
                            {
                                shapes.Add(new_rect);
                                shapeStorage.add_el(new_rect);
                            }
                            break;
                        }
                    case "Circle":
                        {
                            new_circle = new MyCircle(p, s, c);
                            if (new_circle.isOutOfBounds(pictureBox1, p))
                            {
                                shapes.Add(new_circle);
                                shapeStorage.add_el(new_circle);
                            }
                            break;
                        }
                    case "Triangle":
                        {
                            new_triangle = new Triangle(s, p, c);
                            if (new_triangle.isOutOfBounds(pictureBox1, p))
                            {
                                shapes.Add(new_triangle);
                                shapeStorage.add_el(new_triangle);
                            }
                            break;
                        }
                }
            }
        }
        private void sel(int i)
        {
            if (shapes[i].IsSelected)
            {
                selected--;
                selected_shapes.Remove(shapes[i]);
            }
            else
            {
                selected++;
                selected_shapes.Add(shapes[i]);
            }
            shapes[i].IsSelected = !shapes[i].IsSelected;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < shapes.Count; ++i)
            {
                shapes[i].Draw(e);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Shape_Creator(sender, e as MouseEventArgs);
        }

        

        private void groupButton_Click(object sender, EventArgs e)
        {
            if (selected != 0)
            {
                Group newGroup = new Group();
                for (int i = 0; i < shapes.Count; ++i)
                {
                    if (shapes[i].IsSelected)
                    {
                        newGroup.add_el(shapes[i]);
                    }
                }

                while (selected != 0)
                {
                    bool findsel = false;
                    for (int i = 0; i < shapes.Count; ++i)
                    {
                        if (shapes[i].IsSelected)
                        {
                            selected_shapes.Remove(shapes[i]);
                            shapeStorage.del_el(shapes[i]);
                            shapes.RemoveAt(i);
                            findsel = true;
                        }
                        if (findsel) break;
                    }
                    selected--;
                }

                newGroup.IsSelected = false;

                shapes.Add(newGroup);
                shapeStorage.add_el(newGroup);

                Refresh();
            }

        }

        private void UngroupButton_Click(object sender, EventArgs e)
        {
            if(selected == 1)
            {
                for(int i = shapes.Count - 1; i >= 0; --i)
                {
                    if (shapes[i].IsSelected && shapes[i].isA("Group"))
                    {
                        Group el;
                        el = (Group)shapes[i];
                        for (int j = el.GetCount() - 1; j >= 0; --j)
                        {
                            el.GetShape(j).IsSelected = false;
                            shapes.Add(el.GetShape(j));
                            shapeStorage.add_el(el.GetShape(j));
                        }
                        for (int j = el.GetCount() - 1; j >= 0; --j)
                            el.del_el(el.GetShape(j));
                        shapeStorage.del_el(shapes[i]);
                        shapes.RemoveAt(i);
                    }
                }
            }
            Refresh();
        }


        private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!CreatingCheckBox.Checked && SizeTrackBar.Value != 0)
            {
                ShapeCl newShape;
                int s = Convert.ToInt32(SizeTrackBar.Value);
                for (int i = 0; i < shapes.Count; ++i)
                    if (shapes[i].IsSelected)
                    {
                        newShape = new ShapeCl(shapes[i].Middle, s, shapes[i].ShapeColor);
                        if (newShape.isOutOfBounds(pictureBox1, shapes[i].Middle))
                            shapes[i].Size = s;
                    }
            }
            Refresh();
        }

        private void ColorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ColorComboBox.SelectedItem != null && !CreatingCheckBox.Checked)
            {
                Color c = Color.FromName(ColorComboBox.Text.ToString());
                for (int i = 0; i < shapes.Count; ++i)
                    if (shapes[i].IsSelected) shapes[i].ShapeColor = c;
            }

            Refresh();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream f = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter stream = new StreamWriter(f);

                stream.WriteLine(shapes.Count.ToString());

                if (shapes.Count != 0)
                {
                    for (int i = 0; i < shapes.Count; ++i) shapes[i].Save(stream);
                }
                stream.Close();
                f.Close();
            }         
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream f = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader stream = new StreamReader(f);

                int k = Convert.ToInt32(stream.ReadLine());

                for(int i = 0; i < k; ++i)
                {
                    shapes.Add(shapeFactory.createShape(stream));
                    shapeStorage.add_el(shapeFactory.createShape(stream));
                }

                stream.Close();
                f.Close();
            }
            Refresh();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;

            findInList(treeView1.SelectedNode, shapes);

            Refresh();
        }


        private int getId(TreeNode e)
        {
            string name = e.Text;
            string id = "";
            for (int i = name.Length - 1; i >= 0; --i)
            {
                if (name[i] != ' ') id += name[i];
                else break;
            }
            name = "";
            for (int i = id.Length - 1; i >= 0; --i) name += id[i];
            return Convert.ToInt32(name);
        }

        private void clear_selected()
        {
            for (int j = 0; j < shapes.Count; ++j) shapes[j].IsSelected = false;
            selected_shapes.Clear();
        }

        private void findInList(TreeNode e, List<ShapeCl> shapesL)
        {
            int id = getId(e);
            for (int i = 0; i < shapesL.Count; ++i)
            {
                if (shapesL[i].isA("Group"))
                {
                    Group a = (Group)shapesL[i];
                    findInList(e, a.getList());
                }
                if (shapesL[i].Id == id)
                {
                    clear_selected();
                    shapesL[i].IsSelected = true;
                    selected = 1;
                    selected_shapes.Add(shapesL[i]);
                }
            }
        }
    }
}

