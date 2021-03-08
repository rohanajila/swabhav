using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorObjectCallCheck
{
    public class Child : Parent
    {
        private int foo;
        public Child ()
        {
            Console.WriteLine("Inside Child class constructor");
        }
        public Child (int foo) : base(foo)
        {
            this.foo
        }
        
    }
}
