using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_solution_app.Model
{
    class HoliRate:IFestivalRate
    {
        public double getRate()
        {
            return 5;
        }
    }
}
