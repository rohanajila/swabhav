using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeAddressEF_app.Model;

namespace EmployeeAddressEF_app
{
    class SwabhavDbContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Address> addresses { get; set; }
        public SwabhavDbContext()
        {

        }
    }
}
