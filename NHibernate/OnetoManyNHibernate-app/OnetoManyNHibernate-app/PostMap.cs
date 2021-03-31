using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNHibernate_app.Model;

namespace OnetoManyNHibernate_app
{
    class PostMap:ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id); //#1

            Map(x => x.Title) //#2
                .Length(5000)
                .Not.Nullable();

            References(x => x.Category) //#3
                .Column("Category");
        }
    }
}
