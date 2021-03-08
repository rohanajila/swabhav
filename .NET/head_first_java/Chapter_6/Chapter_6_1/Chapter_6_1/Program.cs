using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("zero");
            a.Add("one");
            a.Add("two");
            a.Add("three");
            printAL(a);
            if (a.Contains("three"))
                a.Add("four");
            a.RemoveAt(2);
            printAL(a);
            if (a.IndexOf("four") != 4)
                a.Add("4.2");
            printAL(a);
            if (a.Contains("two"))
                a.Add("2.2");
            printAL(a);

            Console.ReadKey();

        }
        public static void printAL(ArrayList a1)
        {
            foreach(string element in a1)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
