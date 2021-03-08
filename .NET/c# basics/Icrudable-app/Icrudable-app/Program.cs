using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icrudable_app
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDb obj = new AddressDb();
            CustomerDb obj1 = new CustomerDb();
            InvoiceDb obj2 = new InvoiceDb();

            PrintInfo(obj);
            PrintInfo(obj1);
            PrintInfo(obj2);

            Console.ReadKey();
        }
        public static void PrintInfo(Icrudable d)
        {
            d.create();
            d.read();
            d.update();
            d.delete();
        }
    }
}
