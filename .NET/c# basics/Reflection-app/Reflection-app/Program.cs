using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
namespace Reflection_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = (typeof(Array));
            MethodInfo[] m = t.GetMethods();
            Console.WriteLine("\nAll members details:-\n");
            PrintMembers(m);
            FieldInfo[] s = t.g();
            Console.WriteLine("\nSelected members details:-\n");
            PrintMembers(s);
            Console.ReadKey();

        }
        public static void PrintMembers(MemberInfo[] ms)
        {
            foreach (MemberInfo m in ms)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
        }
        /*public static void PrintGetMembers()
        {
            MemberInfo[] sm=t.
        }*/
    }
    
}
