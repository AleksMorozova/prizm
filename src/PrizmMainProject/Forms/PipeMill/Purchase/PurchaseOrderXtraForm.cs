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
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Forms.PipeMill.Purchase;
using Ninject;
using Ninject.Parameters;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PurchaseOrderXtraForm : PrizmForm
    {
        PurchaseOrderViewModel viewModel;

        public PurchaseOrderXtraForm()
            : this(string.Empty)
        {

        }
        public PurchaseOrderXtraForm(string nmb)
        {
            InitializeComponent();
            SetControlsTextLength();
            viewModel = (PurchaseOrderViewModel)Program.Kernel.Get<PurchaseOrderViewModel>(new ConstructorArgument("number", nmb));
            number.SetAsIdentifier();
        }

        private void PurchaseOrderXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            number.DataBindings.Add("EditValue", bindingSource, "Number");
            date.DataBindings.Add("EditValue", bindingSource, "Date");
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            viewModel.SaveCommand.Execute();
            if (viewModel.IsSaved == true)
            {
                this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetControlsTextLength()
        {
            number.Properties.MaxLength = LengthLimit.MaxPurchaseOrderNumber;
        }

        private void PurchaseOrderXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }
    }
}