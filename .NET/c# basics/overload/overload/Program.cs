using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Program
    {
        private static void printinfo(bool a)
        {
            Console.Write("\nBoolean value:" + a);
        }
        private static void printinfo(char a)
        {
            Console.Write("\nCharacter:" + a);
        }
        private static void printinfo(decimal a)
        {
            Console.Write("\nDecimal value:" + a);
        }
        private static void printinfo(double a)
        {
            Console.Write("\nDouble value:" + a);
        }
        private static void printinfo(float a)
        {
            Console.Write("\nFloat value:" + a);
        }

        private static void printinfo(int a)
        {
            Console.Write("\nInteger value:" + a);
        }
        private static void printinfo(string name)
        {
            Console.Write("\nString :" + name);
        }
        static void Main(string[] args)
        {
            printinfo(true);
            printinfo('b');
            printinfo(4.56754321546548976853435m);
            printinfo(4.56564654d);
            printinfo(8.1245f);
            printinfo(5);
            printinfo("true");
            printinfo("rohan");
            Console.ReadLine();
        }
        
    }
   



}
