using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba06_selfmade.Shape
{
    public class MyRectangle: ShapeCl
    {
        public MyRectangle(Point p, int s, Color c)
        {
            Middle = p;
            Size = s;
            ShapeColor = c;
        }
        public override void Draw(PaintEventArgs e) 
        {
            Pen pen = new Pen(IsSelected ? Color.Gray : ShapeColor, 1);
            SolidBrush solidBrush = new SolidBrush(IsSelected ? Color.Gray : ShapeColor);

            e.Graphics.DrawRectangle(pen, Middle.X - Size / 2, Middle.Y - Size / 2, Size, Size);
            e.Graphics.FillRectangle(solidBrush, Middle.X - Size / 2, Middle.Y - Size / 2, Size, Size);
        }

        public override bool Hittest(int _x, int _y)
        {
            return ((_x >= Middle.X - Size / 2) && (_x <= Middle.X + Size / 2) && (_y >= Middle.Y - Size / 2)
                && (_y <= Middle.Y + Size / 2));
        }
    }
}
