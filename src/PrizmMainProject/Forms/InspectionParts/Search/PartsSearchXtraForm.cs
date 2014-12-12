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
using DevExpress.XtraGrid.Views.Grid;
using PrizmMain.Common;
using PrizmMain.Forms.Component.NewEdit;
using Ninject.Parameters;

namespace PrizmMain.Forms.InspectionParts.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
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

            var pipeCheck = new EnumWrapper<PartType> { Value = PartType.Pipe };
            var spoolCheck = new EnumWrapper<PartType> { Value = PartType.Spool };
            var componentCheck = new EnumWrapper<PartType> { Value = PartType.Component };

            type.Properties.Items.Add(pipeCheck.Value, pipeCheck.Text,CheckState.Checked,true);
            type.Properties.Items.Add(spoolCheck.Value, spoolCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(componentCheck.Value, componentCheck.Text, CheckState.Checked, true);
            RefreshTypes();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
            number.DataBindings.Add("Editvalue", bindingSource, "Number");
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

        private void partsView_DoubleClick(object sender, EventArgs e)
        {
            int selectedPart = partsView.GetFocusedDataSourceRowIndex();

            var parent = this.MdiParent as PrizmApplicationXtraForm;

            if (viewModel.Parts[selectedPart].Type.Value == PartType.Component)
            {
                parent.CreateChildForm(
                        typeof(ComponentNewEditXtraForm),
                        new ConstructorArgument(
                            "componentId",
                            viewModel.Parts[selectedPart].Id));
            }
            else if (viewModel.Parts[selectedPart].Type.Value == PartType.Pipe)
            {
            }
            else if (viewModel.Parts[selectedPart].Type.Value == PartType.Spool)
            {
            }
        }

        private void partsView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsView_DoubleClick(sender, e);
            }
        }
    }
}