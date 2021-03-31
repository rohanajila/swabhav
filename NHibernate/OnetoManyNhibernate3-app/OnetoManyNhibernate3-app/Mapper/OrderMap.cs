using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNhibernate3_app.Model;

namespace OnetoManyNhibernate3_app.Mapper
{
    class OrderMap:ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Id);
            References(x => x.Customer);
            HasMany(x => x.LineItems)
                .Inverse()
                .Cascade.All();
            Table("`tbl_order`");
        }
    }
}
