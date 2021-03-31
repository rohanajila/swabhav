using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNhibernate3_app.Model;

namespace OnetoManyNhibernate3_app.Mapper
{
    class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            HasMany(x => x.Orders)
                .Inverse()
                .Cascade.All();
            Table("`tbl_customer`");
        }
    }
}
