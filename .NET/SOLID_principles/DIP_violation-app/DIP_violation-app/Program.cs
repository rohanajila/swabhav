using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP_violation_app.Model;

namespace DIP_violation_app
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculation txc = new TaxCalculation(LogType.XML);
            Console.WriteLine(txc.Calculate(10, 5));
            Console.WriteLine(txc.Calculate(0, 0));
            Console.Read();
        }

    }
    public enum LogType
    {
        XML,TXT
    }
}
