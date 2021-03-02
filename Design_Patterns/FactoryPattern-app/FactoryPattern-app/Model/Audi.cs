using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_app.Model
{
    class Audi:IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Audi Starts....");
        }
        public void stop()
        {
            Console.WriteLine("Audi Stops....");
        }
    }
}
