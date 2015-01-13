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
   public class PurchaseOrderObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NUMBER = "PURCHASE_ORDER";
      DateTime DATE = DateTime.Now;

      PurchaseOrder SetupMock()
      {
         Mock<PurchaseOrder> poMoq = new Mock<PurchaseOrder>();
         poMoq.SetupProperty(_ => _.Id, id);
         poMoq.SetupProperty(_ => _.Number, NUMBER);
         poMoq.SetupProperty(_ => _.Date, DATE);
         poMoq.SetupProperty(_ => _.IsActive, true);
         return poMoq.Object;
      }

      void AssertPurchaseOrder(PurchaseOrderObject obj)
      {
         Assert.AreEqual(id, obj.Id);
         Assert.AreEqual(NUMBER, obj.Number);
         Assert.AreEqual(DATE, obj.Date);
         Assert.IsTrue(obj.IsActive);
      }

      [Test]
      public void TestPurchaseOrderObjectCopyConstructor()
      {
         PurchaseOrderObject obj = new PurchaseOrderObject(SetupMock());

         AssertPurchaseOrder(obj);
      }

      [Test]
      public void TestPurchaseOrderObjectCasting()
      {
         PurchaseOrderObject obj = SetupMock();

         AssertPurchaseOrder(obj);
      }
   }
}
