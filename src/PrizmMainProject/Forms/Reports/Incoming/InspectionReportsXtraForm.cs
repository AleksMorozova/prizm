using DevExpress.XtraEditors;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Prizm.Main.Forms.Reports.Incoming
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class InspectionReportsXtraForm : ChildForm
    {
        private InspectionReportsViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public InspectionReportsXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.reports_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void BindToViewModel()
        {
            inspectionReportsBindingSource.DataSource = viewModel;
            startDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "EndDate");
            previewReportDocument.DataBindings.Add("DocumentSource", inspectionReportsBindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
            commandManager["CreateReport"].Executor(viewModel.CreateCommand).AttachTo(createReportButton);
            commandManager["PreviewReport"].Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        private void InspectionReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (InspectionReportsViewModel)Program.Kernel.GetService(typeof(InspectionReportsViewModel));
            BindToViewModel();
            BindCommands();
            viewModel.StartDate = DateTime.Now.Date;
            viewModel.EndDate = DateTime.Now.Date;

            startDate.SetLimits();
            endDate.SetLimits();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(incomingInspectionDateLabel, StringResources.InspectionReport_DateLabel.Id),
                new LocalizedItem(startDateLayout, StringResources.InspectionReport_StartDateLabel.Id),
                new LocalizedItem(endDateLayout, StringResources.InspectionReport_EndDateLabel.Id),

                new LocalizedItem(createReportLayoutGroup, StringResources.InspectionReport_CreateGroup.Id),
                new LocalizedItem(previewReportLayoutGroup, StringResources.InspectionReport_PreviewGroup.Id),

                new LocalizedItem(previewButton, StringResources.InspectionReport_PreviewButton.Id),
                new LocalizedItem(createReportButton, StringResources.InspectionReport_CreateButton.Id),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.InspectionReport_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void InspectionReportsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }
    }
}