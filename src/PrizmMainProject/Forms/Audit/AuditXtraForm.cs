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
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Audit
{
    public partial class AuditXtraForm : ChildForm
    {
        private AuditViewModel viewModel;
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
        }

        private void BindCommands()
        {
            search.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

    }
}