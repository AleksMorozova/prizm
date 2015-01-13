using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class PipeObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NUMBER = "NUMBER";
      const int LENGTH = 20;
      PartConstructionStatus CONSTRUCTION_STATUS = PartConstructionStatus.Lowered;
      PartInspectionStatus INSPECTION_STATUS = PartInspectionStatus.Accepted;
      const string MILL = "MILL";
      const int DIAMETER = 14;
      const float WALL_THICKNESS = 15F;
      const float WEIGHT = 43F;
      DateTime PROD_DATE = DateTime.Now;
      PipeMillStatus STATUS = PipeMillStatus.Produced;

      Pipe SetupMock()
      {
         Mock<Pipe> moq = new Mock<Pipe>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.IsAvailableToJoint, true);
         moq.SetupProperty(_ => _.Number, NUMBER);
         moq.SetupProperty(_ => _.Length, LENGTH);
         moq.SetupProperty(_ => _.ConstructionStatus, CONSTRUCTION_STATUS);
         moq.SetupProperty(_ => _.InspectionStatus, INSPECTION_STATUS);
         moq.SetupProperty(_ => _.Mill, MILL);
         moq.SetupProperty(_ => _.Diameter, DIAMETER);
         moq.SetupProperty(_ => _.WallThickness, WALL_THICKNESS);
         moq.SetupProperty(_ => _.ProductionDate, PROD_DATE);
         moq.SetupProperty(_ => _.Status, STATUS);

         return moq.Object;
      }

      void AssertPipe(PipeObject pipe)
      {
         Assert.AreEqual(id, pipe.Id);
         Assert.IsTrue(pipe.IsActive);
         Assert.IsTrue(pipe.IsAvailableToJoint);
         Assert.AreEqual(NUMBER, pipe.Number);
         Assert.AreEqual(LENGTH, pipe.Length);
         Assert.AreEqual(CONSTRUCTION_STATUS, pipe.ConstructionStatus);
         Assert.AreEqual(INSPECTION_STATUS, pipe.InspectionStatus);
         Assert.AreEqual(MILL, pipe.Mill);
         Assert.AreEqual(DIAMETER, pipe.Diameter);
         Assert.AreEqual(WALL_THICKNESS, pipe.WallThickness);
         Assert.AreEqual(PROD_DATE, pipe.ProductionDate);
         Assert.AreEqual(STATUS, pipe.Status);
      }

      [Test]
      public void TestPipeObjectCopyConstructor()
      {
         PipeObject pipe = new PipeObject(SetupMock());

         AssertPipe(pipe);
      }

      [Test]
      public void TestPipeObjectCasting()
      {
         PipeObject pipe = SetupMock();

         AssertPipe(pipe);
      }
   }
}
