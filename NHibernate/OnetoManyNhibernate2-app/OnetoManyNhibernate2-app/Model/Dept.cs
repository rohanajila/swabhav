using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNhibernate2_app.Model
{
    class Dept
    {
        public virtual int DeptId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
        public virtual IList<Emp> Employees { get; set; }

        public Dept()
        {
            Employees = new List<Emp>();
        }
    }
}
