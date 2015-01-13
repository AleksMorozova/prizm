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
   public class RoleObjectTest
   {
      Guid id = Guid.NewGuid();
      const string NAME = "NAME";
      const string DESCRIPTION = "DESCRIPTION";

      Role SetupMock()
      {
         Mock<Role> moq = new Mock<Role>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Name, NAME);
         moq.SetupProperty(_ => _.Description, DESCRIPTION);
         return moq.Object;
      }

      void AssertRole(RoleObject role)
      {
         Assert.AreEqual(id, role.Id);
         Assert.AreEqual(NAME, role.Name);
         Assert.AreEqual(DESCRIPTION, role.Description);
      }

      [Test]
      public void TestRoleObjectCopyConstructor()
      {
         RoleObject role = new RoleObject(SetupMock());

         AssertRole(role);
      }

      [Test]
      public void TestRoleObjectCasting()
      {
         RoleObject role = SetupMock();

         AssertRole(role);
      }

   }
}
