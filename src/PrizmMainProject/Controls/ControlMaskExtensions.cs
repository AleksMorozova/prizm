using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Prizm.Main.Common
{
    static class ControlMaskExtensions
    {
        /// <summary>
        /// set mask mode and mask to text control. No placeholders.
        /// </summary>
        /// <param name="edit">text edit to extend</param>
        /// <param name="regExpMask">mask ready to apply to control</param>
        public static void SetMask(this TextEdit edit, string regExpMask)
        {
            if (!string.IsNullOrEmpty(regExpMask))
            {
                edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                edit.Properties.Mask.EditMask = regExpMask;
                edit.Properties.Mask.ShowPlaceHolders = false;
            }
        }
    }
}
