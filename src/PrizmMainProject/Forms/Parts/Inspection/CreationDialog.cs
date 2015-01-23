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
    public partial class CreationDialog : PrizmForm
    {
        public CreationDialog(string elementNumber)
        {
            InitializeComponent();
            partRadioGroupLayout.Text += elementNumber + "?";
            partRadioGroup.Properties.Items[0].Description = Resources.Spool;
            partRadioGroup.Properties.Items[1].Description = Resources.Component;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),
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