using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Exceptions;
using NHibernate.Tool.hbm2ddl;
using System.ComponentModel;


namespace Data.DAL.Hibernate
{
    public class HibernateUtil
    {
        private static ISessionFactory sessionFactory;
        public static ISession session { get; private set; }
        public static void Initialize(string connectionString)
        {
            try
            {
                sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
            .ShowSql())
            .Mappings(_ => _.FluentMappings.AddFromAssemblyOf<HibernateUtil>())
            .BuildSessionFactory();
                session = sessionFactory.OpenSession();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Initialize", ex);
            }
        }

        public static ISession OpenSession()
        {
            try
            {
                return sessionFactory.OpenSession(new AuditInterceptor());
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("OpenSession", ex);
            }
        }
    }
}