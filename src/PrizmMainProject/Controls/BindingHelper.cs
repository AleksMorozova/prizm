using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Controls
{
    class BindingHelper
    {
        public static void CorrectDecimalSeparator(object sender, ConvertEditValueEventArgs e)
        {
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string val = e.Value.ToString();
            if (val != string.Empty)
            {
                if (!val.Contains(decimalSeparator))
                {
                    if (decimalSeparator == ",")
                        val = val.Replace(".", decimalSeparator);
                    else
                        val = val.Replace(",", decimalSeparator);
                }
                e.Value = decimal.Parse(val);
            }
        }

        #region --- Inversion ---

        public static Binding CreateCheckEditInverseBinding(string propertyName, object dataSource, string dataMember)
        {
            Binding bind = new Binding(propertyName, dataSource, dataMember);
            bind.FormattingEnabled = true;
            bind.Format += new ConvertEventHandler(BindingHelper.Invert);
            bind.Parse += new ConvertEventHandler(BindingHelper.Invert);
            return bind;
        }

        private static void Invert(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(bool))
            {
                e.Value = !((bool)e.Value);
            }
        }

        #endregion // --- Inversion ---

        #region --- OneWay ---
        /// <summary>
        /// It seems WinForm doesn't allow simple one-way from model to form control.
        /// If it is possible, this code should be replaced
        /// StringByValue should take value. Creator of this binding should control the real type of the value.
        /// </summary>
        /// <returns>new binding</returns>
        public static Binding CreateOneWayReadToString(string propertyName, object dataSource, string dataMember, StringByValue oneWayConverter)
        {
            OneWayBindingToString bind = new OneWayBindingToString(propertyName, dataSource, dataMember, oneWayConverter);
            bind.FormattingEnabled = true;
            bind.Format += new ConvertEventHandler(BindingHelper.Invert);
            bind.Parse += new ConvertEventHandler(BindingHelper.Invert);
            return bind;
        }

        public delegate string StringByValue(object value);

        private class OneWayBindingToString : Binding
        {
            public OneWayBindingToString(string propertyName, object dataSource, string dataMember, StringByValue oneWayConverter)
                : base (propertyName, dataSource, dataMember)
            {
                this.GetStringByValue = oneWayConverter ?? delegate { return ""; };
                this.FormattingEnabled = true;
                this.Format += new ConvertEventHandler(FormatAndStoreValue);
                this.Parse += new ConvertEventHandler(RestoreValue);
            }

            /// <summary>
            /// Save original value (to be restored on way back)
            /// </summary>
            private object value;
            private StringByValue GetStringByValue;

            private void FormatAndStoreValue(object sender, ConvertEventArgs e)
            {
                if (e.DesiredType == typeof(string))
                {
                    this.value = e.Value;
                    e.Value = GetStringByValue(this.value);
                }
            }
            private void RestoreValue(object sender, ConvertEventArgs e)
            {
                if (e.DesiredType == typeof(bool))
                {
                    e.Value = this.value;
                }
            }
        }

        #endregion //--- OneWay ---
    }
}
