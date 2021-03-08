using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_app.Model
{
    
    public class Account
    {
        private int _no;
        private string _name;
        private double _balance;
        private const string _withdrawalMessage = "debited from";
        private const string _depositMessage = "credited to";
        private List<IListner> _listners;

        

        public Account(int no,string name,double balance)
        {
            _no = no;
            _name = name;
            _balance = balance;
            _listners = new List<IListner>();
        }

        public int No { get => _no; }

        public string Name { get => _name; }

        public double Balance { get => _balance; set => _balance = value; }

        public List<IListner> Listners { get => _listners; }

        public void AddListners(IListner listner)
        {
            _listners.Add(listner);
        }

        public void Withdraw(double withdrawAmount)
        {
            Balance = (Balance - withdrawAmount);
            NotifyListner(_withdrawalMessage,withdrawAmount);            
        }

        public void Deposit(double depositAmount)
        {
            Balance = Balance + depositAmount;
            NotifyListner(_depositMessage,depositAmount);            
        }

        public void NotifyListner(string message,double amount)
        {
            foreach(IListner listner in _listners)
            {
                listner.update(this,message,amount);
            }
        }
    }
}
