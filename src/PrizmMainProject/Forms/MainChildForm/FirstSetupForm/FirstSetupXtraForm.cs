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
using Domain.Entity.Setup;
using PrizmMain.Common;
using Ninject;

namespace PrizmMain.Forms.MainChildForm.FirstSetupForm
{
    public partial class FirstSetupXtraForm : DevExpress.XtraEditors.XtraForm
    {
        FirstSetupViewModel viewModel;

        [Inject]
        public FirstSetupXtraForm(FirstSetupViewModel vm)
        {
            InitializeComponent();
            viewModel = vm;
        }

        private void FirstSetupXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindCommands()
        {
            //
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            type.Properties.DataSource = viewModel.Types;
            type.Properties.DisplayMember = "Text";
            type.Properties.ValueMember = "Value";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            validationProvider.Validate();
        }

        private void type_EditValueChanged(object sender, EventArgs e)
        {
            var look = sender as LookUpEdit;

            if(((WorkstationType)look.EditValue) == WorkstationType.Mill)
            {
                millLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                maskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;  
            }
            else
            {
                millLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                maskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}