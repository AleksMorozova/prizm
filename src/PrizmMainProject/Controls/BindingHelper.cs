using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Controls
{
    class BindingHelper
    {
        public static Binding CreateCheckEditInverseBinding(string propertyName, object dataSource, string dataMember)
        {
            Binding bind = new Binding(propertyName, dataSource, dataMember);
            bind.FormattingEnabled = true;
            bind.Format += (sender, e) => { e.Value = !((bool)e.Value); };
            bind.Parse += (sender, e) => { e.Value = !((bool)e.Value); };
            return bind;
        }
    }
}
