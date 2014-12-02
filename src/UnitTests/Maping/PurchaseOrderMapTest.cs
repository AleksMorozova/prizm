using NUnit.Framework;
using System;
using System.Configuration;
using FluentNHibernate.Testing;
using Domain.Entity.Mill;
using Data.DAL.Hibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace UnitTests.Maping
{
    [TestFixture]
    class PurchaseOrderMapTest
    {
        [Test]
        public void CanCorrectlyMapPurchaseOrder()
        {
            DateTime mydate = new DateTime(2008, 5, 1, 8, 30, 52);

            InMemorySessionFactoryProvider.Instance.Initialize();
            var session = InMemorySessionFactoryProvider.Instance.OpenSession();

            new PersistenceSpecification<PurchaseOrder>(session)
            .CheckProperty(p => p.Number, "number")
            .CheckProperty(p => p.Date, mydate)
            .VerifyTheMappings();

        }

    }
}
