using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Data.DAL;
using Data.DAL.Mill;
using Domain.Entity;
using Domain.Entity.Mill;

namespace UnitTests
{
    [TestFixture]
    public class AuditTrailTests
    {
        [Test]
        public void InterceptorTest() 
        {
            var auditRepo = new Mock<IAuditLogRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            Pipe testPipe = new Pipe();
            testPipe = new Pipe();
            pipeRepo.Setup(_ => _.Save(testPipe));
            auditRepo.Verify(_ => _.BeginTransaction(), Times.Once);
            auditRepo.Verify(_ => _.Save(It.IsAny<AuditLog>()), Times.Once);
            auditRepo.Verify(_ => _.Commit(), Times.Once());
            auditRepo.Verify(_ => _.Evict(It.IsAny<AuditLog>()), Times.Once());
            testPipe.Number = "test";
            pipeRepo.Setup(_ => _.SaveOrUpdate(testPipe));
            auditRepo.Verify(_ => _.BeginTransaction(), Times.Once);
            auditRepo.Verify(_ => _.Save(It.IsAny<AuditLog>()), Times.Once);
            auditRepo.Verify(_ => _.Commit(), Times.Once());
            auditRepo.Verify(_ => _.Evict(It.IsAny<AuditLog>()), Times.Once());
        }

    }
}
