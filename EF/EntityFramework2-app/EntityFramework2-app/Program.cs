using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework2_app.Model;

namespace EntityFramework2_app
{
    class Program
    {
        public static SwabhavDbContext db = new SwabhavDbContext();
        static void Main(string[] args)
        {
            //CreateTable();
            Query1();
           // Query2();
            Console.ReadKey();
        }
        private static void CreateTable()
        {
            var c1 = new Customer { CustNo = 101, CustName = "Rohan", CustAddress = "Mumbai" };
            var c2= new Customer { CustNo = 102, CustName = "Ashar", CustAddress = "Nashik" };

            var o1 = new Order { OrderId = 1, OrderDate = new DateTime(2020, 10, 25) };
            var o2 = new Order { OrderId = 2, OrderDate = new DateTime(2020,11, 12) };
            var o3 = new Order { OrderId = 3, OrderDate = new DateTime(2020, 12, 17) };

            o1.CustNo = c1;
            o2.CustNo = c1;
            o3.CustNo = c2;

            c1.CustOrders.Add(o1);
            c1.CustOrders.Add(o2);
            c2.CustOrders.Add(o3);

            db.customers.Add(c1);
            db.customers.Add(c2);

            db.SaveChanges();
            Console.WriteLine("Table created Succesfully");
        }
        private static void Query1()
        {
            var order = db.orders.
                Where(o => o.CustNo.CustName.Equals("rohan")).
                Select(o => new { o.OrderId, o.OrderDate }).ToList();
            foreach(var o in order)
            {
                Console.WriteLine("Order ID: "+o.OrderId + " Order Date: " + o.OrderDate);
            }         
        }
        private static void Query2()
        {
            var orderSummary = db.customers.Join(db.orders, customer => customer.CustNo, order => order.OrderId, (customer, order) => new
            {
                customer.CustName,
                customer.CustAddress,
                order.OrderId,
                order.OrderDate
            });
            foreach(var c in orderSummary)
            {
                Console.WriteLine("Customer Name: {0}, Customer Address: {1}, Order Id: {2}, Order Date: {3} ", c.CustName, c.CustAddress, c.OrderId, c.OrderDate);
            }
        }
        private static void Query3()
        {

        }
    }
}
