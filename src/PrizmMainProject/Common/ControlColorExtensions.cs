using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.XtraEditors;

namespace PrizmMain.Common
{
    static class ControlColorExtensions
    {
        private static Color requiredFieldColor = Color.LightYellow;
        private static Color defaultFieldColor = Color.White;

        private static void SwitchRequired(this TextEdit edit)
        {
            edit.BackColor = String.IsNullOrEmpty(edit.Text) ? requiredFieldColor : defaultFieldColor;
        }


        public static void SetRequiredCombo(this ComboBoxEdit cEdit)
        {
            cEdit.SelectedIndexChanged += new System.EventHandler(ControlColorExtensions.OnSelectedIndexChanged);
        }

        private static void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBoxEdit)
            {
                ((ComboBoxEdit)sender).SwitchRequired();
            }
        }

        public static void SetRequiredText(this TextEdit edit)
        {
            edit.TextChanged += new System.EventHandler(ControlColorExtensions.OnTextChanged);
        }

        private static void OnTextChanged(object sender, EventArgs e)
        {
            if (sender is TextEdit)
            {
                ((TextEdit)sender).SwitchRequired();
            }
        }
    }
}
