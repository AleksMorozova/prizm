using Prizm.Main.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Commands
{
   public interface IAttacher : IDisposable
   {
      void Attach();
      void AttachModifier(IModifiable form);
      void Detach();
      void RefreshState();

   }
}
