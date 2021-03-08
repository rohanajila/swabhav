using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_app
{
    [Serializable]
    class Account
    {
        private string AccountNo;
        private string Name;
        private float Balance;
        private int NoOfTransactions;
        static int AccountNumberCounter = 1000;
      

        public Account(string name, float bal )
        {
            AccountNo = "SBI"+AccountNumberCounter; 
            Name = name;
            Balance = bal;
            AccountNumberCounter += 1;
            
        }
      
        public bool Withdraw(float amount)
        {

            if ((Balance - amount) < 500)
            {
                return false;
            }
            else
            {
                Balance = Balance - amount;
                
                NoOfTransactions++;
                return true;
            }
               
                        
           
        }
        public void Deposit(float amount)
        {
            Balance = Balance + amount;
           
            NoOfTransactions++;
        }
        public string getAccountNo()
        {
            return AccountNo;
        }
        public string getName()
        {
            return Name;
        }
        public float getBalance()
        {
            return Balance;
        }
        public int getNoOfTransactions()
        {
            return NoOfTransactions;
        }
    }
}
