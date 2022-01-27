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
using laba06_selfmade.Shape;

namespace laba06_selfmade
{
    public partial class Form1 : Form
    {
        int selected = 0;
        List<ShapeCl> shapes = new List<ShapeCl>();
        List<int> selected_shapes = new List<int>();
        bool isCtrlPressed = false;
        

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < selected_shapes.Count; ++i)
                {
                    for (int j = 0; j < shapes.Count; ++i)
                        if (selected_shapes[i] == shapes[j].Id)
                            shapes.RemoveAt(j);
                }
                selected_shapes.Clear();
                selected = 0;
            }
        }



        public Form1()
        {
            InitializeComponent();
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
                    newMiddle = new Point(shapes[i].Middle.X + xDiff, shapes[i].Middle.Y +yDiff);
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
                            shapes[j].IsSelected = false;
                        selected_shapes.Clear();
                        selected = 0;
                    }
                    sel(i);
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
                            if (new_rect.isOutOfBounds(pictureBox1, p)) shapes.Add(new_rect);
                            break;
                        }
                    case "Circle":
                        {
                            new_circle = new MyCircle(p, s, c);
                            if (new_circle.isOutOfBounds(pictureBox1, p)) shapes.Add(new_circle);
                            break;
                        }
                    case "Triangle":
                        {
                            new_triangle = new Triangle(s, p, c);
                            if (new_triangle.isOutOfBounds(pictureBox1, p)) shapes.Add(new_triangle);
                            break;
                        }
                }
                CreatingCheckBox.Checked = false;
            }
        }
        private void sel(int i)
        {
            if (shapes[i].IsSelected)
            {
                selected--;
                selected_shapes.Remove(shapes[i].Id);
            }
            else
            {
                selected++;
                selected_shapes.Add(shapes[i].Id);
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
    }
}
