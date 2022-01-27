using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace laba07.Shape
{
    public class Group: ShapeCl
    {
        List<ShapeCl> GroupShapes = new List<ShapeCl>();
        Point p1, p2, p3, p4;

        public Group() {
            Id = Convert.ToInt32((new Random()).Next());
        }

        public List<ShapeCl> getList()
        {
            return GroupShapes;
        }

        public override void Load(string line)
        {
            while (line != "GE;")
            {

            }
        }


        public int GetCount()
        {
            return GroupShapes.Count;
        }

        public ShapeCl GetShape(int i)
        {
            return GroupShapes[i];
        }


        public override bool IsSelected
        {
            get { return isSelected; }
            set { 
                isSelected = value;
                for (int i = 0; i < GroupShapes.Count; ++i)
                    GroupShapes[i].IsSelected = value;
            }
        }

        public override bool isOutOfBounds(PictureBox pb, Point newMiddle)
        {
            for(int i = 0; i < GroupShapes.Count; ++i)
            {
                Point m = new Point(GroupShapes[i].Middle.X + (newMiddle.X - middle.X),
                        GroupShapes[i].Middle.Y + (newMiddle.Y - middle.Y));
                if (!GroupShapes[i].isOutOfBounds(pb, m)) return false;
            }
            return true;
        }

        public override Point Middle
        {
            get { return middle; }
            set { 
                for(int i = 0; i < GroupShapes.Count; ++i)
                {
                    Point newMiddle = new Point(GroupShapes[i].Middle.X + (value.X - middle.X),
                        GroupShapes[i].Middle.Y + (value.Y - middle.Y));
                    GroupShapes[i].Middle = newMiddle;
                }
                middle = value; 
            }
        }

        public override bool isA(string classname)
        {
            return (classname == "Group" || base.isA(classname));
        }

        public override Color ShapeColor
        {
            get { return shapeColor; }
            set {
                for (int i = 0; i < GroupShapes.Count; ++i)
                    GroupShapes[i].ShapeColor = value;
                shapeColor = value; 
            }
        }

        public void add_el(ShapeCl el)
        {
            GroupShapes.Add(el);
            changeSizeMiddle(el);
        }

        public void del_el(ShapeCl el)
        {
            GroupShapes.Remove(el);
        }

        private void changeSizeMiddle(ShapeCl el)
        {
            if (el.Middle.X + (el.Size / 2) > p2.X)
            {
                p2.X = el.Middle.X + (el.Size / 2);
                p3.X = el.Middle.X + (el.Size / 2);
            }
            if (el.Middle.X - (el.Size / 2) < p1.X)
            {
                p1.X = el.Middle.X - (el.Size / 2);
                p4.X = el.Middle.X - (el.Size / 2);
            }
            if (el.Middle.Y + (el.Size / 2) > p4.Y)
            {
                p4.Y = el.Middle.Y + (el.Size / 2);
                p3.Y = el.Middle.Y + (el.Size / 2);
            }
            if (el.Middle.Y - (el.Size / 2) < p2.Y)
            {
                p2.Y = el.Middle.Y - (el.Size / 2);
                p1.Y = el.Middle.Y - (el.Size / 2);
            }

            Point newMiddle = new Point(p1.X + ((p2.X - p1.X) / 2), p1.Y + ((p4.Y - p1.Y) / 2));
            this.middle = newMiddle;

            this.size = (p4.Y - p1.Y > p2.X - p1.X ? p4.Y - p1.Y : p2.X - p1.X);
        }


        public override int Size
        {
            get { return size; }
            set {
                for(int i = 0; i < GroupShapes.Count; ++i)
                {
                    GroupShapes[i].Size = value;
                }
            }
        }


        public override void Draw(PaintEventArgs e)
        {
            for (int i = 0; i < GroupShapes.Count; ++i) GroupShapes[i].Draw(e);
        }

        public override bool Hittest(int _x, int _y)
        {
            for (int i = 0; i < GroupShapes.Count; ++i)
            {
                if(GroupShapes[i].Hittest(_x, _y)) return true;
            }
            return false;
        }

        public override string SaveString()
        {
            string line = "GS;\n";
            line += GroupShapes.Count.ToString() + "\n";
            for(int i = GroupShapes.Count - 1; i >= 0; i--)
            {
                if (GroupShapes[i].isA("Group")) line += GroupShapes[i].SaveString();
                else line += GroupShapes[i].SaveString() + "\n";
            }
            return line;
        }

    }
}
