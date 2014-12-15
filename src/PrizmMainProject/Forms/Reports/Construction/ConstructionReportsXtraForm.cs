using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Common;
using System.Windows.Forms;
using PrizmMain.Forms.Common;
using System.ComponentModel;

namespace PrizmMain.Forms.Reports.Construction
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ConstructionReportsXtraForm : ChildForm
    {
        private ConstructionReportViewModel viewModel;

        public ConstructionReportsXtraForm()
        {
            InitializeComponent();

            reportType.Properties.Items.Add("Использованные изделия");
            reportType.Properties.Items.Add("Протяженность трубопровода");
            reportType.Properties.Items.Add("Трассовка");

            var item1 = new RadioGroupItem(0, "Стык");
            var item2 = new RadioGroupItem(1, "Пикет");
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
            createReportButton.BindCommand(() => viewModel.CreateCommand.Execute(), viewModel.CreateCommand);
            previewButton.BindCommand(() => viewModel.PreviewCommand.Execute(), viewModel.PreviewCommand);
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
            RefreshTypes();
            reportType.SelectedIndex = 0;
        }

        private void reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportType.SelectedItem == "Использованные изделия")
            {
                viewModel.report = new UsedProductsXtraReport();
                reportPeriodLabel.Text = "Пикеты";
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
                reportPeriodLabel.Text = "Точки отсчета";
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
    }
}