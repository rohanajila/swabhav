using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int G;

          
            Sum(out G);

            
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
            string str = "hello";

          
            SetValue(ref str);

           
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static void Sum(out int G)
        {
            G = 80;
            
        }
        static void SetValue(ref string str1)
        {

           
            if (str1 == "hello")
            {
                Console.WriteLine("Changing value");
            }

           
            str1 = "Hello!";
        }
    }
}
