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

            pipeNumber.DataBindings
                .Add("EditValue", bindingSource, "PipeNumber");

            pipeDiameter.DataBindings
                .Add("EditValue", bindingSource, "Diameter");

            pipeThickness.DataBindings
                .Add("EditValue", bindingSource, "WallThickness");

            pipeReportViewer.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreatePipeReportCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewPipeReportCommand).AttachTo(previewButton);
        }
    }
}