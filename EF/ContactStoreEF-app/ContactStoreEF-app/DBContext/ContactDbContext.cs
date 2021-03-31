using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ContactStoreEF_app.Model;

namespace ContactStoreEF_app.DBContext
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts{get;set;}

        public ContactDbContext()
        {

        }

    }
}
