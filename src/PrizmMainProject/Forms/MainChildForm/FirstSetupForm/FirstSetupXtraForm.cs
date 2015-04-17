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
using Prizm.Main.Languages;
using Prizm.Main.Controls;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FirstSetupXtraForm : PrizmForm
    {
        FirstSetupViewModel viewModel;
        private List<string> localizedAllWorkstations = new List<string>();
        private void UpdateTextEdit()
        {
            bindingSource.CancelEdit(); 
        }
        [Inject]
        public FirstSetupXtraForm(FirstSetupViewModel vm)
        {
            InitializeComponent();
            SetControlsTextLength();
            viewModel = vm;
            SetControlsDisable();

            this.AcceptButton = saveButton;
            this.CancelButton = cancelButton;
        }

        private void FirstSetupXtraForm_Load(object sender, EventArgs e)
        {
            EnumWrapper<WorkstationType>.LoadItems(localizedAllWorkstations);

            BindToViewModel();
            pipeNumberMaskRulesLabel.Text = Program.LanguageManager.GetString(StringResources.Mask_Label);
            localizedHeader.Clear();

            localizedHeader.Add(Resources.FirstSetup_FormHeader);  // usage of Resources is OK - setting default values here
            localizedHeader.Add(WorkstationType.Mill.ToString());
            localizedHeader.Add(WorkstationType.Master.ToString());
            localizedHeader.Add(WorkstationType.Construction.ToString());
            fileSize.SetMask(Constants.PositiveDigitMask);
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            type.DataBindings.Add(
                BindingHelper.CreateOneWayReadToString("Text", bindingSource, "Type",
                (value) =>
                {
                    return (string)localizedAllWorkstations[(int)value];
                }));

            millLayoutControlItem.DataBindings.Add(
                BindingHelper.CreateOneWayReadToString("Text", bindingSource, "Type",
                (value) =>
                {
                    return 
                        Program.LanguageManager.GetString(StringResources.SettingsProject_MillLabel)
                        +
                        " (" + (string)localizedAllWorkstations[(int)viewModel.Type] + ")";
                }));

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
                new LocalizedItem(maskLayoutControlItem, StringResources.FirstSetup_PipeNumberFormatLabel.Id),
                new LocalizedItem(millLayoutControlItem, StringResources.FirstSetup_MillLabel.Id),
                new LocalizedItem(loginLayoutControlItem, StringResources.FirstSetup_LoginLabel.Id),
                new LocalizedItem(passLayoutControlItem, StringResources.FirstSetup_PasswordLabel.Id),
                new LocalizedItem(passLayoutControlItem, StringResources.FirstSetup_PasswordLabel.Id),
                new LocalizedItem(reEnterLayoutControlItem, StringResources.FirstSetup_ReEnterPasswordLabel.Id),
                new LocalizedItem(lastNameLayoutControlItem, StringResources.FirstSetup_LastNameLabel.Id),
                new LocalizedItem(firstNameLayoutControlItem, StringResources.FirstSetup_FirstNameLabel.Id),
                new LocalizedItem(middleNameLayoutControlItem, StringResources.FirstSetup_MiddleNameLabel.Id),
                new LocalizedItem(projectLayoutGroup,StringResources.FirstSetup_ProjectGroup.Id),
                new LocalizedItem(adminLayoutControlGroup, StringResources.FirstSetup_MainAdministratorGroup.Id),
                
                new LocalizedItem(saveButton, StringResources.FirstSetup_SaveButton.Id),
                new LocalizedItem(cancelButton, StringResources.FirstSetup_CancelButton.Id),

                new LocalizedItem(UpdateTextEdit, localizedAllWorkstations,
                        new string [] {StringResources.WorkstationType_Undefined.Id, 
                            StringResources.WorkstationType_Master.Id, 
                            StringResources.WorkstationType_Mill.Id, 
                            StringResources.WorkstationType_Construction.Id} ),

                // header
                new LocalizedItem(this, localizedHeader, new string[] { "FirstSetup_FormHeader", 
                    "MainWindowHeader_Mill", "MainWindowHeader_Master", "MainWindowHeader_Construction" } ),
           };
        }
               public override void UpdateTitle()
        {
            // base.UpdateTitle(); should not be called
            this.Text = string.Concat(localizedHeader[0], " [", 
                viewModel.Project.WorkstationType == WorkstationType.Mill 
                ? localizedHeader[1]
                : viewModel.Project.WorkstationType == WorkstationType.Master
                    ? localizedHeader[2]
                    : viewModel.Project.WorkstationType == WorkstationType.Construction
                        ? localizedHeader[3]
                        : ""
            , "]");
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

        private void SetControlsTextLength() 
        {
            projectName.Properties.MaxLength = LengthLimit.MaxProjectTitle; 
            mill.Properties.MaxLength = LengthLimit.MaxProjectMillName;
            pipeMask.Properties.MaxLength = LengthLimit.MaxPipeNumber;
            login.Properties.MaxLength = LengthLimit.UserLogin;
            lastName.Properties.MaxLength = LengthLimit.UserLastName;
            firstName.Properties.MaxLength = LengthLimit.UserFirstName;
            middleName.Properties.MaxLength = LengthLimit.UserMiddleName;
        }

        private void SetControlsDisable()
        {
            pipeMask.Enabled = viewModel.Type == WorkstationType.Mill;
        }
    }
}