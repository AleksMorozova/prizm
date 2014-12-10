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

namespace PrizmMain.Forms.InspectionParts.Search
{
    public partial class PartsSearchXtraForm : ChildForm
    {
        private PartsSearchViewModel viewModel;

        public PartsSearchXtraForm()
        {
            InitializeComponent();
        }

        private void PartsSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartsSearchViewModel)Program.Kernel.GetService(typeof(PartsSearchViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
        }

        private void BindCommands()
        {
      
        }
    }
}