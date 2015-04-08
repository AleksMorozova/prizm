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
using Prizm.Main.Common;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using DevExpress.XtraEditors.Controls;
using Prizm.Domain.Entity;

namespace Prizm.Main.Forms.Audit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class AuditXtraForm : ChildForm
    {
        private AuditViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(AuditXtraForm));

        public AuditXtraForm()
        {
            InitializeComponent();
            viewModel = (AuditViewModel)Program.Kernel.GetService(typeof(AuditViewModel));
            viewModel.TracingMode = TracingModeEnum.TracingByNumber;
        }

        private void AuditXtraForm_Load(object sender, EventArgs e)
        {
            EnumWrapper<TracingModeEnum>.LoadItems(radioPeriodUser.Properties.Items);
            EnumWrapper<AuditRecordType>.LoadItems(includeCheckedList.Items);
            includeCheckedList.SetItemChecked(0, true);
            BindCommands();
            BindToViewModel();
            startDate.SetLimits();
            endDate.SetLimits();
        }

        private void BindToViewModel()
        {
            startDate.DataBindings.Add("EditValue", viewModel, "StartDate");
            endDate.DataBindings.Add("EditValue", viewModel, "EndDate");
            auditResults.DataBindings.Add("DataSource", viewModel, "AuditResults");          
            userList.Properties.DataSource = viewModel.UsersList.ToList();
            userList.DataBindings.Add("EditValue", viewModel, "SelectedUser");
            number.DataBindings.Add("EditValue", viewModel, "Number");
            radioPeriodUser.DataBindings.Add("SelectedIndex", viewModel, "TracingMode");
            number.SetAsIdentifier();
            includeCheckedList.DisplayMember = "Text";
            includeCheckedList.ValueMember = "Name";
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(search);
            viewModel.SearchCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            commandManager.RefreshVisualState();
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
                    new LocalizedItem(includeCheckedListLayout, StringResources.Audit_IncludeToSearchLayout.Id),

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
                    new LocalizedItem(operationTypeColumn, StringResources.Audit_OperationTypeColumnHeader.Id),

                    // layout control groups
                    new LocalizedItem(searchParametersLayoutGroup, StringResources.Audit_SearchParametersGroup.Id),

                    // radiogroup
                    new LocalizedItem(radioPeriodUser, new string [] {StringResources.Audit_RadioPeriod.Id, StringResources.Audit_RadioUser.Id}),

                    // header
                    new LocalizedItem(this, localizedHeader, new string[] {
                        StringResources.AuditXtraForm_Title.Id} ),

                    new LocalizedItem (includeCheckedList, new string[] 
                                                            {StringResources.Audit_CheckEdited.Id,
                                                            StringResources.Audit_CheckImported.Id,
                                                            StringResources.Audit_CheckCreated.Id,
                                                            StringResources.Audit_CheckDeleted.Id})
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
            if (radioPeriodUser.SelectedIndex < 0)
                return;
            var selected = (TracingModeEnum)radioPeriodUser.Properties.Items[radioPeriodUser.SelectedIndex].Value;
            viewModel.TracingMode = selected;

            if (radioPeriodUser.SelectedIndex == 0)
            {
                number.Enabled = true;
                userList.Enabled = false;
            }
            else
            {
                number.Enabled = false;
                userList.Enabled = true;
            }
        }

        private void auditResultsView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name.Equals(entityGridColumn.Name) || e.Column.Name.Equals(fieldGridColumn.Name))
            {
                StringResource? resId = Program.LanguageManager.FindById(typeof(StringResources), (/*"AuditItem_" + */e.Value.ToString()));
                if(resId != null)
                {
                    e.DisplayText = Program.LanguageManager.GetString((StringResource)resId);
                }
            }
            if (e.Column.Name.Equals(operationTypeColumn.Name))
            {
                switch (e.Value.ToString())
                {
                    case "E": e.DisplayText = Program.LanguageManager.GetString(StringResources.Audit_CheckEdited);
                        break;
                    case "I": e.DisplayText = Program.LanguageManager.GetString(StringResources.Audit_CheckImported);
                        break;
                    case "C": e.DisplayText = Program.LanguageManager.GetString(StringResources.Audit_CheckCreated);
                        break;
                    case "D": e.DisplayText = Program.LanguageManager.GetString(StringResources.Audit_CheckDeleted);
                        break;
                    default: e.DisplayText = String.Empty;
                        log.Warn(string.Format("String resource for {0} audit operation type is missing", e.Value.ToString()));
                        break;
                }
            }
        }

        private void includeCheckedList_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            List<string> operationList = new List<string>();
            foreach (ListBoxItem item in includeCheckedList.CheckedItems)
            {
               AuditRecordType operation;
               if (Enum.TryParse<AuditRecordType>(item.Value.ToString(), out operation))
               {
                   operationList.Add(operation.ToString());
               }
            }
            viewModel.OperationTypes = operationList;
            commandManager.RefreshVisualState();
        }

    }
}