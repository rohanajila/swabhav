using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SimpleNHibernate_app.Model;

namespace SimpleNHibernate_app
{
    class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Table("Customer");
        }
    }
}
