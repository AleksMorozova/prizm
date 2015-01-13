using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class SizeTypeObjectTest
   {
      Guid id = Guid.NewGuid();
      const string TYPE = "TYPE";
      const int LENGTH = 10;
      const int DIAMETER = 20;
      const int THICKNESS = 15;

      PipeMillSizeType SetupMock()
      {
         Mock<PipeMillSizeType> moq = new Mock<PipeMillSizeType>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Type, TYPE);
         moq.SetupProperty(_ => _.Length, LENGTH);
         moq.SetupProperty(_ => _.Diameter, DIAMETER);
         moq.SetupProperty(_ => _.Thickness, THICKNESS);
         moq.SetupProperty(_ => _.IsActive, true);

         return moq.Object;
      }

      void AssertSizeType(SizeTypeObject st)
      {
         Assert.AreEqual(id, st.Id);
         Assert.IsTrue(st.IsActive);
         Assert.AreEqual(TYPE, st.Type);
         Assert.AreEqual(LENGTH, st.Length);
         Assert.AreEqual(DIAMETER, st.Diameter);
         Assert.AreEqual(THICKNESS, st.Thickness);
      }

      [Test]
      public void TestSizeTypeObjectCopyConstructor()
      {
         SizeTypeObject st = new SizeTypeObject(SetupMock());

         AssertSizeType(st);
      }

      [Test]
      public void TestSizeTypeObjectCasting()
      {
         SizeTypeObject st = SetupMock();

         AssertSizeType(st);
      }

   }
}
