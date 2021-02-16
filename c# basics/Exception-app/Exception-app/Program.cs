using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_app
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 int a = int.Parse(args[0]);
                 int b = int.Parse(args[1]);

                 int c = a / b;
             }
             catch(Exception e)
             {
                 Console.WriteLine("Exception caught: "+e.Message);
             }

             finally
             { Console.WriteLine("End of the program"); }
             */
            m1();
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
        public static void m1()
        {
            Console.WriteLine("m1 is called");
            m2();
        }
        public static void m2()
        {
            Console.WriteLine("m2 is called");
            m3();
         
        }
        public static void m3()
        {
            
            try 
            {
                Console.WriteLine("m3 is called");
                throw new Exception();
            }
            catch(Exception)
            {

            }
            
        }
    }
}
