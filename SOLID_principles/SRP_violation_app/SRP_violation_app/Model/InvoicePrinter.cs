using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_violation_app.Model
{
    class InvoicePrinter
    {
        private Invoice _invoice;
        public InvoicePrinter(Invoice invoice)
        {
            _invoice = invoice;
        }
        public void PrintToConsole()
        {
            Console.WriteLine("Invoive no.: " + _invoice.No);
            Console.WriteLine("Name: " + _invoice.Name);
            Console.WriteLine("Discount Percentage: " + _invoice.DiscountPercentage);
            Console.WriteLine(" Total Amount.: " + _invoice.CalculateTotalCost());
        }
    }
}
