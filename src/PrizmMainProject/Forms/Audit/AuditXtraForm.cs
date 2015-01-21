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

namespace Prizm.Main.Forms.Audit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class AuditXtraForm : ChildForm
    {
        private AuditViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();
        
        public AuditXtraForm()
        {
            InitializeComponent();
            viewModel = (AuditViewModel)Program.Kernel.GetService(typeof(AuditViewModel));
        }

        private void AuditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            foreach (var u in viewModel.UsersList)
            {
                user.Properties.Items.Add(u);
            }
            startDate.DataBindings.Add("EditValue", viewModel, "StartDate");
            endDate.DataBindings.Add("EditValue", viewModel, "EndDate");
            auditResults.DataBindings.Add("DataSource", viewModel, "AuditResults");
            user.DataBindings.Add("EditValue", viewModel, "SelectedUser");
            number.DataBindings.Add("EditValue", viewModel, "Number");
            number.SetAsIdentifier();
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(search);
        }

        private void AuditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }


        private void tracingModeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;

            if (edit.SelectedIndex == 0)
            {
                startDate.Enabled = true;
                endDate.Enabled = true;

                user.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByPeriod;
            }
            else
            {
                user.Enabled = true;

                startDate.Enabled = false;
                endDate.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByUser;
            }
        }


    }
}