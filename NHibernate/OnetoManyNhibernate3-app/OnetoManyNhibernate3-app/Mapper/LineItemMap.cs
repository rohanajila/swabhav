using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNhibernate3_app.Model;

namespace OnetoManyNhibernate3_app.Mapper
{
    class LineItemMap:ClassMap<LineItem>
    {
        public LineItemMap()
        {
            Id(x => x.Id);
            Map(x => x.Quantity);
            References(x => x.ProductType);

            References(x => x.Order)
                .Cascade.All();
            Table("`tbl_lineItem`");
        }
    }
}
