using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_app.Model
{
    public class SMSListner:IListner
    {
        
        public void update(Account account,string message,double amount)
        {
            Console.Write(amount+" "+message);
            Console.Write(" Account number: " + account.No.ToString().Substring(0, 3) + "XXXXX");
            Console.WriteLine("   Remaining Balance: " + account.Balance);
            Console.WriteLine();
        }
    }
}
