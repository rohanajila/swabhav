using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousobject_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Rectangle().GetHashCode());
            Console.WriteLine(new Rectangle().GetHashCode());

            new Rectangle().height=20;
            new Rectangle().width=10;

            Console.WriteLine("Height"+new Rectangle().getheight());
            Console.WriteLine("width" + new Rectangle().getwidth());
            Console.WriteLine("Hashcode" + new Rectangle().GetHashCode());

            Console.ReadKey();
        }
    }
}
