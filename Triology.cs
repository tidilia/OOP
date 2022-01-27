using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_2
{
    class Triology
    {
        Model a = new Model();
        Model b = new Model();
        Model c = new Model();

        public EventHandler TRIobservers;

        public enum Model_el
        {
            A, B, C
        }

        public Triology()
        {
            a = new Model();
            b = new Model();
            c = new Model();

        }

        public void setValue(Model_el _m, int value)
        {
            switch (_m)
            {
                case Model_el.A:
                    {
                        if (value > b.Value)
                        {
                            if (value > c.Value)
                            {
                                b.Value = value;
                                c.Value = value;
                            }
                            else
                            {
                                b.Value = value;
                            }
                        }
                        a.Value = value;
                        break;
                    }
                case Model_el.B:
                    {
                        if (value > c.Value)
                            c.Value = value;
                        if (value < a.Value)
                            b.Value = a.Value;
                        else b.Value = value;
                        break;
                    }
                case Model_el.C:
                    {
                        if (value >= a.Value && value >= b.Value) c.Value = value;
                        break;
                    }
            }
            TRIobservers.Invoke(this, null);
        }

        public int GetValue(Model_el _m)
        {
            int res = 0;
            switch (_m)
            {
                case Model_el.A:
                    {
                        res = a.Value;
                        break;
                    }
                case Model_el.B:
                    {
                        res = b.Value;
                        break;
                    }
                case Model_el.C:
                    {
                        res = c.Value;
                        break;
                    }
            }
            return res;
        }

    }
}
