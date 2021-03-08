using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute_app
{
    class Foo
    {
        [Test]
        public bool m1()
        {
          //  Console.WriteLine("Inside m1");
            return true;
        }
        public bool m2()
        {
            //Console.WriteLine("Inside m2");
            return true;
        }
        [Test]
        public bool m3()
        {
            //Console.WriteLine("Inside m3");
            return false;
        }
        [Test]
        public bool m4()
        {
           // Console.WriteLine("Inside m4");
            return true;
        }
    }
}
