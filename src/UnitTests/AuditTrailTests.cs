using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Domain.Entity;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Type;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate;
using System.Reflection;

namespace UnitTests
{
    public class InMemoryDatabaseTest : IDisposable
    {
        private static Configuration configuration;
        private static ISessionFactory SessionFactory;
        protected ISession session { get; set; }

        public InMemoryDatabaseTest(Assembly assemblyContainingMapping)
        {
            
            SessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.InMemory().ShowSql())
                .Mappings(m => m.FluentMappings
                               .AddFromAssemblyOf<Domain.Entity.AuditTrail.AuditableChemicalCompositionMap>()
                          )
                .ExposeConfiguration(x => configuration = x)
                .BuildSessionFactory();

            Domain.Entity.AuditTrail.AuditLogRepository repo = new Domain.Entity.AuditTrail.AuditLogRepository(SessionFactory);
            session = SessionFactory.OpenSession(new Domain.Entity.AuditTrail.AuditInterceptor(repo));

            NHibernate.Tool.hbm2ddl.SchemaExport export = new NHibernate.Tool.hbm2ddl.SchemaExport(configuration);
            export.Execute(true, true, false, session.Connection, null);
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }

    [TestFixture]
    class AuditTrailTests : InMemoryDatabaseTest
    {
        public AuditTrailTests()
            : base(typeof(Domain.Entity.AuditTrail.AuditableChemicalCompositionMap).Assembly)
	{
	}

        [Test]
        public void InMemoryTest() 
        {
      
            object id;
            using (var tx = session.BeginTransaction())
            {
                id = session.Save(new Domain.Entity.AuditTrail.AuditableChemicalComposition() { Id=1, Number="testNumber"});
                tx.Commit();
                IList<Domain.Entity.AuditTrail.AuditLog> logrecord = session.QueryOver<Domain.Entity.AuditTrail.AuditLog>().List<Domain.Entity.AuditTrail.AuditLog>();
                Assert.IsNotNull(logrecord);
               // Assert.AreEqual(1, logrecord.Count);
            }
            session.Clear();

            using (var tx = session.BeginTransaction())
            {
                var record = session.Get<Domain.Entity.AuditTrail.AuditableChemicalComposition>(1);
                Assert.AreEqual(1, record.Id);
                Assert.AreEqual("testNumber", record.Number);          
                tx.Commit();
            }
        }

    }
}
