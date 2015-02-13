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
using Prizm.Main.Properties;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class CreateSpoolComponentDialog : PrizmForm
    {
        public CreateSpoolComponentDialog(string elementNumber)
        {
            InitializeComponent();
            this.SetupForm(elementNumber);
        }

        public void SetupForm(string elementNumber) 
        {
            Bitmap bmp = Resources.inControl_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            numberLabelLayout.Text = elementNumber + "?";
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(questionLabelLayout, StringResources.CreateSpoolComponentDialog_CreateElementQuestionLabel.Id),
                new LocalizedItem(partRadioGroup, new string[]{ StringResources.CreateSpoolComponentDialog_RadioSpool.Id, StringResources.CreateSpoolComponentDialog_RadioComponent.Id}),
                new LocalizedItem(cancelButton, StringResources.CreateSpoolComponentDialog_CancelButton.Id),
                new LocalizedItem(acceptButton, StringResources.CreateSpoolComponentDialog_CreateButton.Id),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.CreateSpoolComponentDialog_Title.Id} )
            };
        }

        #endregion // --- Localization ---


        /// <summary>
        /// Setup of dialog testResult: if yes - spool was selected, no - component
        /// Dialog testResult is used in SearchPartForInspectionCommand
        /// </summary>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (partRadioGroup.EditValue.ToString() == "spool")
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;                              
            }
        }

    }
}