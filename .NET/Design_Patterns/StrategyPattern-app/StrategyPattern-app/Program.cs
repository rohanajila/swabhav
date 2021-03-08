using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern_app.Model;

namespace StrategyPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10+5= " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationSubtract());
            Console.WriteLine("10-5= " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10*5= " + context.ExecuteStrategy(10, 5));

            Console.Read();
        }
    }
}
