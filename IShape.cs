using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laba07.Shape
{
    abstract public class IShape
    {
        public abstract void Save(StreamWriter stream);
	    public abstract void Load(string line);
    }
}
