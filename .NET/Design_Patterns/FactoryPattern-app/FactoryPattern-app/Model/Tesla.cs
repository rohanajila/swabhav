using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_app.Model
{
    class Tesla:IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Tesla Starts....");
        }
        public void stop()
        {
            Console.WriteLine("Tesla Stops....");
        }
    }
}
