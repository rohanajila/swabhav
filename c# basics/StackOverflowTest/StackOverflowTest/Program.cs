using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im inside main..");
            m1();
            Console.WriteLine("End of program");
        }
        private static void m1()
        {
            Console.WriteLine("I'm inside m1...");
            Main(null);
            m2();
        }
        private static void m2()
        {
            Console.WriteLine("I'm inside m2...");
        }
    }
}
