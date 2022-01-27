using System;
using System.Collections.Generic;
using System.Text;
using laba07.Shape;
using System.IO;

namespace laba07.Shape
{
    public abstract class IShapeFactory
    {
        public abstract ShapeCl createShape(StreamReader sr);
	     ~IShapeFactory() { }
    }
}
