using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_2
{
    class Model
    {
        int value;


        const int max = 100;
        const int min = 0;
        
        public Model()
        {
            value = 0;
        }

        public int Value
        {
            get { return this.value; }
            set { if(value >= 0 && value <= 100) this.value = value;
            }

        }
    }
}
