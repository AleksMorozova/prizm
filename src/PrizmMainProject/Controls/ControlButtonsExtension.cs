using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Controls
{
    public static class ControlButtonsExtension
    {
        /// <summary>
        /// Add ellipsis Edit button to GridLookUpEdit
        /// </summary>
        /// <param name="gridLookUp"></param>
        public static void ButtonSetup(this GridLookUpEdit gridLookUp)
        {
            gridLookUp.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton("Edit", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis));
            gridLookUp.Properties.AutoComplete = false;
            gridLookUp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            gridLookUp.Properties.NullText = string.Empty;
        }
    }
}
