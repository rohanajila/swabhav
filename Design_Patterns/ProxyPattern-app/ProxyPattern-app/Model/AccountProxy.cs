using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_app.Model
{
    class AccountProxy:Account
    {
        public AccountProxy(string accountNo,string accountName,double balance):base(accountNo,accountName,balance)
        { }
        public void Deposit(int amount)
        {
            DateTime time = new DateTime();
            Console.WriteLine("Before depositing date time:  " + time.);
            Console.WriteLine("Balance before depositing:  " + Balance);
            base.Deposit(amount);
            Console.WriteLine("Balance after depositing:  " + Balance);
            Console.WriteLine("After depositing date time:  " + new DateTime());           

        }
    }
}
