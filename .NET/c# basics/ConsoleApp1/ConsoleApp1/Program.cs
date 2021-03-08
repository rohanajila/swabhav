using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int[] arr = { 10, 20, 30, 40 };
            string name = "rohan";
            Console.WriteLine("Initial value: " + a);
            Console.WriteLine("Initial array values: ");
            for (int i = 0; i < arr.Length; i++)
                     Console.Write("  "+arr[i]);
            Console.WriteLine("\nInitial string: " + name);
            printnumber(a);
            printarrayvalue(arr);
            printstring(name);
            Console.WriteLine("\nModified value: " + a);
            Console.WriteLine("Modified array values: ");
            for (int i = 0; i < arr.Length; i++)
                      Console.Write("  " + arr[i]);
            Console.WriteLine("\nModified string: " + name);
            Console.ReadLine();

           
        }
        public static void printarrayvalue(int[] arr)
        {
            for (int i=0; i < arr.Length; i++)
                arr[i] = 0;

        }
        public static void printnumber(int a)
        {
                a = 0;

        }
        public static void printstring(string name)
        {
            name = "rohan ajila";

        }
    }
}
