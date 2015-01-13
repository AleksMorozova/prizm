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
   public class HeatObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NUMBER = "NUMBER";
      const string STEEL_GRADE = "STEEL_GRADE";
      
      Heat SetupMock()
      {
         Mock<Heat> moq = new Mock<Heat>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.Number, NUMBER);
         moq.SetupProperty(_ => _.SteelGrade, STEEL_GRADE);

         return moq.Object;
      }

      void AssertHeat(HeatObject obj)
      {
         Assert.AreEqual(id, obj.Id);
         Assert.AreEqual(NUMBER, obj.Number);
         Assert.AreEqual(STEEL_GRADE, obj.SteelGrade);
         Assert.IsTrue(obj.IsActive);
      }

      [Test]
      public void TestHeatObjectCopyConstructur()
      {
         HeatObject heat = new HeatObject(SetupMock());

         AssertHeat(heat);
      }

      [Test]
      public void TestHeatObjectCasting()
      {
         HeatObject heat = SetupMock();

         AssertHeat(heat);
      }
   }
}
