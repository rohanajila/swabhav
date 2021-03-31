using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OnetoManyNhibernate2_app.Model;

namespace OnetoManyNhibernate2_app
{
    class EmpMap:ClassMap<Emp>
    {
        public EmpMap()
        {
            Id(x => x.EmpId); //#1

            Map(x => x.Salary) //#2
                .Not.Nullable();

            Map(x => x.Name) //#3
                .Length(5000)
                .Not.Nullable();

            References(x => x.Dept) //#3
                .Column("Dept");
        }
    }
}
