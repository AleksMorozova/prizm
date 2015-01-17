using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch
{
   public class Hasher : IHasher
   {
      public string GetHash(byte[] data)
      {
         string hash;
         using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
         {
            hash = HexStringFromBytes(sha1.ComputeHash(data));
         }
         return hash;
      }

      string HexStringFromBytes(byte[] bytes)
      {
         var sb = new StringBuilder();
         foreach (byte b in bytes)
         {
            var hex = b.ToString("x2");
            sb.Append(hex);
         }
         return sb.ToString();
      }
   }
}
