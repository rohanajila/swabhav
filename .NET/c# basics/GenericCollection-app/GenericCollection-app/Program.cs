using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection_app
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "rohan", 54.30, 5));
            PrintInfo(products);
            products.Add(new Product(2, "ashar", 84.50, 3));
            PrintInfo(products);
            //products.Add("abc");
            

            Console.Read();
        }
        public static void PrintInfo(List<Product> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                l[i].GetGrandTotal();
                Console.WriteLine("ID: " + l[i].Id);
                Console.WriteLine("Name: " + l[i].Name);
                Console.WriteLine("UnitPrice: " + l[i].UnitPrice);
                Console.WriteLine("Quantity: " + l[i].Quantity);
                Console.WriteLine("GrandTotal: " + l[i].GrandTotal);
            }
        }
    }
}
