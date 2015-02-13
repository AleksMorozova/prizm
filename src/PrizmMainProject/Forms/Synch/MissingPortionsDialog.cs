using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MissingPortionsDialog : PrizmForm
    {
        public MissingPortionsDialog(int[] existingPortions, int[] missingPortions, string millName)
        {
            InitializeComponent();
            message.Text = string.Format(@"Последовательность импортируемых данных из {0} нарушена.
Уже существуют порции с номерами:",millName);
            StringBuilder sb = new StringBuilder();
            if (existingPortions.Length >= 1)
            {
                if (!CheckDiapason(existingPortions))
                {
                    sb.Append(existingPortions[0] + ",");
                    for (int i = 1; i < existingPortions.Length; i++)
                    {
                        sb.Append(existingPortions[i] + ",");
                    }
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(existingPortions.Min());
                    if(existingPortions.Max()!= existingPortions.Min())
                    sb.Append("-" + existingPortions.Max());
                }
            }
            portionsDiapason.Text = sb.ToString();
            sb.Clear();
            if (missingPortions.Length != 0)
            {
                foreach (int i in missingPortions)
                {
                    sb.Append(i.ToString() + ",");
                }
                sb.Remove(sb.Length - 1, 1);
            }
            missingNumbers.Text += sb.ToString();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(missingNumbers, StringResources.MissingPortion_missingNumbers.Id),
                new LocalizedItem(recomendation, StringResources.MissingPortion_recomendation.Id),
                new LocalizedItem(acceptButton, StringResources.MissingPortion_acceptButton.Id),
                new LocalizedItem(cancelButton, StringResources.MissingPortion_cancelButton.Id),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.MissingPortionsDialog_Title.Id} )
            };
        }

        #endregion // --- Localization ---


        private bool CheckDiapason(int[] arr)
        {
            bool isDiapason = true;
            for (int i = 0; i<arr.Length-1; i++)
            {
                if (arr[i + 1] - arr[i] != 1)
                    isDiapason = false;
            }
            return isDiapason;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

    }
}