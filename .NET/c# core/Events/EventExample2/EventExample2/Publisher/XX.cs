using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2.Publisher
{
    public delegate void MyDelegate(int a, int b);
    class XX
    {
        public event MyDelegate MyEvent;

        public void RaiseEvent(int a, int b)
        {
            MyEvent(a, b);
            Console.WriteLine("Event Raised");
        }

        public void Add(int x, int y)
        {
            Console.WriteLine("X+Y : {0}", x + y);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("X-Y : {0}", x - y);
        }
    }
}
