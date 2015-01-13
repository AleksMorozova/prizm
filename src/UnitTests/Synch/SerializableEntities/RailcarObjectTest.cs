using Moq;
using NUnit.Framework;
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
   public class RailcarObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NUMBER = "NUMBER";
      const string CERTIFICATE = "CERTIFICATE";
      const string DESTINATION = "DESTINATION";

      Railcar SetupMock()
      {
         Mock<Railcar> moq = new Mock<Railcar>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Number, NUMBER);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.Certificate, CERTIFICATE);
         moq.SetupProperty(_ => _.Destination, DESTINATION);
         moq.SetupProperty(_ => _.IsShipped, true);

         return moq.Object;
      }

      void AssertRailcar(RailcarObject railcar)
      {
         Assert.AreEqual(id, railcar.Id);
         Assert.AreEqual(NUMBER, railcar.Number);
         Assert.AreEqual(CERTIFICATE, railcar.Certificate);
         Assert.AreEqual(DESTINATION, railcar.Destination);
         Assert.IsTrue(railcar.IsShipped);
         Assert.IsTrue(railcar.IsActive);
      }

      [Test]
      public void TestRailcarObjectCopyConstructor()
      {
         RailcarObject railcar = new RailcarObject(SetupMock());

         AssertRailcar(railcar);
      }

      [Test]
      public void TestRailcarObjectCasting()
      {
         RailcarObject railcar = SetupMock();

         AssertRailcar(railcar);
      }
   }
}
