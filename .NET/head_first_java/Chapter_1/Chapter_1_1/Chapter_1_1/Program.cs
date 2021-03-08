using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1_1
{
    class Program  //shuffle
    {
        static void Main(string[] args)
        {
            int x = 3;
            while(x>0)
            {
                if (x > 2)
                    Console.Write("a");
                x = x - 1;
                Console.Write("-");
                if (x == 2)
                    Console.Write("b c");
                if(x==1)
                {
                    Console.Write("d");
                    x = x - 1;
                }
            }
            Console.ReadLine();
        }
    }
}
