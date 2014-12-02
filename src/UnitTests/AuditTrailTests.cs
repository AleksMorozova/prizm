using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Data.DAL.Hibernate;
using Data.DAL;
using Domain.Entity;

namespace UnitTests
{
    [TestFixture]
    public class AuditTrailTests
    {
        [Test]
        public void InterceptorOnSaveTest() 
        {
            var auditRepo = new Mock<IAuditLogRepository>();
            PersonName editingPerson = new PersonName { LastName = "LN", FirstName = "FN", MiddleName = "MN" };
            AuditInterceptor interceptor = new AuditInterceptor(editingPerson);
            interceptor.LogRepo = auditRepo.Object;
            object [] state = new object [1] {1};
            string [] propertyNames = new string [1] {"testProperty"};
            var iType = new Mock<NHibernate.Type.IType>();
            NHibernate.Type.IType [] types =  new  NHibernate.Type.IType [1] {iType.Object};    
            PipelinePiece p =  new PipelinePiece();
            interceptor.OnSave (p, 1, state, propertyNames, types);
            auditRepo.Verify(_ => _.Save(It.IsAny<AuditLog>()), Times.Once());
        }

        [Test]
        public void InterceptorOnFlushDirtyTest()
        {
            var auditRepo = new Mock<IAuditLogRepository>();
            PersonName editingPerson = new PersonName { LastName = "LN", FirstName = "FN", MiddleName = "MN" };
            AuditInterceptor interceptor = new AuditInterceptor(editingPerson);
            interceptor.LogRepo = auditRepo.Object;
            object[] currentState = new object[1] { 1 };
            object[] previousState = new object[1] { 0 };
            string[] propertyNames = new string[1] { "testProperty" };
            var iType = new Mock<NHibernate.Type.IType>();
            NHibernate.Type.IType[] types = new NHibernate.Type.IType[1] { iType.Object };
            PipelinePiece p = new PipelinePiece();
            interceptor.OnFlushDirty(p, 1, currentState, previousState, propertyNames, types);
            auditRepo.Verify(_ => _.Save(It.IsAny<AuditLog>()), Times.Once());

        }


    }
}
