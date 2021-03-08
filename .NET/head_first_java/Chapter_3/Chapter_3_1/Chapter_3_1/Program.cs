using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";
            int y = 0;
            int ref1;
            while(y<4)
            {
                ref1= index[y];
                Console.Write("island = ");
                Console.WriteLine(islands[ref1]);
                y = y + 1;
            }
            Console.ReadLine();
        }
    }
}
