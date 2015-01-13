using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class SpoolObjectTest
   {
      Guid id = Guid.NewGuid();
      const string PIPE_NUMBER = "PIPE_NUMBER";
      const string NUMBER = "NUMBER";
      const int LENGTH = 5;
      PartConstructionStatus CONSTRUCTION_STATUS = PartConstructionStatus.Lowered;
      PartInspectionStatus INSPECTION_STATUS = PartInspectionStatus.Accepted;

      Spool SetupMock()
      {
         Mock<Spool> moq = new Mock<Spool>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.PipeNumber, PIPE_NUMBER);
         moq.SetupProperty(_ => _.Number, NUMBER);
         moq.SetupProperty(_ => _.Length, LENGTH);
         moq.SetupProperty(_ => _.ConstructionStatus, CONSTRUCTION_STATUS);
         moq.SetupProperty(_ => _.InspectionStatus, INSPECTION_STATUS);
         moq.SetupProperty(_ => _.IsAvailableToJoint, true);
         moq.SetupProperty(_ => _.IsActive, true);
         return moq.Object;
      }

      void AssertSpool(SpoolObject spool)
      {
         Assert.AreEqual(id, spool.Id);
         Assert.IsTrue(spool.IsActive);
         Assert.IsTrue(spool.IsAvailableToJoint);
         Assert.AreEqual(PIPE_NUMBER, spool.PipeNumber);
         Assert.AreEqual(NUMBER, spool.Number);
         Assert.AreEqual(LENGTH, spool.Length);
         Assert.AreEqual(CONSTRUCTION_STATUS, spool.ConstructionStatus);
         Assert.AreEqual(INSPECTION_STATUS, spool.InspectionStatus);
      }

      [Test]
      public void TestSpoolObjectCopyConstructor()
      {
         SpoolObject spool = new SpoolObject(SetupMock());

         AssertSpool(spool);
      }

      [Test]
      public void TestSpoolObjectCasting()
      {
         SpoolObject spool = SetupMock();

         AssertSpool(spool);
      }
   }
}
