using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP_solution_app.Model;

namespace ISP_solution_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Managers\n");
            Managers obj = new Managers();
            obj.StartWork();
            obj.StopWork();
            obj.StartEat();
            obj.StopEat();
            Console.WriteLine("\nRobots\n");
            Robots obj1 = new Robots();
            obj1.StartWork();
            obj1.StopWork();
            Console.Read();
        }
    }
}
