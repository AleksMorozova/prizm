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

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PartInspectionXtraForm : ChildForm
    {
        private PartInspectionViewModel viewModel;
        ICommandManager commandManager = new CommandManager();
        public PartInspectionXtraForm()
        {
            InitializeComponent();
        }

        private void PartInspectionXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartInspectionViewModel)Program.Kernel.GetService(typeof(PartInspectionViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            searchNumber.DataBindings.Add("Editvalue", bindingSource, "SearchNumber");
            elementNumber.DataBindings.Add("Text", bindingSource, "SelectedElement.Number");
            elementType.DataBindings.Add("Text", bindingSource, "SelectedElement.Type");
            inspections.DataBindings.Add("DataSource", bindingSource, "InspectionTestResults");
        }
    }
}