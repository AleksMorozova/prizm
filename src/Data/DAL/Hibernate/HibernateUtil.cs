using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Exceptions;
using NHibernate.Tool.hbm2ddl;
using System.ComponentModel;
using Prizm.Domain.Entity;


namespace Prizm.Data.DAL.Hibernate
{
    public class HibernateUtil
    {
        private static ISessionFactory sessionFactory;
        private static bool isImport = false;
        public static bool Import { get { return isImport; } }
        public  static PersonName CurrentUser { get; set; }
        public static void Initialize(string connectionString, bool import)
        {
            isImport = import;
            try
            {
                sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
            .ShowSql())
            .Mappings(_ => _.FluentMappings.AddFromAssemblyOf<HibernateUtil>())
            .BuildSessionFactory();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Initialize", ex);
            }
        }

        public static ISession OpenSession(bool auditIsActive)
        {
            try
            {
                if (auditIsActive)
                    return sessionFactory.OpenSession(new AuditInterceptor(CurrentUser));
                return sessionFactory.OpenSession();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("OpenSession", ex);
            }
        }
    }
}