using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba07.Shape
{
    public class MyCircle : ShapeCl
    {

        public MyCircle() { }
        public MyCircle(Point p, int s, Color c)
        {
            Id = Convert.ToInt32((new Random()).Next());
            Middle = p;
            Size = s;
            ShapeColor = c;
        }

        public override bool isA(string classname)
        {
            return (classname == "Circle" || base.isA(classname));
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(IsSelected ? Color.Gray : ShapeColor, 1);
            SolidBrush solidBrush = new SolidBrush(IsSelected ? Color.Gray : ShapeColor);

            e.Graphics.DrawEllipse(pen, this.Middle.X - Size / 2, this.Middle.Y - Size / 2, Size, Size);
            e.Graphics.FillEllipse(solidBrush, this.Middle.X - Size / 2, this.Middle.Y - Size / 2, Size, Size); //заполняем эллипc

            pen.Dispose();
            solidBrush.Dispose();
        }

        public override bool Hittest(int _x, int _y)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(Middle.X - _x), 2) + Math.Pow(Math.Abs(Middle.Y - _y), 2)) <= Size / 2;
        }

        public override string SaveString()
        {
            string sel;
            sel = isSelected ? "S" : "N";
            return "C" + ";" + Middle.X.ToString() + ";" + Middle.Y.ToString() + ";" + Size + ";" + 
                shapeColor.Name + ";" + Id.ToString() + ";" + sel;
        }


    }
}
