using Prizm.Main.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace Prizm.Main.Common
{
    public static class AsyncHelper
    {
        private static IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();

        public static void InvokeIfRequired(Control control, Action method, bool wasStarted = false)
        {
            if (wasStarted && notify != null) { notify.HideProcessing(); }

            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate { method(); }));
            }
            else
            {
                method();
            }

            if (wasStarted && notify != null) { notify.ShowProcessing(); }
        }
    }
}
