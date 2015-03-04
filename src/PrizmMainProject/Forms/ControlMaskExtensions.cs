using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms
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

            textEdit.EditValueChanged += textEdit_EditValueChanged;
        }

        public static void SetAsJointElement(this TextEdit textEdit)
        {
            textEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }

        static void textEdit_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as TextEdit;
            if(edit.Text != null)
            {
                edit.Text = edit.Text.Trim();
                if(string.IsNullOrWhiteSpace(edit.Text))
                {
                    edit.Text = string.Empty;
                }
            }
        }
    }
}
