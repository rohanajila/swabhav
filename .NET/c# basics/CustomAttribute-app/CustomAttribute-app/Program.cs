using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAttribute_app
{
    class Program
    {
        static void Main(string[] args)
        {

            Type t = typeof(Foo);
            PrintMethods(t);
            Console.Read();

        }
        public static void PrintMethods(Type t)
        {
            int count = 0;
            MethodInfo[] listOfMethods = t.GetMethods();
            Object fooInstance = Activator.CreateInstance(t);
            Console.WriteLine("Methods returning true value: ");
            foreach(var method in listOfMethods)
            {
                Object[] attributeArray = method.GetCustomAttributes(true);
                foreach(Attribute obj in attributeArray)
                {
                    if(obj is Test)
                    {

                        // Test customAttribute = (Test)obj;
                        // if((method.ReturnParameter).Equals(true))
                        bool resultFromInvoke = (bool)method.Invoke(fooInstance, null);
                        if(resultFromInvoke)
                        Console.WriteLine("Method name: " + method.Name);
                        count++;
                    }
                }
            }
           // Console.WriteLine("Methods with annotation: " + count);
            Console.WriteLine();
        }
    }
}
