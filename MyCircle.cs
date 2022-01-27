using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba04OOP
{
    class MyCircle
    {
        int x, y;
        int id;
        const int r = 25;
        bool isSelected = false;

        public MyCircle() { }
        public MyCircle(int _x, int _y, int _id)
        {
            id = _id;
            x = _x;
            y = _y;
        }

        public static bool operator ==(MyCircle c1, MyCircle c2)
        {
            return (c1.x == c2.x && c1.y == c2.y && c1.id == c2.id);
        }

        public static bool operator !=(MyCircle c1, MyCircle c2)
        {
            return (!(c1.x == c2.x && c1.y == c2.y && c1.id == c2.id));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int ID
        {
            get { return id; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        public bool hittest(int _x, int _y)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x - _x), 2) + Math.Pow(Math.Abs(y - _y), 2)) <= r;
        }

        public void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 66, 173), 2);
            SolidBrush solidBrush = new SolidBrush(IsSelected ? Color.FromArgb(255, 66, 173) : Color.Gray);

            e.Graphics.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
            e.Graphics.FillEllipse(solidBrush, x - r, y - r, 2 * r, 2 * r); //заполняем эллипс
            e.Graphics.DrawString((id + 1).ToString(), new Font("Sergoe", 8), Brushes.Black, x - r / 3, y - r / 3); //номер

            pen.Dispose();
            solidBrush.Dispose();
        }
    }
}
