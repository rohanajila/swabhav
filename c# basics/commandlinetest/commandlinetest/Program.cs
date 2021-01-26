using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandlinetest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[args.Length - 1];
            for (int i = 0; i < args.Length - 1; i++)
            {
                n[i] = int.Parse(args[i]);
            }
            string flag = args[args.Length - 1];

            if (flag == "e")
            {
                Console.WriteLine("Even Numbers: ");
                printevenNo(n);
            }
            else if (flag == "o")
            {
                Console.WriteLine("Odd Numbers: ");
                printoddNo(n);
            }
            else if (flag == "p")
            {
                Console.WriteLine("Prime Numbers: ");
                printprimeNo(n);
            }
            else
            {
                Console.WriteLine("Not found flag !\n Values are:");
                for (int i = 0; i < n.Length; i++)
                {
                    Console.WriteLine(n[i]);
                }
            }
            Console.ReadLine();
        }
        public static void printevenNo(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                    Console.WriteLine(n[i]);
            }

        }
        public static void printoddNo(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                    Console.WriteLine(n[i]);
            }


        }
        public static void printprimeNo(int[] n)
        {
            int i, j;
            for ( i = 0; i < n.Length; i++)
            {

                for ( j = 2; j < n[i]; j++)
                    if ((n[i] % j == 0))
                    {

                        Console.WriteLine("{0} : Is NOT a primenumber", +n[i]);
                        break;
                    }
                if (j == n[i])
                {
                    Console.WriteLine("{0} : Is a primenumber", +n[i]);



                }
            }
        }

    }
}