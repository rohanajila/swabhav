using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandline1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
                arr[i] = int.Parse(args[i]);
            Console.WriteLine("values: ");
            for (int i = 0; i < 4; i++)
                Console.Write(" " + arr[i]);
            Console.WriteLine("\n");
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine(arr[i]+" is even");
                else
                    Console.WriteLine(arr[i]+" is odd");
            }

                Console.ReadLine();
        }
    }
}
