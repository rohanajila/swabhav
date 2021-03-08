using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDelegates_app.Model;

namespace GenericDelegates_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using func");
            Console.WriteLine("return type is mandatory but input parameter is not");
            Func<int,int,int> func1 = DelegateClass.Add;
            int value = func1(10, 20);
            Console.WriteLine("With two input parameters");
            Console.WriteLine(value);
            Func<int> func3 = DelegateClass.GetResult;
            int intresultMulti = func3();
            Console.WriteLine("With no input parameters");
            Console.WriteLine(intresultMulti);
            Console.WriteLine("\nUsing action");
            Console.WriteLine("It takes one or more input parameters and returns nothing");
            Action<int,string> action1 = DelegateClass.ShowEmployee;
            action1(23, "Rohan");
            Console.WriteLine("\nUsing predicate");
            Console.WriteLine("It is used to verify certain criteria of method and returns output as Boolean, either True or False");
            Predicate<object> predicate = DelegateClass.IsNumeric;
            bool number = predicate("1234");
            Console.WriteLine("Is numeric: "+number);
            Console.ReadKey();
        }
    }
}
