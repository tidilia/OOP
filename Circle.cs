using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba06_selfmade.Shape
{
    public class MyCircle: ShapeCl
    {
        public MyCircle(Point p, int s, Color c)
        {
            Middle = p;
            Size = s;
            ShapeColor = c;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(IsSelected ? Color.Gray : ShapeColor, 1);
            SolidBrush solidBrush = new SolidBrush(IsSelected ? Color.Gray : ShapeColor);

            e.Graphics.DrawEllipse(pen, this.Middle.X - Size/2, this.Middle.Y - Size/2, Size, Size);
            e.Graphics.FillEllipse(solidBrush, this.Middle.X - Size/2, this.Middle.Y - Size / 2, Size, Size); //заполняем эллипc
      
            pen.Dispose();
            solidBrush.Dispose();
        }

        public override bool Hittest(int _x, int _y)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(Middle.X - _x), 2) + Math.Pow(Math.Abs(Middle.Y - _y), 2)) <= Size/2;
        }
    }
}
