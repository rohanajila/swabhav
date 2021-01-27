using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            Console.WriteLine("Initial Values: ");
            Display(obj);
            obj.setheight();
            obj.setwidth();
            obj.setcolor();
            Console.WriteLine("After entering Values: ");
            Display(obj);
            Console.ReadLine();
        }
        public static void Display(Rectangle obj)
        {

            Console.WriteLine("Height = " + obj.getheight());
            Console.WriteLine("Width = " + obj.getwidth());
            Console.WriteLine("Color = " + obj.getcolor());
        }
    }
}
