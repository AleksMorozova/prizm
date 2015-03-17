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
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class PipeConstractionReportXtraForm  : ChildForm
    {
        private PipeConstractionReportViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public PipeConstractionReportXtraForm()
        {
            InitializeComponent();
            pipeNumber.SetAsIdentifier();
        }

        private void PipeConstractionReportXtraForm_Load(object sender, EventArgs e)
        {
            viewModel =
                (PipeConstractionReportViewModel)
                Program.Kernel.GetService(
                typeof(PipeConstractionReportViewModel));

            BindToViewModel();
            BindCommands();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            foreach (var s in viewModel.PipeTypes)
            {
                pipeTypeCheckedCombo.Properties.Items.Add(s, true);
            }

            pipeNumber.DataBindings
                .Add("EditValue", bindingSource, "PipeNumber");

            pipeReportViewer.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");

            footersCheck.DataBindings
                .Add("EditValue", bindingSource, "IsFooterVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreatePipeReportCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewPipeReportCommand).AttachTo(previewButton);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(footersCheck, StringResources.PipeConstructionReport_FootersCheck.Id),
                new LocalizedItem(pipeNumberLayout, StringResources.PipeConstructionReport_PipeNumberLayout.Id),
                new LocalizedItem(pipeTypeCheckedComboLayout, StringResources.PipeConstructionReport_PipeTypeCheckedComboLayout.Id),
                new LocalizedItem(pipeReportParametersLayoutGroup, StringResources.PipeConstructionReport_PipeReportParametersLayoutGroup.Id),
                new LocalizedItem(previewButton, StringResources.PipeConstructionReport_PreviewButton.Id),
                new LocalizedItem(createReportButton, StringResources.PipeConstructionReport_CreateReportButton.Id),
                new LocalizedItem(documentViewerLayoutGroup, StringResources.PipeConstructionReport_DocumentViewerLayoutGroup.Id),
                new LocalizedItem(this, localizedHeader, new string[] {StringResources.PipeConstructionReport_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void pipeTypeCheckedCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedPipeTypes.Clear();

            for (int i = 0; i < pipeTypeCheckedCombo.Properties.Items.Count; ++i)
            {
                if (pipeTypeCheckedCombo.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.CheckedPipeTypes
                        .Add(pipeTypeCheckedCombo.Properties.Items[i].Value as PipeMillSizeType);
                }
            }
        }
    }
}