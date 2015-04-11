using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Common
{
    public static class AsyncHelper
    {
        public static void InvokeIfRequired(Control control, Action method)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate { method(); }));
            }
            else
            {
                method();
            }
        }
    }
}
