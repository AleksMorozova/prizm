using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch
{
   public interface IHasher
   {
      string GetHash(byte[] data);
   }
}
