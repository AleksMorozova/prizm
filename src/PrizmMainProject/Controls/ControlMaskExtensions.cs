using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

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
        /// set mask mode and mask to text control for entering float number
        /// </summary>
        /// <param name="edit">text edit to extend</param>
        /// <param name="digitsBeforeDecimaPoint">number of digits before decima point</param>
        public static void SetFloatMask(this TextEdit edit, int digitsBeforeDecimaPoint, bool canBeNegative = false)
        {
            SetUpMask(edit.Properties.Mask, digitsBeforeDecimaPoint, canBeNegative);
        }

        /// <summary>
        /// set mask mode and mask to RepositoryItemTextEdit control for entering float number
        /// </summary>
        /// <param name="edit">text edit to extend</param>
        /// <param name="digitsBeforeDecimaPoint">number of digits before decima point</param>
        public static void SetFloatMask(this RepositoryItemTextEdit edit, int digitsBeforeDecimaPoint, bool canBeNegative=false)
        {
            SetUpMask(edit.Mask, digitsBeforeDecimaPoint, canBeNegative);
        }

        /// <summary>
        /// set mask mode and mask. No placeholders.
        /// </summary>
        /// <param name="edit">mask</param>
        /// <param name="digitsBeforeDecimaPoint">number of digits before decima point</param>
        private static void SetUpMask(DevExpress.XtraEditors.Mask.MaskProperties mask, int digitsBeforeDecimaPoint, bool canBeNegative) 
        {
            int setDigits = (digitsBeforeDecimaPoint > maxDigitsBeforeDecimalPoint) ? maxDigitsBeforeDecimalPoint : digitsBeforeDecimaPoint;
            mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            if (canBeNegative)
            {
                mask.EditMask = @"(-\d|\d){0," + setDigits.ToString() + @"}([\.\,]\d{0,2})?";
            }
            else
            {
                mask.EditMask = @"\d{0," + setDigits.ToString() + @"}([\.\,]\d{0,2})?";
            }
            mask.ShowPlaceHolders = false;
        } 
    }
}
