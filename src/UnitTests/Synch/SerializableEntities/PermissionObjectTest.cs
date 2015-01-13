using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity.Security;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class PermissionObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NAME = "Read";
      const string TRANSLATE_NAME = "Read permission";

      Permission SetupMock()
      {
         Mock<Permission> moq = new Mock<Permission>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Name, NAME);
         moq.SetupProperty(_ => _.NameTranslation, TRANSLATE_NAME);

         return moq.Object;
      }

      void AssertPermission(PermissionObject perm)
      {
         Assert.AreEqual(id, perm.Id);
         Assert.AreEqual(NAME, perm.Name);
         Assert.AreEqual(TRANSLATE_NAME, perm.NameTranslation);
      }

      [Test]
      public void TestPermissionObjectCopyConstructor()
      {
         PermissionObject perm = new PermissionObject(SetupMock());

         AssertPermission(perm);
      }

      [Test]
      public void TestPermissionObjectCasting()
      {
         PermissionObject perm = SetupMock();

         AssertPermission(perm);
      }
   }
}
