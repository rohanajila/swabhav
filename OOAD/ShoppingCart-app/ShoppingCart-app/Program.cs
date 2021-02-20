using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart_app.Model;

namespace ShoppingCart_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1001, "rohan", "navi mumbai");

            Product apple = new Product(1, "Apple", 20, 5);
            Product mango = new Product(2, "Mango", 50, 5);
            Product orange = new Product(3, "Orange", 15, 10);

            Order o1 = new Order(101, new DateTime(2021, 02, 19));
            o1.AddItem(new LineItem(201, 14, apple));
            o1.AddItem(new LineItem(202, 8, mango));
            o1.AddItem(new LineItem(203, 5, mango));

            Order o2 = new Order(201, new DateTime(2021, 02, 20));
            o1.AddItem(new LineItem(204, 2, apple));
            o1.AddItem(new LineItem(203, 5, mango));

            c1.AddOrder(o1);
            c1.AddOrder(o2);
            printInfo(c1);
            Console.Read();

        }
        public static void printInfo(Customer obj)
        {
            Console.WriteLine("Customer Details: " + obj.Id + ", " + obj.Name + ", " + obj.Address);
            obj.Orders.ForEach(Console.WriteLine);

        }
    }
}
