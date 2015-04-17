using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Commands
{
   public class CommandManager : ICommandManager
   {
      Dictionary<string, CommandInfo> commands = new Dictionary<string, CommandInfo>();

      public CommandInfo this[string name]
      {
         get 
         { 
            if (!commands.ContainsKey(name))
            {
                commands.Add(name, new CommandInfo(RefreshVisualState));
            }
            return commands[name];
         }
      }

      public void RefreshVisualState()
      {
         foreach (var info in commands.Values)
         {
            info.RefreshState();
         }
      }

      public void Dispose()
      {
         foreach (var info in commands.Values)
         {
            info.Dispose();
         }
      }
   }
}
