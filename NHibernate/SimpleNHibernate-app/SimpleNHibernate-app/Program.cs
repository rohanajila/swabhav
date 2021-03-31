using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleNHibernate_app.Model;


namespace SimpleNHibernate_app
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // AddData();
            //DisplayData();
            //UpdateData();
            DeleteData();
            DisplayData();
            Console.ReadKey();
            
        }
        private static void CreateTable()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var customer = new Customer
                    {
                        FirstName = "Rohan",
                        LastName = "Ajila"
                    };
                    var customer1 = new Customer
                    {
                        FirstName = "Saurabh",
                        LastName = "Dutta"
                    };
                    var customer2 = new Customer
                    {
                        FirstName = "Ashar",
                        LastName = "Deshmukh"
                    };
                    session.Save(customer);
                    session.Save(customer1);
                    session.Save(customer2);
                    transaction.Commit();
                    Console.WriteLine("Customer Created: " + customer.FirstName + "\t" +
                       customer.LastName);
                }

                Console.ReadKey();
            }
        }
        private static void DisplayData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var tx = session.BeginTransaction())
                {
                    var customers = session.CreateCriteria<Customer>().List<Customer>();

                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}",
                           customer.Id, customer.FirstName, customer.LastName);
                    }

                    tx.Commit();
                }

                Console.ReadLine();
            }
        }
        private static void AddData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var customer = new Customer
                    {
                        FirstName = "Arshdeep",
                        LastName = "Singh"
                    };
                    
                    session.Save(customer);
                    
                    transaction.Commit();
                    Console.WriteLine("Customer Created: " + customer.FirstName + "\t" +
                       customer.LastName);
                }

                Console.ReadKey();
            }
        }
        private static void UpdateData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var tx = session.BeginTransaction())
                {
                    var customers = session.CreateCriteria<Customer>().List<Customer>();

                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}", customer.Id,
                           customer.FirstName,customer.LastName);
                    }

                    var cust = session.Get<Customer>(1);
                    Console.WriteLine("Retrieved by ID");
                    Console.WriteLine("{0} \t{1} \t{2}", cust.Id, cust.FirstName,cust.LastName);

                    Console.WriteLine("Update the last name of ID = {0}", cust.Id);
                    cust.LastName = "chaudhary";
                    session.Update(cust);
                    Console.WriteLine("\nFetch the complete list again\n");

                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}", customer.Id,
                           customer.FirstName,customer.LastName);
                    }

                    tx.Commit();
                }

                Console.ReadLine();
            }
        }
        private static void DeleteData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var tx = session.BeginTransaction())
                {
                    var customers = session.CreateCriteria<Customer>().List<Customer>();

                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}", customer.Id,
                           customer.FirstName, customer.LastName);
                    }

                    var cust = session.Get<Customer>(2);
                    Console.WriteLine("Retrieved by ID");
                    Console.WriteLine("{0} \t{1} \t{2}", cust.Id, cust.FirstName, cust.LastName);

                    Console.WriteLine("Delete the record which has ID = {0}", cust.Id);
                    session.Delete(cust);
                    Console.WriteLine("\nFetch the complete list again\n");

                    

                    tx.Commit();
                }

                Console.ReadLine();
            }
        }
    }
    
}
