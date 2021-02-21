using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_app.Model
{
    public class LineItem
    {
        private int _id;
        private int _quantity;
        private Product _product;
        public LineItem(int id,int quantity,Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }
        public double CalculateTotalCost()
        {
            return _quantity * _product.TotalCost;
        }
        public int Id{get=>_id; }
        public int Quantity{ get => _quantity; set => _quantity = value; }
        public Product Product{get=> _product; }
        public override string ToString()
        {
            return "\nLine item Id: " + Id + ", Products: " + Product + ", Quantity" + Quantity + ", Total Cost" + CalculateTotalCost();
        }
    }
}
