using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace OnetoManyNhibernate2_app
{
    class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory(); return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()




         .Database(MsSqlConfiguration.MsSql2012.ConnectionString(
            @"server=.\SQLExpress; Database=Demo; User Id=sa; Password=root;").ShowSql())

         .Mappings(m => m.FluentMappings
         .AddFromAssemblyOf<Program>())
         .ExposeConfiguration(cfg => new SchemaExport(cfg)
         .Create(true, false))
         .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
