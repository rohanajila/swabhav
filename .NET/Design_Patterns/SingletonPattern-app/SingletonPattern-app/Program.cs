using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPattern_app.Model;

namespace SingletonPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService d1 = DataService.getInstance();
            DataService d2 = DataService.getInstance();
            Console.WriteLine("d1 Hash Code: " + d1.GetHashCode());
            Console.WriteLine("d2 Hash Code: " + d2.GetHashCode());
            d1.ProcessData();
            d2.ProcessData();
            Console.Read();
        }
    }
}
