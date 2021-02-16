using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling_app
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandling wr = new FileHandling();
            wr.WriteData();
            wr.ReadData();
            Console.WriteLine("\n After replacement");
            wr.ReplaceInFile();
            wr.ReadData();
            Console.ReadKey();
        }
    }
}
