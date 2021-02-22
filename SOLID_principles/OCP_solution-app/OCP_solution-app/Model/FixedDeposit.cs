using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_solution_app.Model
{
    class FixedDeposit
    {
        private int _accNo;
        private string _accName;
        private double _amount;
        private int _years;
        private IFestivalRate _festName;
        
        public FixedDeposit(int accNo, string accName, double amount, int years,IFestivalRate festName)
        {
            _accNo = accNo;
            _accName = accName;
            _amount = amount;
            _years = years;
            _festName = festName;
          
        }
        public int AccNo { get => _accNo; }
        public string AccName { get => _accName; }
        public double Amount { get => _amount; }
        public int Years { get => _years; }
        public IFestivalRate FestName { get => _festName; }
        public double CalculateSimpleInterest()
        {
            double interest = 0;
            double rateOfInterest = FestName.getRate();
            interest = (Amount * rateOfInterest * Years) / 100;
            return interest;
           
        }
    }
}

