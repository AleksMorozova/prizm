using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Common
{
   public class PasswordEncryptor
   {
      static MD5 md5 = MD5.Create();

      public static string EncryptPassword(string text)
      {
         return CalculateMD5Hash(text);
      }

      private static string CalculateMD5Hash(string input)
      {
         byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
         byte[] hash = md5.ComputeHash(inputBytes);

         StringBuilder sb = new StringBuilder();
         for (int i = 0; i < hash.Length; i++)
         {
            sb.Append(hash[i].ToString("X2"));
         }
         return sb.ToString();
      }

   }


}
