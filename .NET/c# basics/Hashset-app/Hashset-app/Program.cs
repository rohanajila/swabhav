using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_app
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> mySet = new SortedSet<string>();

            
            mySet.Add("DS");
            mySet.Add("C++");
            mySet.Add("");
            mySet.Add("C++");
            mySet.Add("Java");
            mySet.Add("JavaScript");

            Console.WriteLine("-------");
            foreach (string s in mySet)
            {
                Console.WriteLine(s);
            }
            if (mySet.Contains("Java"))
            {
                Console.WriteLine("Required Element is present");
                mySet.Remove("Java");
                mySet.Add(".NET");
            }
            else
                Console.WriteLine("Required Element is not present");
            Console.WriteLine("-------");
            foreach (string s in mySet)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
