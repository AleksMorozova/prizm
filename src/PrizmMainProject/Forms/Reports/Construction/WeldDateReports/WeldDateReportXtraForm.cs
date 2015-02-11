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
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class WeldDateReportXtraForm : ChildForm
    {
        private WeldDateReportViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public WeldDateReportXtraForm()
        {
            InitializeComponent();

            Bitmap bmp = Resources.reports_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            weldDateFrom.Properties.NullDate = DateTime.MinValue;
            weldDateFrom.Properties.NullText = string.Empty;
            weldDateTo.Properties.NullDate = DateTime.MinValue;
            weldDateTo.Properties.NullText = string.Empty;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            weldDateFrom.DataBindings
                .Add("EditValue", bindingSource, "WeldDateFrom");

            weldDateTo.DataBindings
                .Add("EditValue", bindingSource, "WeldDateTo");

            jointReportViewer.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreateRepoCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewRepoCommand).AttachTo(previewButton);
        }

        private void WeldDateReportXtraForm_Load(object sender, EventArgs e)
        {
            viewModel =
                (WeldDateReportViewModel)
                Program.Kernel.GetService(
                typeof(WeldDateReportViewModel));

            BindToViewModel();
            BindCommands();

            weldDateFrom.SetLimits();
            weldDateTo.SetLimits();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(weldDateFromLayout, StringResources.WeldDateReport_WeldDateFromLayout.Id),
                new LocalizedItem(weldDateToLayout, StringResources.WeldDateReport_WeldDateToLayout.Id),
                new LocalizedItem(previewButton, StringResources.WeldDateReport_PreviewButton.Id),
                new LocalizedItem(createReportButton, StringResources.WeldDateReport_CreateReportButton.Id),
                new LocalizedItem(weldReportParameterGroup, StringResources.WeldDateReport_WeldReportParameterGroup.Id),
                new LocalizedItem(jointReportViewerGroup, StringResources.WeldDateReport_JointReportViewerGroup.Id),
            };
        }

        #endregion // --- Localization ---

    }
}