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
        /// maximum number of digits before the decimal point, you can not enter more due to the 
        /// limitations of parsing at the method BindingHelper.CorrectDecimalSeparator
        /// </summary>
        private static int maxDigitsBeforeDecimalPoint = 7;

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

        /// <summary>
        /// set mask mode and mask to text control for entering float number. No placeholders.
        /// </summary>
        /// <param name="edit">text edit to extend</param>
        /// <param name="digitsBeforeDecimaPoint">number of digits before decima point</param>
        public static void SetFloatMask(this TextEdit edit, int digitsBeforeDecimaPoint)
        {
            int setDigits = (digitsBeforeDecimaPoint > maxDigitsBeforeDecimalPoint) ? maxDigitsBeforeDecimalPoint : digitsBeforeDecimaPoint;
                       
            edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            edit.Properties.Mask.EditMask = @"\d{0," + setDigits.ToString() + @"}([\.\,]\d{0,2})?";
            edit.Properties.Mask.ShowPlaceHolders = false;
        }
    }
}
