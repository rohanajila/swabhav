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
        
        public static void SayHello(string fname,string lname)
        {
            Console.WriteLine(fname+" "+lname+" says Hello!");
        }

        public static void SayGoodBye(string fname,string lname)
        {
            Console.WriteLine(fname+" "+lname+ " says Goodbye!");
        }/*
        public static void Case1()
        {
            Console.WriteLine("\nCase 1:\n");
          //  DSayAnything x;
            Action<string,string> x = SayHello;

            x("rohan","ajila");

            x = SayGoodBye;
            x("rohan","ajila");
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

        }*/
        
        public static bool SaySomething(string fname,string lname)
        {
            // return fname + " " + lname + " says something";
            return true;
        }
        private static void Case6()
        {
            Func<string, string, bool> x = SaySomething;
            
            Console.WriteLine(x("rohan", "ajila"));
        }
        //public static bool Find
        static void Main(string[] args)
        {
            //Case1();
            // Case2();
            // Case3();
            //  Case4();
            // Case5();
            Case6();
            Console.ReadKey();
        }
    }
}
