using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_app
{
    public delegate void DSayAnything(String name);
    class Program
    {
        public static void SayHello(string name)
        {
            Console.WriteLine("Inside named function");
            Console.WriteLine("Hello " + name);
        }
        public static void Case1()
        {
            DSayAnything x;
            x = SayHello;
            x("Rohan");
        }
        public static void Case2()
        {
            DSayAnything x;
            x = (delegate (string name)
              {
                  Console.WriteLine("Inside anonymous function");
                  Console.WriteLine("Hello " + name);
              });
            x("Rohan");
        }
        public static void Case3()
        {
            DSayAnything x;
            x = ((name) =>
            {
                Console.WriteLine("Inside lambda function");
                Console.WriteLine("Hello " + name);
            });
            x("Rohan");
        }
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Console.Read();
        }
    }
}
