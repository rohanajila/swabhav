using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventExample1.Publisher;

namespace EventExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            XX obj = new XX();
            obj.MyEvent += new MyDelegate(obj.Display);

            obj.RaiseEvent();
            Console.Read();
        }
    }
}
