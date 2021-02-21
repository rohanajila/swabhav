using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP_violation_app.Model;

namespace OCP_violation_app
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit obj = new FixedDeposit(123, "Rohan", 15000, 2,FestivalType.DIWALI);
            PrintInfo(obj);
            FixedDeposit obj1 = new FixedDeposit(124, "Ashar", 15000, 2, FestivalType.NORMAL);
            PrintInfo(obj1);
            Console.Read();
        }
        public static void PrintInfo(FixedDeposit obj)
        {
            Console.WriteLine("Account no.: " + obj.AccName);
            Console.WriteLine("Name: " + obj.AccName);
            Console.WriteLine("Amount: " + obj.Amount);
            Console.WriteLine("Years: " + obj.Years);
            Console.WriteLine("Festival: " + obj.Festival);
            Console.WriteLine("Simple Interest: " + obj.CalculateSimpleInterest());
        }
    }
}
