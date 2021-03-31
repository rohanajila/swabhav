using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithArray_app
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            var SortedNames = names.OrderBy(x => x);
            Console.WriteLine("Sorted Names List Ascendingly:");
            foreach(var name in SortedNames)
            {
                Console.WriteLine(name);
            }
           
            string max = names.OrderByDescending(x => x.Length).First();
            Console.WriteLine("Name with maximum no. of characters: " + max);
            Console.ReadKey();

        }
    }
}
