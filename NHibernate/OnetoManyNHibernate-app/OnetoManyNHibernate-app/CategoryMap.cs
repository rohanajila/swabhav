using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNHibernate_app.Model;

namespace OnetoManyNHibernate_app
{
    class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);  //#1 

            Map(x => x.Name)  //#2
                .Length(50) 
                .Not.Nullable(); 

            HasMany(x => x.Post) //#3 
                .Inverse() 
                .Cascade.All()
                .KeyColumn("Category"); 
        }
    }
}
