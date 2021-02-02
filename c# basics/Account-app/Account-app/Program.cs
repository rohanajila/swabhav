using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account("rohan", 500.05f);
            bool withdrawResponse;
            obj.Deposit(234.50f);
          
            withdrawResponse=obj.Withdraw(500);
            WithdrawMessage(withdrawResponse, obj);
            withdrawResponse =obj.Withdraw(500);
            WithdrawMessage(withdrawResponse, obj);
            AccInfoDisplay(obj);
            Account obj1 = new Account("ashar", 1000.05f);
            withdrawResponse = obj1.Withdraw(200);
            WithdrawMessage(withdrawResponse, obj1);
            withdrawResponse = obj1.Withdraw(500);
            WithdrawMessage(withdrawResponse, obj1);
            AccInfoDisplay(obj1);
            Console.ReadKey();

        }
        public static void AccInfoDisplay(Account obj)
        {
            Console.WriteLine("\nACCOUNT SUMMARY:");
            Console.WriteLine("Account no.: " + obj.getAccountNo());
            Console.WriteLine("Name: " + obj.getName());
            Console.WriteLine("Current Balance: " + obj.getBalance());
            Console.WriteLine("No. of transactions: " + obj.getNoOfTransactions());
            
        }
        public static void WithdrawMessage(bool Response, Account a)
        {
            if (Response == false)
                Console.WriteLine("\n\nInsufficient funds for Withdrawal!!!");
            else
                Console.WriteLine("\n\nWithdrawal succesfull ! \nCurrent Balance: " + a.getBalance());
        }
    }
}
