using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity;
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
   public class UserObjectTest
   {
      Guid id = Guid.NewGuid();
      const string LOGIN = "LOGIN";
      const string PASS_HASH = "PASS_HASH";
      DateTime PASS_EXP = DateTime.Now;
      const string FIRST_NAME = "FIRST_NAME";
      const string LAST_NAME = "LAST_NAME";
      const string MIDDLE_NAME = "MIDDLE_NAME";

      User SetupMock()
      {
         Mock<User> moq = new Mock<User>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.Login, LOGIN);
         moq.SetupProperty(_ => _.PasswordHash, PASS_HASH);
         moq.SetupProperty(_ => _.Undeletable, true);
         moq.SetupProperty(_ => _.PasswordExpires, PASS_EXP);
         moq.SetupProperty(_ => _.Name, new PersonName());

         moq.Object.Name.FirstName = FIRST_NAME;
         moq.Object.Name.LastName = LAST_NAME;
         moq.Object.Name.MiddleName = MIDDLE_NAME;

         return moq.Object;
      }

      void AssertUser(UserObject user)
      {
         Assert.AreEqual(id, user.Id);
         Assert.IsTrue(user.IsActive);
         Assert.AreEqual(LOGIN, user.Login);
         Assert.AreEqual(PASS_HASH, user.PasswordHash);
         Assert.AreEqual(PASS_EXP, user.PasswordExpires);
         Assert.AreEqual(FIRST_NAME, user.FirstName);
         Assert.AreEqual(LAST_NAME, user.LastName);
         Assert.AreEqual(MIDDLE_NAME, user.MiddleName);
         Assert.IsTrue(user.Undeletable);
      }

      [Test]
      public void TestUserObjectCopyConstructor()
      {
         UserObject user = new UserObject(SetupMock());

         AssertUser(user);
      }

      [Test]
      public void TestUserObjectCasting()
      {
         UserObject user = SetupMock();

         AssertUser(user);
      }

   }
}
