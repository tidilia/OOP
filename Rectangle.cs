using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba07.Shape
{
    public class MyRectangle : ShapeCl
    {
        public MyRectangle() { }

        public MyRectangle(Point p, int s, Color c)
        {
            Id = Convert.ToInt32((new Random()).Next());
            Middle = p;
            Size = s;
            ShapeColor = c;
        }

        public override bool isA(string classname)
        {
            return (classname == "Rectangle" || base.isA(classname));
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

        public override string SaveString()
        {
            string sel;
            sel = isSelected ? "S" : "N";
            return "R" + ";" + Middle.X.ToString() + ";" + Middle.Y.ToString() + ";" + Size + ";" +
                shapeColor.Name + ";" + Id.ToString() + ";" + sel;
        }
    }
}