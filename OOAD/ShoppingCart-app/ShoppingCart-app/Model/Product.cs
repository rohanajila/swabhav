using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_app.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountPercentage;
        public int Id{ get => _id; }
        public string Name{get => _name; }
        public double Price{get =>_price; }
        
        public float DiscountPercentage{ get => _discountPercentage; }
        public Product(int id,string name,double price,float discountPercentage)
        {
            _id = id; ;
            _name = name;
            _price = price;
            _discountPercentage = discountPercentage;
        }
        public double TotalCost { get => Price - (Price * DiscountPercentage / 100); }
        public override string ToString()
        {
            return "\n\t\t\tProduct Id: " + Id + ", Name: " + Name + ", Unit Price: " + Price + ", Discount%" + DiscountPercentage + ", Cost after discount: " + TotalCost;
        }

    }
}
