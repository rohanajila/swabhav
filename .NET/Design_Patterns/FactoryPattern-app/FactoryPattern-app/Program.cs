using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern_app.Model;

namespace FactoryPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomobileFactory factory = new AutomobileFactory();
            try
            {
                IAutomobile bmw = factory.make(AutoType.BMW);
                bmw.start();
                bmw.stop();
                IAutomobile audi = factory.make(AutoType.AUDI);
                audi.start();
                audi.stop();
                IAutomobile hyundai = factory.make(AutoType.UNSPECIFIED);
            }
            catch(UnspecifiedVehicleException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.Read();
            
        }
       
    }
    public enum AutoType
    {
        AUDI, BMW, TESLA, UNSPECIFIED
    }
}
