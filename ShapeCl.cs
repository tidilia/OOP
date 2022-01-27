using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace laba07.Shape
{
    public class ShapeCl: IShape
    {
        protected int size;
        int id;
        protected Point middle;
        protected Color shapeColor;
        protected bool isSelected = false;

        public ShapeCl() { }


        public ShapeCl(Point p, int s, Color c)
        {
            Id = Convert.ToInt32((new Random()).Next());
            Middle = p;
            Size = s;
            ShapeColor = c;
        }

        public virtual int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        public virtual bool isA(string classname)
        {
            return (classname == "Shape");
        }

        public virtual Point Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public virtual Color ShapeColor
        {
            get { return shapeColor; }
            set { shapeColor = value; }
        }

        virtual public void Draw(PaintEventArgs e) { }
        virtual public bool Hittest(int _x, int _y)
        {
            return true;
        }

        virtual public string SaveString() { return ""; }

        public override void Save(StreamWriter stream)
        {
            string line = this.SaveString();
            stream.WriteLine(line);
        }

        public override void Load(string line)
        {
            string[] subs = line.Split(";");

            int x = Convert.ToInt32(subs[1]);
            int y = Convert.ToInt32(subs[2]);
            int s = Convert.ToInt32(subs[3]);
            Color c = Color.FromName(subs[4]);
            int n = Convert.ToInt32(subs[5]);
            bool sel = (subs[6] == "S") ? true : false;

            Middle = new Point(x, y);
            Size = s;
            ShapeColor = c;
            Id = n;
            IsSelected = sel;
        }


        virtual public bool isOutOfBounds(PictureBox pb, Point newMiddle)
        {
            return ((newMiddle.X > (Size / 2)) && (newMiddle.X < pb.Size.Width -
                (Size / 2)) && (newMiddle.Y - (Size / 2) > 0) &&
                (newMiddle.Y + (size / 2) < pb.Size.Height));

        }
    }
}
