using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProxyPattern_app.Model
{
    public class Account
    {
        private string _accountName;
        private double _balance;
        private string _accountNo;

        public Account(string accountNo, string accountName, double balance)
        {
            _accountNo = accountNo;
            _accountName = accountName;
            _balance = balance;
        }

        public Account(string accountName, double balance)
        {
            _accountName = accountName;
            _balance = balance;
        }

        public  void Deposit(int amount)
        {
            Thread.Sleep(2000);
            _balance = _balance + amount;

        }
        public void Withdraw(int amount)
        {
            _balance = _balance - amount;
        }

        public string AccountName{ get => _accountName; }
        public string AccountNo { get => _accountNo; }
        public double Balance { get => _balance; }
    }
}
