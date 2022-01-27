using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba06_selfmade.Shape
{
    public class ShapeCl
    {
        int size;
        int id;
        Point middle;
        Color shapeColor;
        bool isSelected = false;

        public ShapeCl() { }
        public ShapeCl(Point p, int s, Color c)
        {
            id = Convert.ToInt32((new Random()).Next());
            Middle = p;
            Size = s;
            ShapeColor = c;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        public Point Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public Color ShapeColor
        {
            get { return shapeColor; }
            set { shapeColor = value; }
        }

        virtual public void Draw(PaintEventArgs e) { }
        virtual public bool Hittest(int _x, int _y)
        {
            return true;
        }

        virtual public bool isOutOfBounds(PictureBox pb, Point newMiddle)
        {
            return ((newMiddle.X > (Size / 2)) && (newMiddle.X < pb.Size.Width -
            (Size / 2)) && (newMiddle.Y - (Size / 2) > 0) &&
            (newMiddle.Y + (size/2) < pb.Size.Height));

        }
    }
}
