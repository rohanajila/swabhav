using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1, i2 = 1;
            Console.WriteLine("i1==i2 : " + (i1 == i2));
            int num1 = 1;
            int num2 = 1;
            Console.WriteLine("num1 == num2 : " + (num1 == num2));

            object one = 1;
            object anotherOne =1;
            Console.WriteLine("one == anotherOne : " + (one == anotherOne));
            Console.Read();
        }
    }
}
