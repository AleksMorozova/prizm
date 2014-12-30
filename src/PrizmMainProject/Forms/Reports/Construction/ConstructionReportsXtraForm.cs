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

            var item1 = new RadioGroupItem(0, Resources.KP);
            var item2 = new RadioGroupItem(1, Resources.Joint);
            countPoints.Properties.Items.Add(item1);
            countPoints.Properties.Items.Add(item2);
            countPoints.SelectedIndex = 0;

            countPointsLayout.ContentVisible = false;
            typeLayout.ContentVisible = false;
            reportPeriodLabelLayout.ContentVisible = false;
            startLayout.ContentVisible = false;
            endLayout.ContentVisible = false;

        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            previewReportDocument.DataBindings.Add("DocumentSource", bindingSource, "PreviewSource");
            start.DataBindings.Add("EditValue", bindingSource, "StartPK");
            end.DataBindings.Add("EditValue", bindingSource, "EndPK");
            viewModel.LoadData();
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreateCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

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
            viewModel = (ConstructionReportViewModel)Program.Kernel.GetService(typeof(ConstructionReportViewModel));
            BindToViewModel();
            BindCommands();

            var pipeCheck = new EnumWrapper<PartType> { Value = PartType.Pipe };
            var spoolCheck = new EnumWrapper<PartType> { Value = PartType.Spool };
            var componentCheck = new EnumWrapper<PartType> { Value = PartType.Component };

            type.Properties.Items.Add(pipeCheck.Value, pipeCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(spoolCheck.Value, spoolCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(componentCheck.Value, componentCheck.Text, CheckState.Checked, true);


            var usedProduct = new EnumWrapper<ReportType> { Value = ReportType.UsedProductReport };
            var length = new EnumWrapper<ReportType> { Value = ReportType.PipelineLengthReport };
            var highway = new EnumWrapper<ReportType> { Value = ReportType.HighwayReport };

            reportType.Properties.Items.Add(usedProduct);
            reportType.Properties.Items.Add(length);
            reportType.Properties.Items.Add(highway);

            RefreshTypes();
            reportType.SelectedIndex = 0;
        }

        private void reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportType.SelectedItem.ToString() == Resources.UsedProductReport)
            {
                viewModel.report = new UsedProductsXtraReport();
                reportPeriodLabel.Text = Resources.Constraction_UsedProductReport_label;
                reportPeriodLabelLayout.ContentVisible = true;
                startLayout.ContentVisible = true;
                endLayout.ContentVisible = true;
                countPointsLayout.ContentVisible = false;
                typeLayout.ContentVisible = true;

                foreach (int KP in viewModel.AllKP)
                {
                    start.Properties.Items.Add(KP);
                    end.Properties.Items.Add(KP);
                }
            }

            else
            {
                viewModel.report = new testReport();
                reportPeriodLabel.Text = Resources.Constraction_Report_label;
                reportPeriodLabelLayout.ContentVisible = true;
                startLayout.ContentVisible = true;
                endLayout.ContentVisible = true;
                countPointsLayout.ContentVisible = true;
                typeLayout.ContentVisible = false;
            }
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            RefreshTypes();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            RefreshTypes();
        }

        private void ConstructionReportsXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }
    }
}