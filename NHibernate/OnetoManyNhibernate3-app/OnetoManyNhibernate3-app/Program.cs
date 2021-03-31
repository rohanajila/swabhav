using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetoManyNhibernate3_app.Model;

namespace OnetoManyNhibernate3_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateTable();
           PrintCustomerData();
           ShowOrderByCustomerId();
            Console.ReadKey();
        }
        public static void CreateTable()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Product oreo = new Product { Name = "Oreo", Price = 10 };
                    Product darkFantasy= new Product { Name = "Dark Fantasy", Price = 20 };
                    Product rice = new Product { Name = "rice", Price = 150 };
                    Product deo = new Product { Name = "Deo", Price = 15 };
                    Product bread = new Product { Name = "Bread", Price = 50 };
                    Product mango = new Product { Name = "Mango", Price = 100 };
                    Product litchi = new Product { Name = "Litchi", Price = 70 };                  

                    LineItem item1 = new LineItem { Quantity = 5 };
                    LineItem item2 = new LineItem { Quantity = 10 };
                    LineItem item3 = new LineItem { Quantity = 25 };
                    LineItem item4 = new LineItem { Quantity = 7 };
                    LineItem item5 = new LineItem { Quantity = 15 };
                    LineItem item6 = new LineItem { Quantity = 17 };
                    LineItem item7 = new LineItem { Quantity = 33 };                 
                    LineItem item8 = new LineItem { Quantity = 15 };
                    LineItem item9 = new LineItem { Quantity = 30 };


                    item1.CreateLineItem(oreo);
                    item2.CreateLineItem(bread);
                    item3.CreateLineItem(rice);
                    item4.CreateLineItem(bread);
                    item5.CreateLineItem(deo);                  
                    item7.CreateLineItem(mango);                  
                    item8.CreateLineItem(litchi);
                    item9.CreateLineItem(oreo);

                    Customer customer1 = new Customer { FirstName = "rohan", LastName = "ajila", Address = "mumbai" };
                    Customer customer2 = new Customer { FirstName = "ashar", LastName = "deshmukh", Address = "nashik" };
                    Customer customer3 = new Customer { FirstName = "saurabh", LastName = "dutta", Address = "pune" };

                    Order order1 = new Order { };
                    Order order2 = new Order { };
                    Order order3 = new Order { };

                    order1.AddLineItem(item1);
                    order1.AddLineItem(item2);
                    order1.AddLineItem(item3);
                    order2.AddLineItem(item4);
                    order2.AddLineItem(item5);
                    order2.AddLineItem(item6);
                    order3.AddLineItem(item7);               
                    order3.AddLineItem(item8);
                    order3.AddLineItem(item9);

                    customer1.AddOrder(order1);
                    customer2.AddOrder(order2);
                    customer3.AddOrder(order3);

                    session.Save(oreo);
                    session.Save(bread);
                    session.Save(rice);
                    session.Save(deo);                  
                    session.Save(litchi);
                    session.Save(darkFantasy);
                    session.Save(mango);

                    session.Save(customer1);
                    session.Save(customer2);
                    session.Save(customer3);

                    session.Save(order1);
                    session.Save(order2);
                    session.Save(order3);

                    transaction.Commit();
                    Console.WriteLine("Tables Created");
                }
            }


        }
        public static void PrintCustomerData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Console.WriteLine("\n\nShowing all customer data");
                    var customers = session.CreateCriteria<Customer>().List<Customer>();
                    Console.WriteLine($"ID   |   FirstName   | LastName   | Address");
                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{customer.Id} | {customer.FirstName} | {customer.LastName} | {customer.Address}");
                    }
                }
                Console.ReadKey();
            }

        }
        public static void ShowOrderByCustomerId()
        {
            
            Console.Write("\nSelect a customer Id : ");
            int id = int.Parse(Console.ReadLine());
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var customerOrderData = session.Query<Order>()
                        .Join(session.Query<LineItem>(), order => order.Id, lineitem => lineitem.Order.Id, (order, lineItem) => new
                        {
                            customerId = order.Customer.Id,
                            productName = lineItem.ProductType.Name,
                            productPrice = lineItem.ProductType.Price,
                            productQuantity = lineItem.Quantity
                        })
                        .Where(x => x.customerId == id);

                    Console.WriteLine("Showing order for customer with Id : "+id);
                    foreach (var customerOrder in customerOrderData)
                    {
                        Console.WriteLine($"Product Name : {customerOrder.productName} " +
                            $"| Quantity : {customerOrder.productQuantity} " +
                            $"| Price : {customerOrder.productPrice}" +
                            $" |Total Price Rs.{customerOrder.productPrice * customerOrder.productQuantity}");
                    }
                }
            }
        }

    }
}
