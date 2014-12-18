using NUnit.Framework;
using Prizm.Main.Forms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Forms.Common
{
   [TestFixture]
   public class PasswordEncryptorTest
   {
      [Test]
      public void TestEncryptPasswordReturnsCorrectHash()
      {
         string password = "admin";
         string hash = PasswordEncryptor.EncryptPassword(password);

         Assert.AreEqual("21232F297A57A5A743894A0E4A801FC3", hash);
      }
   }
}
