using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection_app
{
    class Product
    {
        private int id;
        private string name;
        private double unitPrice;
        private int quantity;
        private static double grandTotal = 0;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice= value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity= value; }
        }
        public double GrandTotal
        {
            get { return grandTotal; }
        }
        public Product(int id,string name,double unitPrice,int quantity)
        {
            this.id = id;
            this.name = name;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }
        public double GetGrandTotal()
        {
            grandTotal = unitPrice*quantity;
            return grandTotal;
        }
    }
}
