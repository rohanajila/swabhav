using System;

namespace CustomException_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account("rohan", 500.05f);
            bool withdrawResponse;
            obj.Deposit(234.50f);         
            
            try
            {
                withdrawResponse = obj.Withdraw(500);
                WithdrawMessage(withdrawResponse, obj);
                withdrawResponse = obj.Withdraw(500);
                WithdrawMessage(withdrawResponse, obj);
            }
            catch (InsufficientBalance e)
            {
                Console.WriteLine("Insufficient balance exception: {0}", e.Message);
            }
            finally { AccInfoDisplay(obj); }
            
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
