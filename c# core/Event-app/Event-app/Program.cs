using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event_app.Publisher;

namespace Event_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
           
            c.AdditionCompleted += PrintAddDetails;
            c.Add(10, 20);

            Console.ReadKey();
        }
        private static void PrintAddDetails(int x,int y,int answer)
        {
            Console.WriteLine(x + " + " + y+"=" + answer);
        }
    }
}
