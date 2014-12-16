using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Commands
{
   public interface IAttacher : IDisposable
   {
      void Attach();
      void Detach();
      void RefreshState();
   }
}
