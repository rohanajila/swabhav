using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_violation_app.Model
{
    class FixedDeposit
    {
        private int _accNo;
        private string _accName;
        private double _amount;
        private int _years;
        private FestivalType _festival;
        public FixedDeposit(int accNo,string accName,double amount,int years,FestivalType festival)
        {
            _accNo = accNo;
            _accName = accName;
            _amount = amount;
            _years = years;
            _festival = festival;
        }
        public int AccNo { get => _accNo; }
        public string AccName { get => _accName; }
        public double Amount { get => _amount; }
        public int Years { get => _years; }
        public FestivalType Festival { get => _festival; }
        public double CalculateSimpleInterest()
        {
            double interest = 0;
            double rateOfInterest = 0;
            if (Festival.ToString().Equals("NORMAL"))
            {
                rateOfInterest = 7;
                interest = (Amount * rateOfInterest * Years) / 100;
            }
            if (Festival.ToString().Equals("DIWALI"))
            {
                rateOfInterest = 4;
                interest = (Amount * rateOfInterest * Years) / 100;
            }
            if (Festival.ToString().Equals("HOLI"))
            {
                rateOfInterest = 5;
                interest = (Amount * rateOfInterest * Years) / 100;
            }
            return interest;
        }
    }
    enum FestivalType { NORMAL=7,HOLI=5,DIWALI=4};
}
