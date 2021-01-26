using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.google.com?developer=abc@course=dotnet:";
            string[] multiArray = url.Split(new Char[] { '.', '@', '='});

          
            string cname = multiArray[1];
            string dname = multiArray[3];
            string coname = multiArray[5];
            Console.WriteLine("Company name: " + cname);
            Console.WriteLine("Developer name: " + dname);
            Console.WriteLine("Course name: " + coname);
            Console.ReadLine();
        }
    }
}
