using Domain.Entity.Mill;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace Domain.DAL.Hibernate
{
   public class HibernateUtil
   {
      static ISessionFactory sessionFactory;

      public static void Initialize(string connectionString)
      {
         sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
            .Mappings(_ => _.FluentMappings.AddFromAssemblyOf<HibernateUtil>())
            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false,true) ) // populate db tables from maping
            .BuildSessionFactory();
      }

      public static ISession OpenSession()
      {
         return sessionFactory.OpenSession();
      }
   }
}
