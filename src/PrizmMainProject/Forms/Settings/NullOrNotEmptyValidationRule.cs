using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings
{
    public class NullOrNotEmptyValidationRule : ValidationRule
    {
        public override bool Validate(System.Windows.Forms.Control control, object value)
        {
            var edit = (TextEdit)control;
            if(edit.Tag == null)
            {
                return true;
            }
            return !string.IsNullOrWhiteSpace((string)value);

        }
    }
}
