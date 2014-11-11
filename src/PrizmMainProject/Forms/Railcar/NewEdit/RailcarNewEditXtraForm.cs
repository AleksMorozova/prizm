using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public partial class RailcarNewEditXtraForm : XtraForm
    {
        private RailcarViewModel viewModel;

        public RailcarNewEditXtraForm()
        {
            InitializeComponent();
        }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (RailcarViewModel) Program.Kernel.GetService(typeof (RailcarViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }
    }
}