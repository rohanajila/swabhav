using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] obj = new Circle[3];
            obj[0] = new Circle();
            obj[1] = new Circle();
            obj[2] = new Circle();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the radius of circle " + (i + 1));
                obj[i].Radius = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the color of circle " + (i + 1));
                obj[i].Color = Console.ReadLine();
            }
            printCircleInfo(obj);
            printRadiusMaxCircleInfo(obj);
            Console.ReadKey();

        }
        public static void printCircleInfo(Circle[] obj)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nradius of circle " + (i + 1) + " : " + obj[i].Radius);
                Console.WriteLine("color of circle " + (i + 1) + " : " + obj[i].Color);
            }
        }
        public static void printRadiusMaxCircleInfo(Circle[] obj)
        {
            int max = 0;
            for (int i = 0; i < 2; i++)
            {
                if (obj[i].Radius > obj[i + 1].Radius)
                {
                    max = i;
                }
                else
                    max = i + 1;

            }
            obj[max].MaxRadius = 1;
            for (int i = 0; i < 3; i++)
            {
                if (obj[i].MaxRadius == 1)
                {
                    Console.WriteLine("\nMax Radius\nCircle " + (i + 1));
                    Console.WriteLine(obj[i].Radius);
                }
            }
        }
       
    }
}