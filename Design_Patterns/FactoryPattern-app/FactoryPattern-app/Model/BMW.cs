using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_app.Model
{
    class BMW:IAutomobile
    {
        public void start()
        {
            Console.WriteLine("BMW Starts....");
        }
        public void stop()
        {
            Console.WriteLine("BMW Stops....");
        }
    }
}
