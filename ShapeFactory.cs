using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laba07.Shape
{
    public class ShapeFactory : IShapeFactory
    {

        public ShapeFactory() { }
        public override ShapeCl createShape(StreamReader sr)
        {
            string line = sr.ReadLine();
            string[] subs = line.Split(";");
            switch (subs[0])
            {
                case "C":
                    {
                        MyCircle newC = new MyCircle();
                        newC.Load(line);
                        return newC;
                    }
                case "R":
                    {
                        MyRectangle newR = new MyRectangle();
                        newR.Load(line);
                        return newR;
                    }
                case "T":
                    {
                        Triangle newT = new Triangle();
                        newT.Load(line);
                        return newT;
                    }
                case "GS":
                    {
                        int k = Convert.ToInt32(sr.ReadLine());
                        Group newG = new Group();
                        for(int i = 0; i < k; ++i)
                        {
                            newG.add_el(createShape(sr));
                        }
                        return newG;
                    }
            }
            ShapeCl shape = new ShapeCl();
            return shape;
        }
    }
}
