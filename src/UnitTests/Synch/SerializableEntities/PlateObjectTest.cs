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
   public class PlateObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NUMBER = "NUMBER";
      const float THICKNESS = 0.2F;

      Plate SetupMock()
      {
         Mock<Plate> plate = new Mock<Plate>();
         plate.SetupProperty(_ => _.Id, id);
         plate.SetupProperty(_ => _.IsActive, true);
         plate.SetupProperty(_ => _.Number, NUMBER);
         plate.SetupProperty(_ => _.Thickness, THICKNESS);
         plate.SetupProperty(_ => _.Heat, new Heat());

         return plate.Object;
      }

      void AssertPlate(PlateObject plate)
      {
         Assert.AreEqual(id, plate.Id);
         Assert.IsTrue(plate.IsActive);
         Assert.AreEqual(NUMBER, plate.Number);
         Assert.AreEqual(THICKNESS, plate.Thickness);
      }

      [Test]
      public void TestPlateObjectCopyConstructor()
      {
         PlateObject plate = new PlateObject(SetupMock());

         AssertPlate(plate);
      }

      [Test]
      public void TestPlateObjectCopyCasting()
      {
         PlateObject plate = SetupMock();

         AssertPlate(plate);
      }

   }
}
