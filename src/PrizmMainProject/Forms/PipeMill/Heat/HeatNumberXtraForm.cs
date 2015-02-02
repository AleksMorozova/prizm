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
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class HeatNumberXtraForm : PrizmForm
    {
        public HeatNumberXtraForm(string number)
        {
            InitializeComponent();
            SetControlsTextLength();
            this.number.Text = number;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(numberLayoutControl, StringResources.HeatNumber_HeatNumberLabel.Id),
                new LocalizedItem(saveButton, StringResources.HeatNumber_SaveButton.Id),
                new LocalizedItem(cancelButton, StringResources.HeatNumber_CancelButton.Id),
            };
        }

        #endregion // --- Localization ---

        public string Number { get { return number.Text; } }

        private void SetControlsTextLength()
        {
            number.Properties.MaxLength = LengthLimit.MaxHeatNumber;
            number.SetAsIdentifier();
        }
    }
}