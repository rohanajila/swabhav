using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringops
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string url = "https://www.swabhav.com?developer='abc':";
            string cname = url.Substring(12,7);
            string dname = url.Substring(35, 3);
         
            Console.WriteLine(cname);
           Console.WriteLine(dname);
          
            url = "https://www.swabhav.com?developer='abc'@course=.net:";
            string coname = url.Substring(47, 4);
            Console.WriteLine(cname);
            Console.WriteLine(dname);
            Console.WriteLine(coname);
            url = "https://www.google.com?developer='abc'@course=.net:";
             cname = url.Substring(12, 6);
           
            Console.WriteLine(cname);
           


            Console.ReadLine();
        }
    }
}
