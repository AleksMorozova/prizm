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
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            weldDateFrom.DataBindings
                .Add("EditValue", bindingSource, "WeldDateFrom");

            weldDateTo.DataBindings
                .Add("EditValue", bindingSource, "WeldDateTo");

            pipeReportViewer.DataBindings
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
    }
}