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
            Rectangle obj1 = obj;
            Console.WriteLine("obj hashcode" + obj.GetHashCode());
            Console.WriteLine("obj1 hashcode" + obj1.GetHashCode());
            Rectangle obj2 = new Rectangle();
            obj2.setheight();
            obj2.setwidth();
            obj2.setcolor();
            obj1 = obj2;
            Console.WriteLine("obj hashcode" + obj.GetHashCode());
            Console.WriteLine("obj1 hashcode" + obj1.GetHashCode());
            Console.WriteLine("obj2 hashcode" + obj2.GetHashCode());

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
