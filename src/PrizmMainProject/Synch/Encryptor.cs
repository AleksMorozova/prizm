using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Prizm.Main.Synch
{
   public class Encryptor : IEncryptor
   {
      byte[] SALT = new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };
      enum Mode { Encrypt, Decrypt }

      public byte[] Encrypt(byte[] bytes, string key)
      {
         return Transform(bytes, key, Mode.Encrypt);
      }

      public byte[] Decrypt(byte[] bytes, string key)
      {
         return Transform(bytes, key, Mode.Decrypt);
      }

      byte[] Transform(byte[] bytes, string key, Mode mode)
      {
         byte[] result;

         using (Aes encryptor = Aes.Create())
         {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key, SALT);
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);

            using (MemoryStream ms = new MemoryStream())
            {
               ICryptoTransform transform = mode == Mode.Encrypt ? encryptor.CreateEncryptor() : encryptor.CreateDecryptor();
               using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
               {
                  cs.Write(bytes, 0, bytes.Length);
                  cs.Close();
               }
               result = ms.ToArray();
            }
         }

         return result;
      }
   }
}
