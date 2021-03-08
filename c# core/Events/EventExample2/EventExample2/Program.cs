using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventExample2.Publisher;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            XX obj = new XX();
            obj.MyEvent += new MyDelegate(obj.Add);
            obj.MyEvent += new MyDelegate(obj.Subtract);
            obj.RaiseEvent(20, 10);
            Console.Read();
        }
    }
}
