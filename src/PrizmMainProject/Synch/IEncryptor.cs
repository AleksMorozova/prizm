using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch
{
   public interface IEncryptor
   {
      byte[] Encrypt(byte[] bytes, string key);
      byte[] Decrypt(byte[] bytes, string key);
   }
}
