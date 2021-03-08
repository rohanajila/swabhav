using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1.Publisher
{
    public delegate void MyDelegate(int a);
    class XX
    {
        public event MyDelegate MyEvent;

        public void RaiseEvent()
        {
            MyEvent(20);
            Console.WriteLine("Event Raised");
        }

        public void Display(int x)
        {
            Console.WriteLine("Display Method {0}", x);
        }
    }
}

