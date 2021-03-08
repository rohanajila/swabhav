using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 point = new Class1(10, 20);
            modify(point);
            Console.WriteLine("values after mod:" + point.x + "  " + point.y);
            Console.ReadKey();
        }
        public static void modify(Class1 point)
        {
            point.x = 0;
            point.y = 0;
        }
    }
}
