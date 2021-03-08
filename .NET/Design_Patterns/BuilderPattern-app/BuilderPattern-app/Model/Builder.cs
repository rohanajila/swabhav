using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_app.Model
{
    public class Builder
    {
        private long _accNo;
        private string _accName;
        private double _balance;
        private string _branch;
        private double _interestRate;

        public Builder(int accNo)
        {
            _accNo = accNo;
        }

        public Builder BuildAccName(string accName)
        {
            _accName = accName;
            return this;
        }
        public Builder BuildBalance(double balance)
        {
            _balance = balance;
            return this;
        }
        public Builder BuildBranch(string branch)
        {
            _branch = branch;
            return this;
        }
        public Builder BuildInterestRate(double interestRate)
        {
            _interestRate = interestRate;
            return this;
        }
        public Account Build()
        {
            Account account = new Account();
            account.AccNo = _accNo;
            account.AccName = _accName;
            account.Branch = _branch;
            account.Balance = _balance;
            account.InterestRate = _interestRate;
            return account;

        }
    }
}
