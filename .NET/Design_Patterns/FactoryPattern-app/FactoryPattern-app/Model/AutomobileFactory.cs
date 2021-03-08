using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_app.Model
{
    class AutomobileFactory
    {
        public IAutomobile make(AutoType type)
        {
            if (type == AutoType.AUDI)
                return new Audi();
            else if (type == AutoType.BMW)
                return new BMW();
            else if (type == AutoType.TESLA)
                return new Tesla();
            else
                throw new UnspecifiedVehicleException();
        }
       
    }
}
