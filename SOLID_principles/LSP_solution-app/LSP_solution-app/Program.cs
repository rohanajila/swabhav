using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP_solution_app.Model;

namespace LSP_solution_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle(20, 30);
            Console.WriteLine("Rectangle ");
            PrintShapeInfo(obj1);
            Square obj2 = new Square(20);
            Console.WriteLine("\nSquare ");
            PrintShapeInfo(obj2);
            Console.Read();
        }
        public static void PrintShapeInfo(IShape obj)
        {
            Console.Write("Area: " + obj.CalculateArea());
        }
    }
}
