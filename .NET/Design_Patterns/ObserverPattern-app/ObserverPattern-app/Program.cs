using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern_app.Model;

namespace ObserverPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1125425, "rohan", 5000.75);
            account.AddListners(new SMSListner());
            account.Withdraw(2000);
            account.Deposit(10000);
            Console.Read();
        }
    }
}
