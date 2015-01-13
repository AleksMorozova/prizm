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
   public class SeamTypeObjectTest
   {
      Guid id = Guid.NewGuid();
      Guid childId = Guid.NewGuid();
      const string NAME = "NAME";
      const string CHILD_NAME = "CHILD_NAME";

      SeamType SetupMock()
      {
         Mock<SeamType> childMoq = new Mock<SeamType>();
         childMoq.SetupProperty(_ => _.Id, childId);
         childMoq.SetupProperty(_ => _.IsActive, false);
         childMoq.SetupProperty(_ => _.Name, CHILD_NAME);

         List<SeamType> children = new List<SeamType>();
         
         Mock<SeamType> moq = new Mock<SeamType>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.Name, NAME);
         moq.SetupProperty(_ => _.SeamTypes, children);

         moq.Object.SeamTypes.Add(childMoq.Object);

         return moq.Object;
      }

      void AssertSeamType(SeamTypeObject st)
      {
         Assert.AreEqual(id, st.Id);
         Assert.AreEqual(NAME, st.Name);
         Assert.IsTrue(st.IsActive);
         Assert.AreEqual(1, st.SeamTypes.Count);
         AssertChildSeamType(st.SeamTypes[0]);
      }

      void AssertChildSeamType(SeamTypeObject st)
      {
         Assert.AreEqual(childId, st.Id);
         Assert.AreEqual(CHILD_NAME, st.Name);
         Assert.IsFalse(st.IsActive);
         Assert.IsNull(st.SeamTypes);
      }

      [Test]
      public void TestSeamTypeObjectCopyConstructor()
      {
         SeamTypeObject seamType = new SeamTypeObject(SetupMock());

         AssertSeamType(seamType);
      }

      [Test]
      public void TestSeamTypeObjectCasting()
      {
         SeamTypeObject seamType = SetupMock();

         AssertSeamType(seamType);
      }

   }
}
