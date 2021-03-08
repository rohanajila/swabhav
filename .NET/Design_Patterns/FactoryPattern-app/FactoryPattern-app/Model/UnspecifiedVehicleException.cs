using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_app.Model
{
    class UnspecifiedVehicleException:Exception
    {
        public UnspecifiedVehicleException(): base("vehicle does not exist") { }
    }
}
