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
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),

                // controls
                //new LocalizedItem(attachmentsButton, "NewEditPipe_AttachmentsButton"),

                // grid column headers
                //new LocalizedItem(weldersGridColumn, "NewEditPipe_WeldersColumnHeader"),

                // layout control groups
                //new LocalizedItem(plateLayoutControlGroup, "NewEditPipe_PlateGroup"),

                // other
            };
        }

        #endregion // --- Localization ---

    }
}