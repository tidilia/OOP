using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba04OOP
{
    public partial class Form1 : Form
    {
        int id = 0;
        int selected = 0;
        List<MyCircle> circles = new List<MyCircle>();
        List<MyCircle> selected_circles = new List<MyCircle>();
        bool isCtrlPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlPressed = true;
                label1.Text = "true";
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) isCtrlPressed = false;
        }

        private void PictureB_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < circles.Count; ++i)
            {
                circles[i].draw(e);
            }
        }

        private void PictureB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Circle_Creator(sender, e);
            if (e.Button == MouseButtons.Right) Del_circles();
        }

        private void Del_circles()
        {
            for(int i = 0; i < selected_circles.Count; ++i)
            {
                for (int j = 0; j < circles.Count; ++j)
                    if (selected_circles[i] == circles[j]) circles.RemoveAt(j);
            }
            selected_circles.Clear();
            selected = 0;
            Refresh();
        }
        private void Circle_Creator(object sender, MouseEventArgs e)
        {
            bool hit = false;
            MyCircle new_circle;
                for (int i = 0; i < circles.Count; ++i)
                    if (circles[i].hittest(e.X, e.Y))
                    {
                        if (!isCtrlPressed)
                            for (int j = 0; j < circles.Count; ++j)
                            {
                                circles[j].IsSelected = false;
                                selected_circles.Clear();
                                selected = 0;
                            }
                        sel(i);
                        hit = true;
                    }
            if (!hit)
            {
                new_circle = new MyCircle(e.X, e.Y, id);
                ++id;
                if (circles.Count == 0)
                {
                    new_circle.IsSelected = true;
                    selected_circles.Add(new_circle);
                }
                circles.Add(new_circle);
            }


            Refresh(); //ручной вызов PaintEvent

        }
        
        private void sel(int i)
        {
            if (circles[i].IsSelected)
            {
                selected--;
                selected_circles.Remove(circles[i]);
            }
            else
            {
                selected++;
                selected_circles.Add(circles[i]);
            }
            circles[i].IsSelected = !circles[i].IsSelected;
        }

        /*private void GraphBox_RightButton(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < id; ++i)
            {
                if (cities[i].hittest(e.X, e.Y))
                {
                    if (!cities[i].IsSelected && selected < 2)
                    {
                        cities[i].IsSelected = true;
                        selected++;
                        selected_cities.Add(cities[i]);
                    }
                    else if (cities[i].IsSelected)
                    {
                        cities[i].IsSelected = false;
                        if (selected_cities[0] == cities[i]) selected_cities.Remove(selected_cities[0]);
                        else if (selected_cities[1] == cities[i]) selected_cities.Remove(selected_cities[1]);
                        selected--;
                    }

                    map = new Map(cities, roads);
                    Refresh();
                }
            }
        }*/

    }
}
