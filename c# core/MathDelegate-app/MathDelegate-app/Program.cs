using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegate_app
{
    public delegate void DMathOperation(int a, int b);
    class Program
    {
        public static int result;
        public static void Add(int a,int b)
        {
            Console.WriteLine("Result of addition: "+(result = a + b));
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Result of subtraction: " + (result = a - b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Result of multiplication: " + (result = a * b));
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine("Result of division: " + (result = a / b));
        }
        public static void case1()
        {
            Console.WriteLine("\nCase1:\n");
            DMathOperation d = Add;
            d(10, 20);
            d = Subtract;
            d(30, 20);
            d = Multiply;
            d(20, 10);
            d = Division;
            d(10, 2);
        }

        public static void case2()
        {
            Console.WriteLine("\nCase 2:\n");
            DMathOperation[] darr = new DMathOperation[4] { Add,Subtract,Multiply,Division};
            /*
            foreach (DMathOperation operation in darr)
            {
                operation(50, 20);
            }*/
            for (int i = 0; i < 4; i++)
            {
                darr[i](50,20);
            }
                
        }
        static void Main(string[] args)
        {
            case1();
            case2();
            Console.ReadKey();
        }
    }
}
