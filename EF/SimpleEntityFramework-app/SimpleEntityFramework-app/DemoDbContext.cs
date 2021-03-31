using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SimpleEntityFramework_app.Model;

namespace SimpleEntityFramework_app
{
    class DemoDbContext:DbContext
    {
        public DemoDbContext()
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
