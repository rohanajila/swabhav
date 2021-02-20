using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_app.Model
{
    class Customer
    {
        private Guid id;
        private string name;
        private string address;
        private List<Order> orders;
        public Customer(Guid id,string name,string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public Guid Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
        }
        public List<Order> Orders
        {
            get { return orders; }
        }
    }
}
