using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Commands
{
   public interface ICommandManager : IDisposable
   {
      CommandInfo this[string name] { get; }

      void RefreshVisualState();
   }
}
