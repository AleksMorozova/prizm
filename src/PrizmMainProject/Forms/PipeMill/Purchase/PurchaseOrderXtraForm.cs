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
using Domain.Entity.Mill;
using PrizmMain.Forms.PipeMill.Purchase;
using Ninject;
using Ninject.Parameters;

namespace PrizmMain.Forms.PipeMill
{
    public partial class PurchaseOrderXtraForm : DevExpress.XtraEditors.XtraForm
    {
        PurchaseOrderViewModel viewModel;

        public PurchaseOrderXtraForm()
            : this(Guid.Empty)
        {

        }
        public PurchaseOrderXtraForm(Guid id)
        {
            InitializeComponent();
            viewModel = (PurchaseOrderViewModel)Program.Kernel.Get<PurchaseOrderViewModel>(new ConstructorArgument("id", id));
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
    }
}