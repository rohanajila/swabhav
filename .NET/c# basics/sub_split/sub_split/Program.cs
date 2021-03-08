using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_split
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.google.com?developer=abc@course=dotnet";
            substring(url);
            split(url);
            Console.ReadLine();
           


        }
        public static void split(string url)
        {
            string[] multiArray = url.Split(new Char[] { '.', '@', '=' });


            string cname = multiArray[1];
            string dname = multiArray[3];
            string coname = multiArray[5];
            Console.WriteLine("Company name: " + cname);
            Console.WriteLine("Developer name: " + dname);
            Console.WriteLine("Course name: " + coname);
           
        }
        public static void substring(string url)
        {
           
            string cname = url.Substring(12, 6);
            string dname = url.Substring(33, 3);
            string coname = url.Substring(44, 6);
            Console.WriteLine("Company name: " + cname);
            Console.WriteLine("Developer name: " + dname);
            Console.WriteLine("Course name: " + coname);

        }
    }
}
