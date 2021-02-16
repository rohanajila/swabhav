using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_app.Model
{
    class Programmer:Employee
    {
        public override float ComputeTotalSalary()
        {
            return salary;
        }
    }
}
