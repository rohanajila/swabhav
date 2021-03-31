using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNhibernate2_app.Model
{
    class Emp
    {
        public virtual int EmpId { get; set; }
        public virtual string Name { get; set; }
        public virtual double Salary { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
