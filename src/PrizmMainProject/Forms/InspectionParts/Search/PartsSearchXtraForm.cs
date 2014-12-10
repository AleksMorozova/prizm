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
using PrizmMain.Forms.Common;
using PrizmMain.Properties;

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
            
            type.Properties.Items.Add(PartType.Pipe, Resources.PartTypePipe,CheckState.Checked,true);
            type.Properties.Items.Add(PartType.Spool, Resources.PartTypeSpool, CheckState.Checked, true);
            type.Properties.Items.Add(PartType.Component, Resources.PartTypeComponent, CheckState.Checked, true);
            RefreshTypes();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

        private void type_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            RefreshTypes();
        }

        private void RefreshTypes()
        {
            BindingList<PartType> selectedTypes = new BindingList<PartType>();
            for(int i = 0; i < type.Properties.Items.Count; i++)
            {
                if(type.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    selectedTypes.Add((PartType)type.Properties.Items[i].Value);
                }
            }
            viewModel.Types.Clear();
            viewModel.Types = selectedTypes;
        }
    }
}