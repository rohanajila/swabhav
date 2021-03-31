using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework2_app.Model;

namespace EntityFramework2_app
{
    class SwabhavDbContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }

        public SwabhavDbContext()
        {
         
        }
    }
}
