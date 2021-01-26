using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_app
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle obj = new rectangle();
            obj.height = 4;
            obj.width = 5;
            obj.color = "red";
            obj.display();
        }
    }
}
