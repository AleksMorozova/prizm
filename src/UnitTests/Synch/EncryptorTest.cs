using NUnit.Framework;
using Prizm.Main.Synch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch
{
   [TestFixture]
   public class EncryptorTest
   {
      [Test]
      public void TestEncryptAndThenDecrypt()
      {
         const string TEXT_TO_ENCRYPT = "TEXT_TO_ENCRYPT";
         const string KEY = "Secret";
         
         Encryptor encryptor = new Encryptor();
         byte[] encrypted = encryptor.Encrypt(Encoding.Unicode.GetBytes(TEXT_TO_ENCRYPT), KEY);

         byte[] decrypted = encryptor.Decrypt(encrypted, KEY);

         String decryptedString = Encoding.Unicode.GetString(decrypted);

         Assert.AreEqual(TEXT_TO_ENCRYPT, decryptedString);
      }

      [Test]
      [ExpectedException(typeof(CryptographicException))]
      public void TestDecryptWithWrongKey()
      {
         const string TEXT_TO_ENCRYPT = "TEXT_TO_ENCRYPT";
         const string KEY = "Secret";

         Encryptor encryptor = new Encryptor();
         byte[] encrypted = encryptor.Encrypt(Encoding.Unicode.GetBytes(TEXT_TO_ENCRYPT), KEY);

         byte[] decrypted = encryptor.Decrypt(encrypted, "WrongKey");
      }

   }
}
