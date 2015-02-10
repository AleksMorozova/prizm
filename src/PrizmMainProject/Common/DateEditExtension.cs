using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class DateEditExtension
    {
        public static void SetLimits(this DevExpress.XtraEditors.DateEdit edit)
        {
            edit.Properties.MinValue = new DateTime(1950, 1, 1);
            edit.Properties.MaxValue = new DateTime(2150, 1, 1);
        }
    }
}
