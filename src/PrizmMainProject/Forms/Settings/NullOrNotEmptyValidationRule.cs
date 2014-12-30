using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings
{
    public class ProjectTitleEditIfLoadValidationRule : ValidationRule
    {
        /// <summary>
        /// Validate TextEdit control. Return true if control has text or been visible
        /// </summary>
        /// <param name="control">TextEdit</param>
        /// <param name="value">text value</param>
        /// <returns></returns>
        public override bool Validate(System.Windows.Forms.Control control, object value)
        {
            var edit = (TextEdit)control;
            bool ret = false;

            if(edit.Tag == null)
            {
                ret = true;
            }
            else
            {
                ret = !string.IsNullOrWhiteSpace((string)value);
            }

            return ret;

        }
    }
}
