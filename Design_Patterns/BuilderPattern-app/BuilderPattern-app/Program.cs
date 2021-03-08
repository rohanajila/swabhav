using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_app.Model;

namespace BuilderPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Builder(101)
               .BuildAccName("Rohan")
               .BuildInterestRate(10.5)
               .BuildBalance(5000)
               .BuildBranch("Ghansoli")
               .Build();

            PrintInfo(account);
            Console.Read();
        }
        private static void PrintInfo(Account account)
        {
            Console.WriteLine("Account No.: " + account.AccNo);
            Console.WriteLine("Name: " + account.AccName);
            Console.WriteLine("Balance: " + account.Balance);
            Console.WriteLine("Branch: " + account.Branch);
            Console.WriteLine("Interest Rate: " + account.InterestRate);
        }
    }
}
