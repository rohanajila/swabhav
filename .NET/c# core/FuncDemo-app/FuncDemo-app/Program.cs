using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemo_app
{
   
    class Program
    {
        public static long f1(int a, int b)
        {
            Console.WriteLine("Inside named function");
            return a + b;
        }
        public static long Case1()
        {
            Func<int,int,long> x;
            x = f1;
            return x(10,20);
        }
        public static long Case2()
        {
            Func<int, int, long> x;
            x = (delegate (int a,int b)
            {
                Console.WriteLine("Inside anonymous function");
                return a - b;
            });
            return x(20,10);
        }
        public static long Case3()
        {
            Func<int, int, long> x;
            x = ((int a,int b) =>
            {
                Console.WriteLine("Inside lambda function");
                return a * b;
            });
            return x(10,10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition: "+Case1());
            Case2();
            Case3();
            Console.Read();
        }
    }
}

