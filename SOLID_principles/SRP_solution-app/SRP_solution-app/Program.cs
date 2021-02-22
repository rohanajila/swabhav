using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP_solution_app.Model;

namespace SRP_solution_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice obj = new Invoice(123, "rohan", 555.50, 10, 5.6f);
            InvoicePrinter obj1 = new InvoicePrinter(obj);
            obj1.PrintToConsole();
            Console.Read();
        }
    }
}
