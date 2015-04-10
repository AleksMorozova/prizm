using Prizm.Main.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Commands
{
   public abstract class Attacher<T> : IAttacher where T: class
   {
      protected ICommand command;
      protected T component;
      protected IModifiable modifier;

      protected Attacher(ICommand command, T component)
      {
         this.command = command;
         this.component = component;
      }

      public abstract void Attach();
      
       public void AttachModifier(IModifiable modifiebleForm)
      {
          modifier = modifiebleForm;
      }

      public abstract void Detach();
      public abstract void RefreshState();

      public virtual void Dispose()
      {
         Detach();
         command = null;
         component = null;
      }
   }
}
