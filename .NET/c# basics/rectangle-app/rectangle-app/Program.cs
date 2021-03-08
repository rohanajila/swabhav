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
            Console.WriteLine("Enter the height:");
            obj.Height=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            obj.Width= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color:");
            obj.Color=Console.ReadLine();
            Console.WriteLine("After entering Values: ");
            Display(obj);
            Console.ReadLine();
        }
        public static void Display(Rectangle obj)
        {

            Console.WriteLine("Height = " + obj.Height);
            Console.WriteLine("Width = " + obj.Width);
            Console.WriteLine("Color = " + obj.Color);
        }
    }
}
