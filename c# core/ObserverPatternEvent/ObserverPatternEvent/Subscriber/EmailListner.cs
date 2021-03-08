using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternEvent.Publisher;

namespace ObserverPatternEvent.Subscriber
{
    class EmailListner:IListner
    {
        public EmailListner(Account account)
        {
            account.notifyOntransaction += update;
        }
        public void update(Account account, string message, double amount)
        {
            Console.WriteLine("-----EMAIL-----\n");
            Console.Write(amount + " " + message);
            Console.Write(" Account number: " + account.No.ToString().Substring(0, 3) + "XXXXX");
            Console.WriteLine("   Remaining Balance: " + account.Balance);
            Console.WriteLine();
        }
    }
}
