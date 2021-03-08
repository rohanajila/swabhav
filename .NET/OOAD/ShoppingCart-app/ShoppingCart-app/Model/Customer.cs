using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_app.Model
{
    class Customer
    {
        private int _id;
        private string _name;
        private string _address;
        private List<Order> _orders;

        public Customer(int id,string name,string address)
        {
            _id = id;
            _name = name;
            _address = address;
            _orders= new List<Order>();
        }
        
        public int Id{get=>_id; }

        public string Name{get=> _name; }

        public string Address{get=> _address; }

        public List<Order> Orders{get=> _orders; }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

    }
}
