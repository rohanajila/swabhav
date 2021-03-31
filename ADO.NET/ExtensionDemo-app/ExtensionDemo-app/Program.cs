using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "I am learning extension method";
            Console.WriteLine(test.ToSnakeCase());
            Console.ReadKey();
        }
    }
}
