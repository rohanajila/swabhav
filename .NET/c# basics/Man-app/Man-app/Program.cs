using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            Boy b = new Boy();
            Kid k = new Kid();
            Infant i = new Infant();
            case1();
            case2();
            case3();
            case4();
            Console.ReadKey();

        }
        public static void case1()
        {
            Console.WriteLine("Case 1: ");
            Man x = new Man();
            x.Plays();
            x.Reads();

        }
        public static void case2()
        {
            Console.WriteLine("Case 2: ");
            Boy y = new Boy();
            y.Plays();
            y.Eats();
            y.Reads();
        }
        public static void case3()
        {
            Console.WriteLine("Case 3: ");
            Man x = new Boy();
            x.Plays();
            x.Reads();
        }
        public static void case4()
        {
            Console.WriteLine("Case 4: ");
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
    }
}
