using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandline
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
                Console.Write(" "+arr[i]); 
            
            Console.ReadLine();
        }
    }
}
