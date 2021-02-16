using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorObjectCallCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Parent(100);
            Child obj1 = new Child(200);
            Console.WriteLine("Parent: "+obj.getValue());
            Console.WriteLine("Child: "+obj1.getValue());
            Console.ReadKey();
        }
    }
}
