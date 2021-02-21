using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_violation_app.Model
{
    class Invoice
    {
        private int _no;
        private string _name;
        private double _amount;
        private double _discountPercentage;
        private float _GST;
        public Invoice(int no,string name,double amount,double discountPercentage,float GST)
        {
            _no = no;
            _name = name;
            _amount = amount;
            _discountPercentage = discountPercentage;
            _GST = GST;
        }
        public int No { get => _no; }
        public string Name { get => _name; }
        public double Amount { get => _amount; }
        public double DiscountPercentage { get => _discountPercentage; }
        public double GST { get => _GST; }
        public double CalculateDiscount()
        {
            return (Amount * DiscountPercentage / 100);
        }
        public double CalculateGST()
        {
            return GST * Amount;

        }
        public double CalculateTotalCost()
        {
            double discount = CalculateDiscount();
            double gst = CalculateGST();
            return Amount - discount+gst;
        }
        
    }
}
