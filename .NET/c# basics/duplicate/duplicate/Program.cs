using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.Write("Input 5 elements in the array :\n");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            findDuplicate(arr);
            findPositive(arr);
           
            Console.ReadLine();
        }
        public static void findDuplicate(int[] arr)
        {
            Console.WriteLine("Duplicate elements in given array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
        }
        public static void findPositive(int[] arr)
        {
            Console.WriteLine("positive elements are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
