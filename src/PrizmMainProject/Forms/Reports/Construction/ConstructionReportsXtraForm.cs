using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Common;
using System.Windows.Forms;
using Prizm.Main.Forms.Common;
using System.ComponentModel;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System.Linq;


using construct = Prizm.Domain.Entity.Construction;
using Prizm.Main.Languages;
using System.Collections.Generic;
using System.Drawing;

namespace Prizm.Main.Forms.Reports.Construction
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ConstructionReportsXtraForm : ChildForm
    {
        private ConstructionReportViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public ConstructionReportsXtraForm()
        {
            InitializeComponent();
            start.SetAsIdentifier();
            end.SetAsIdentifier();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            previewReportDocument.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");

            reportType.DataBindings
                .Add("SelectedIndex", bindingSource, "ReportTypeIndex");

            start.DataBindings
                .Add("EditValue", bindingSource, "StartJoint");

            end.DataBindings
                .Add("EditValue", bindingSource, "EndJoint");

            startKPLookUp.DataBindings
                .Add("EditValue", bindingSource, "StartPK");

            endKPLookUp.DataBindings
                .Add("EditValue", bindingSource, "EndPK");

            footersCheck.DataBindings
                .Add("EditValue", bindingSource, "IsFooterVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);

        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreateCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(reportTypeLayout, StringResources.ConstructionReports_ReportTypeLayout.Id),
                new LocalizedItem(typeLayout, StringResources.ConstructionReports_TypeLayout.Id),
                new LocalizedItem(startJointLayout, StringResources.ConstructionReports_StartJointLayout.Id),
                new LocalizedItem(startKPComboBoxLayoutControl, StringResources.ConstructionReports_StartKPComboBoxLayoutControl.Id),
                new LocalizedItem(endJointLayout, StringResources.ConstructionReports_EndJointLayout.Id),
                new LocalizedItem(endKPLayout, StringResources.ConstructionReports_EndKPLayout.Id),
                new LocalizedItem(previewButton, StringResources.ConstructionReports_PreviewButton.Id),
                new LocalizedItem(createReportButton, StringResources.ConstructionReports_CreateReportButton.Id),
                new LocalizedItem(createReportaLyoutGroup, StringResources.ConstructionReports_CreateReportaLyoutGroup.Id),
                new LocalizedItem(previewLayoutGroup, StringResources.ConstructionReports_PreviewLayoutGroup.Id),
                // radio groups
                new LocalizedItem(tracingModeRadioGroup, 
                    new string[]{ StringResources.ConstructionReport_RadioJoints.Id, StringResources.ConstructionReport_RadioKP.Id }),

                // comboboxes
                new LocalizedItem(type, new  string [] {StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id} ),
                new LocalizedItem(reportType, new string[] {StringResources.ConstructionReport_ReportTypeTracingReport.Id, StringResources.ConstructionReport_ReportTypeUsedProductReport.Id}),

                new LocalizedItem(footersCheck, StringResources.ConstructionReports_FootersCheck.Id),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.ConstructionReport_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void RefreshTypes()
        {
            BindingList<PartType> selectedTypes = new BindingList<PartType>();
            for (int i = 0; i < type.Properties.Items.Count; i++)
            {
                if (type.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    selectedTypes.Add((PartType)type.Properties.Items[i].Value);
                }
            }
            viewModel.Types.Clear();
            viewModel.Types = selectedTypes;
        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            infoLabel.Text = Program.LanguageManager.GetString(StringResources.ConstructionReport_TracingReportInfoLabelText);

            viewModel = (ConstructionReportViewModel)Program.Kernel.GetService(typeof(ConstructionReportViewModel));

            foreach (var item in EnumWrapper<PartType>.EnumerateItems(skip0:true))
            {
                type.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, true);
            }
            foreach(var item in EnumWrapper<ReportType>.EnumerateItems())
            {
                reportType.Properties.Items.Add(item.Item2);
            }

            viewModel.LoadData();

            start.Properties.DataSource = viewModel.JointsProjections;
            end.Properties.DataSource = viewModel.JointsProjections;

            startKPLookUp.Properties.DataSource = viewModel.AllKP;
            endKPLookUp.Properties.DataSource = viewModel.AllKP;

            BindToViewModel();
            BindCommands();
            RefreshTypes();

            viewModel.ReportTypeIndex = reportType.SelectedIndex = 0;

            tracingModeRadioGroup_SelectedIndexChanged(tracingModeRadioGroup, e);
        }

        private void reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.ReportTypeIndex = reportType.SelectedIndex;
            if (viewModel.ReportType == ReportType.UsedProductReport)
            {
                typeLayout.ContentVisible = true;
                infoLabelLayout.ContentVisible = true;
            }
            else
            {
                typeLayout.ContentVisible = false;
                infoLabelLayout.ContentVisible = false;
            }
        }

        private void ConstructionReportsXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }

        private void type_EditValueChanged(object sender, EventArgs e)
        {
            RefreshTypes();
        }

        private void tracingModeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;

            if (edit.SelectedIndex == 0)
            {
                start.Enabled = true;
                end.Enabled = true;

                startKPLookUp.Enabled = false;
                endKPLookUp.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByJoints;
            }
            else
            {
                start.Enabled = false;
                end.Enabled = false;

                startKPLookUp.Enabled = true;
                endKPLookUp.Enabled = true;

                viewModel.TracingMode = TracingModeEnum.TracingByKP;
            }
        }
    }
}