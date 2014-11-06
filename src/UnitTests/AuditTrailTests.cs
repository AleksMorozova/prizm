using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Domain.Entity.AuditTrail;
using NHibernate.Type;

namespace UnitTests
{
    [TestFixture]
    class AuditTrailTests
    {
        [Test]
        public void Insert()
        {
            IAuditable auditable = Mock.Of<IAuditable>(a => a.GetID() == Guid.NewGuid() && a.GetUser() == "TestUser");
            AuditInterceptor auditInterceptor = new AuditInterceptor();
            object id = 1;
            object [] state = {"state1", "state2"};
            string [] propertyNames = {"property1", "property2"};
            IType[] types =new IType [1] ;
            Assert.DoesNotThrow(() => auditInterceptor.OnSave(auditable, id, state, propertyNames,types));
        }
    }
}
