using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent;

        public abstract void Execute();

        public abstract bool CanExecute();

        public virtual bool Validate() { return true; }
    }
}
