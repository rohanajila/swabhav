using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorObjectCallCheck
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Inside Parent class constructor");
        }
        private int foo;
        public Parent(int foo)
        {
            this.foo = foo;
        }
        public int getValue()
        {
            return this.foo;
        }
    }
}
