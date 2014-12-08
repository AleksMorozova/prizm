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
        /// <summary>
        /// This method set all characters TextEdit.Text property to Upper register
        /// </summary>
        /// <param name="textEdit"> the concrete TextEdit control </param>
        public static void SetAsIdentifier(this TextEdit textEdit)
        {
            textEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }
    }
}
