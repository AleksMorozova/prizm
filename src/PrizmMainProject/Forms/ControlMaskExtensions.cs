using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms
{
    public static class ControlMaskExtensions
    {
        public static void SetAsIdentifier(this TextEdit textEdit)
        {
            textEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }
    }
}
