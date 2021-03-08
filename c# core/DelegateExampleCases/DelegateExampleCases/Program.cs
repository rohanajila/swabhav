using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleCases
{
    public delegate void DSayAnything(string name);
    class Program
    {
        
        public static void SayHello(string name)
        {
            Console.WriteLine(name+" says Hello!");
        }

        public static void SayGoodBye(string name)
        {
            Console.WriteLine(name+ " says Goodbye!");
        }
        public static void Case1()
        {
            Console.WriteLine("\nCase 1:\n");
            DSayAnything x;
            x = SayHello;

            x("rohan");

            x = SayGoodBye;
            x("rohan");
        }
        public static void Case2()
        {
            Console.WriteLine("\nCase 2:\n");
            DSayAnything y;
            y = SayHello;
            y += SayGoodBye;
            y("xyz");
        }
        public static void MessageWizard(DSayAnything fn)
        {
            Console.WriteLine("Inside Message Wizard");
            fn("champ");
        }
        public static void Case3()
        {
            Console.WriteLine("\nCase 3:\n");
            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
        }
        public static void Case4()
        {
            Console.WriteLine("\nCase 4:\n");
            MessageWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous delegate function");
                Console.WriteLine("Hello {0}....", name);

            });
        }
        private static void Case5()
        {
            Console.WriteLine("\nCase 5:\n");
            MessageWizard((n) =>
            {
                Console.WriteLine("Lambda");
                Console.WriteLine("Hello {0}....", n);

            });

        }

        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Case4();
            Case5();
            Console.ReadKey();
        }
    }
}
