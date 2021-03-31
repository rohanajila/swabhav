using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contact_app.Model;

namespace Contact_app.DbContext
{
    class SwabhavDbContext:System.Data.Entity.DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Address { get; set; }
        public SwabhavDbContext()
        {
            
        }
    }
}
