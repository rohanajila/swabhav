using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNhibernate2_app.Model;

namespace OnetoManyNhibernate2_app
{
    class DeptMap:ClassMap<Dept>
    {
        public DeptMap()
        {
            Id(x => x.DeptId);  //#1 

            Map(x => x.Name)  //#2
                .Length(50)
                .Not.Nullable();

            Map(x => x.Location)  //#3
              .Length(50)
              .Not.Nullable();

            HasMany(x => x.Employees) //#4
                .Inverse()
                .Cascade.All()
                .KeyColumn("Employees");
        }
    }
}
