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
   public class PlateManufacturerObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NAME = "NAME";

      PlateManufacturer SetupMock()
      {
         Mock<PlateManufacturer> moq = new Mock<PlateManufacturer>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Name, NAME);
         moq.SetupProperty(_ => _.IsActive, true);

         return moq.Object;
      }

      void AssertPlateManufacturer(PlateManufacturerObject obj)
      {
         Assert.AreEqual(id, obj.Id);
         Assert.AreEqual(NAME, obj.Name);
         Assert.IsTrue(obj.IsActive);
      }

      [Test]
      public void TestPlateManufacturerCopyConstructor()
      {
         PlateManufacturerObject obj = new PlateManufacturerObject(SetupMock());

         AssertPlateManufacturer(obj);
      }

      [Test]
      public void TestPlateManufacturerCasting()
      {
         PlateManufacturerObject obj = SetupMock();

         AssertPlateManufacturer(obj);
      }
   }
}
