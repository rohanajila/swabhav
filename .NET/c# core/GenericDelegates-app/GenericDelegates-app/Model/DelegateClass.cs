using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates_app.Model
{
    class DelegateClass
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int GetValue(int x)
        {
            return (10 + x);
        }
        public static void ShowValue(int x)
        {
            Console.WriteLine("Value" + x);
        }
        public static int GetResult()
        {
            int x = 30;
            int y = 20;
            return x * y;
        }
        public static void ShowEmployee(int age, String name)
        {
            Console.WriteLine("My Name is " + name);
            Console.WriteLine("My age is " + age);
        }
        public static void ShowMessage(String msg)
        {
            Console.WriteLine(msg);
        }
        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}
