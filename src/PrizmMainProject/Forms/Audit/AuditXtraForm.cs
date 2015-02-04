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
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Audit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class AuditXtraForm : ChildForm
    {
        private AuditViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();
        
        public AuditXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.history_item_16;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            viewModel = (AuditViewModel)Program.Kernel.GetService(typeof(AuditViewModel));
        }

        private void AuditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            foreach (var u in viewModel.UsersList)
            {
                user.Properties.Items.Add(u);
            }
            startDate.DataBindings.Add("EditValue", viewModel, "StartDate");
            endDate.DataBindings.Add("EditValue", viewModel, "EndDate");
            auditResults.DataBindings.Add("DataSource", viewModel, "AuditResults");
            user.DataBindings.Add("EditValue", viewModel, "SelectedUser");
            number.DataBindings.Add("EditValue", viewModel, "Number");
            number.SetAsIdentifier();
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(search);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>() 
                { 
                    //

                    // layout items
                    new LocalizedItem(numberLayout, StringResources.Audit_ElementNumberLabel.Id),
                    new LocalizedItem(periodLabelLayout, StringResources.Audit_PeriodLabel.Id),
                    new LocalizedItem(startDateLayout,StringResources.Audit_StartDateLabel.Id),
                    new LocalizedItem(endDateLayout,StringResources.Audit_EndDateLabel.Id),
                    new LocalizedItem(userLayout, StringResources.Audit_UserLabel.Id),

                    // controls
                    new LocalizedItem(search, StringResources.Audit_SearchButton.Id),

                    // grid column headers
                    new LocalizedItem(userGridColumn, StringResources.Audit_UserColumnHeader.Id),
                    new LocalizedItem(dateGridColumn, StringResources.Audit_DateColumnHeader.Id),
                    new LocalizedItem(entityGridColumn, StringResources.Audit_EntityColumnHeader.Id),
                    new LocalizedItem(oldValueGridColumn, StringResources.Audit_OldValueColumnHeader.Id),
                    new LocalizedItem(newValueGridColumn, StringResources.Audit_NewValueColumnHeader.Id),
                    new LocalizedItem(fieldGridColumn, StringResources.Audit_FieldColumnHeader.Id),
                    new LocalizedItem(numberColumn, StringResources.Audit_NumberColumnHeader.Id),

                    // layout control groups
                    new LocalizedItem(searchParametersLayoutGroup, StringResources.Audit_SearchParametersGroup.Id),

                    // radiogroup
                    new LocalizedItem(radioPeriodUser, new string [] {StringResources.Audit_RadioPeriod.Id, StringResources.Audit_RadioUser.Id}),
                };
        }

        #endregion // --- Localization ---

        private void AuditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }


        private void tracingModeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;

            if (edit.SelectedIndex == 0)
            {
                number.Enabled = true;
                user.Enabled = false;
                viewModel.TracingMode = TracingModeEnum.TracingByNumber;
            }
            else
            {
                number.Enabled = false;
                user.Enabled = true;
                viewModel.TracingMode = TracingModeEnum.TracingByUser;
            }
        }

        private void auditResultsView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name.Equals(entityGridColumn.Name) || e.Column.Name.Equals(fieldGridColumn.Name))
            {
                StringResource? resId = Program.LanguageManager.FindById(typeof(StringResources), (/*"AuditItem_" + */(string)e.Value));
                if (resId != null)
                {
                    e.DisplayText = Program.LanguageManager.GetString((StringResource)resId);
                }

            }
        }

    }
}