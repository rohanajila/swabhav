using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_app.Model
{
    public class Account
    {
        private long _accNo;
        private string _accName;
        private double _balance;
        private string _branch;
        private double _interestRate;
        public long AccNo { get => _accNo; set => _accNo = value; }
        public string AccName { get => _accName; set => _accName = value; }
        public double Balance { get => _balance; set => _balance = value; }
        public string Branch { get => _branch; set => _branch = value; }
        public double InterestRate { get => _interestRate; set => _interestRate = value; }
    }
}
