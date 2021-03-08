using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_1
{
    class Puzzle4b
    {
        public int ivar;
        public int doStuff(int factor)
        {
            if (ivar > 100)
            {
                return ivar * factor;
            }
            else
            {
                return ivar * (5 - factor);
            }
        }
    }
}
