using System;
using System.Collections.Generic;
using System.Text;
using laba07.Shape;

namespace laba07.Observer
{
    class ShapeStorage: CSubject
    {
        List<ShapeCl> shapes = new List<ShapeCl>();
        public ShapeStorage() { }

        public void add_el(ShapeCl newshape)
        {
            shapes.Add(newshape);
            notifyEveryone();
        }

        public void del_el(ShapeCl delshape)
        {
            shapes.Remove(delshape);
            notifyEveryone();
        }

        public void sel_change(ShapeCl shapeCl)
        {
            for(int i = 0; i < shapes.Count; ++i)
            {
                if(shapeCl.Id == shapes[i].Id)
                {
                    shapes[i].IsSelected = shapeCl.IsSelected;
                    notifyEveryone();
                    return;
                }
            }
        }

        public ShapeCl GetShape(int i)
        {
            return shapes[i];
        }

        public int GetCount()
        {
            return shapes.Count;
        }

    }
}
