using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework1_app.Model;

namespace EntityFramework1_app
{
    class SwabhavDbContext:DbContext
    {
        public DbSet<Dept> departments { get; set; }
        public DbSet<Emp> employees { get; set; }
        public SwabhavDbContext()
        {

        }
    }
}
