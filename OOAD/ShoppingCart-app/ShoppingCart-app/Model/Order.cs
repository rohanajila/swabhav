using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_app.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();
        public Order(int id,DateTime date)
        {
            _id = id;
            _date = date;            
        }
        public int Id{get=>_id; }
        public DateTime Date{get=> _date; }
        public List<LineItem> Items{get=> _items; }
        public void AddItem(LineItem item)
        {
            bool isAdded = false;
            if (!_items.Equals(null))
            {
                foreach (LineItem i in _items)
                {
                    if (i.Product.Equals(item.Product))
                    {
                        i.Quantity += item.Quantity;
                        isAdded = true;
                    }
                }
                if (!isAdded)
                    _items.Add(item);
            }
            else
                _items.Add(item);
        }
        public double CheckoutCost()
        {
            double checkoutCost = 0;
            foreach(LineItem item in _items)
            {
                checkoutCost += item.CalculateTotalCost();
            }
            return checkoutCost;
        }
        public override string ToString()
        {
            return "\nOrder Id: " + Id + ", Date: " + Date + ",\nOrder List: \n"+ string.Join(",",_items);
        }


    }
}
