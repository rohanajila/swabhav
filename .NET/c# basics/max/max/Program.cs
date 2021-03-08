using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.Write("Input 10 elements in the array :\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);  
            Array.Reverse(arr);  
            Console.WriteLine(" Highest Value In Array " + arr[0]);
            Console.WriteLine("Second Highest Value In Array " + arr[1]);
            Console.ReadLine();


        }
    }
}
