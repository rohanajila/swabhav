using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_1
{
    class Puzzle4
    {
        static void Main(string[] args)
        {
            Puzzle4b[] abs = new Puzzle4b[6];
            int y = 1;
            int x = 0;
            int result = 0;
            while(x<6)
            {
                abs[x] = new Puzzle4b();
                abs[x].ivar = y;
                y = y * 10;
                x = x + 1;
            }
            x = 6;
            while(x>0)
            {
                x = x - 1;
                result = result + abs[x].doStuff(x);
            }
            Console.WriteLine("result " + result);
            Console.ReadLine();
        }
    }
   
}
