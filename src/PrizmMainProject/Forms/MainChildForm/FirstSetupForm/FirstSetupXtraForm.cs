﻿using System;
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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FirstSetupXtraForm : PrizmForm
    {
        FirstSetupViewModel viewModel;

        [Inject]
        public FirstSetupXtraForm(FirstSetupViewModel vm)
        {
            InitializeComponent();
            Bitmap bmp = Resources.prizma_appIcon_32;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            viewModel = vm;
            this.Text += ": [" + viewModel.Type + "]";
        }

        private void FirstSetupXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
            pipeNumberMaskRulesLabel.Text = Resources.Mask_Label;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            type.DataBindings.Add("EditValue", bindingSource, "Type");
            projectName.DataBindings.Add("EditValue", bindingSource, "ProjectTitle");
            fileSize.DataBindings.Add("EditValue", bindingSource, "Size");
            mill.DataBindings.Add("EditValue", bindingSource, "MillName");
            pipeMask.DataBindings.Add("EditValue", bindingSource, "MillPipeNumberMask");
            login.DataBindings.Add("EditValue", bindingSource, "Login");
            pass.DataBindings.Add("EditValue", bindingSource, "Password");
            lastName.DataBindings.Add("EditValue", bindingSource, "LastName");
            firstName.DataBindings.Add("EditValue", bindingSource, "FirstName");
            middleName.DataBindings.Add("EditValue", bindingSource, "MiddleName");
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(titleLayoutControl, StringResources.FirstSetup_ProjectTitleLabel.Id),
                new LocalizedItem(fileLayoutControlItem, StringResources.FirstSetup_FileSizeLabel.Id),
                new LocalizedItem(typeLayoutControlItem, StringResources.FirstSetup_TypeLabel.Id),
                new LocalizedItem(millLayoutControlItem, StringResources.FirstSetup_MillLabel.Id),
                new LocalizedItem(loginLayoutControlItem, StringResources.FirstSetup_LoginLabel.Id),
                new LocalizedItem(passLayoutControlItem, StringResources.FirstSetup_PasswordLabel.Id),
                new LocalizedItem(passLayoutControlItem, StringResources.FirstSetup_PasswordLabel.Id),
                new LocalizedItem(reEnterLayoutControlItem, StringResources.FirstSetup_ReEnterPasswordLabel.Id),
                new LocalizedItem(lastNameLayoutControlItem, StringResources.FirstSetup_LastNameLabel.Id),
                new LocalizedItem(firstNameLayoutControlItem, StringResources.FirstSetup_FirstNameLabel.Id),
                new LocalizedItem(millLayoutControlItem, StringResources.FirstSetup_MiddleNameLabel.Id),
                
                new LocalizedItem(saveButton, StringResources.FirstSetup_SaveButton.Id),
                new LocalizedItem(cancelButton, StringResources.FirstSetup_CancelButton.Id)
            };
        }

        #endregion // --- Localization ---

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

        private void FirstSetupXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
        }
    }
}