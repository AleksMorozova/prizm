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
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Ninject;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
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
            BindToViewModel();
            pipeNumberMaskRulesLabel.Text = Resources.Mask_Label;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            type.Properties.DataSource = viewModel.Types;
            type.Properties.DisplayMember = "Text";
            type.Properties.ValueMember = "Value";

            projectName.DataBindings.Add("EditValue", bindingSource, "ProjectTitle");
            type.DataBindings.Add("EditValue", bindingSource, "Type");
            fileSize.DataBindings.Add("EditValue", bindingSource, "Size");
            mill.DataBindings.Add("EditValue", bindingSource, "MillName");
            pipeMask.DataBindings.Add("EditValue", bindingSource, "MillPipeNumberMask");
            login.DataBindings.Add("EditValue", bindingSource, "Login");
            pass.DataBindings.Add("EditValue", bindingSource, "Password");
            lastName.DataBindings.Add("EditValue", bindingSource, "LastName");
            firstName.DataBindings.Add("EditValue", bindingSource, "FirstName");
            middleName.DataBindings.Add("EditValue", bindingSource, "MiddleName");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            viewModel.IsSaved = false;
            if(validationProvider.Validate())
            {
                viewModel.SaveCommand.Execute();
            }
            if(viewModel.IsSaved)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void type_EditValueChanged(object sender, EventArgs e)
        {
            var look = sender as LookUpEdit;

            if(((WorkstationType)look.EditValue) == WorkstationType.Mill)
            {
                millLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                maskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                pipeNumberMaskLayoutItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                millLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                maskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                pipeNumberMaskLayoutItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}