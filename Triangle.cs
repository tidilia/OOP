using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace laba07.Shape
{
    public class Triangle : ShapeCl
    {
        Point[] CurvePoints = new Point[3];
        double k;

        public Triangle() { }

        public Triangle(int s, Point p, Color c)
        {
            Id = Convert.ToInt32((new Random()).Next());
            Size = s;
            Middle = p;
            ShapeColor = c;
        }

        public override bool isA(string classname)
        {
            return (classname == "Triangle" || base.isA(classname));
        }


        public override void Draw(PaintEventArgs e)
        {
            k = (Math.Sqrt(Math.Pow(Size, 2) - Math.Pow(Size / 2, 2)) / 3);
            CurvePoints[0].Y = Middle.Y + (int)k;
            CurvePoints[0].X = Middle.X - Size / 2;
            CurvePoints[1].Y = Middle.Y - (int)(2 * k);
            CurvePoints[1].X = Middle.X;
            CurvePoints[2].Y = CurvePoints[0].Y;
            CurvePoints[2].X = Middle.X + Size / 2;

            Pen pen = new Pen(IsSelected ? Color.Gray : ShapeColor, 1);
            SolidBrush solidBrush = new SolidBrush(IsSelected ? Color.Gray : ShapeColor);

            e.Graphics.DrawPolygon(pen, CurvePoints);
            e.Graphics.FillPolygon(solidBrush, CurvePoints);

            pen.Dispose();
            solidBrush.Dispose();
        }

        public override bool Hittest(int _x, int _y)
        {
            int zn1; int zn2; int zn3;
            int temp = (CurvePoints[0].X - _x) * (CurvePoints[1].Y - CurvePoints[0].Y) - (CurvePoints[1].X -
                CurvePoints[0].X) * (CurvePoints[0].Y - _y);
            if (temp > 0) zn1 = 1;
            else if (temp == 0) zn1 = 0;
            else zn1 = -1;
            temp = ((CurvePoints[1].X - _x) * (CurvePoints[2].Y - CurvePoints[1].Y) - (CurvePoints[2].X -
                CurvePoints[1].X) * (CurvePoints[1].Y - _y));
            if (temp > 0) zn2 = 1;
            else if (temp == 0) zn2 = 0;
            else zn2 = -1;
            temp = ((CurvePoints[2].X - _x) * (CurvePoints[0].Y - CurvePoints[2].Y) - (CurvePoints[0].X -
                CurvePoints[2].X) * (CurvePoints[2].Y - _y));
            if (temp > 0) zn3 = 1;
            else if (temp == 0) zn3 = 0;
            else zn3 = -1;
            if ((zn1 == zn2 && zn1 == zn3) || (zn3 == 0 || zn1 == 0 || zn2 == 0)) return true;
            else return false;
        }

        public override string SaveString()
        {
            string sel;
            sel = isSelected ? "S" : "N";
            return "T" + ";" + Middle.X.ToString() + ";" + Middle.Y.ToString() + ";" + Size + ";" +
                shapeColor.Name + ";" + Id.ToString() + ";" + sel;
        }
    }
}
