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
using Prizm.Main.Forms.Common;
using Prizm.Main.Properties;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Common;
using Prizm.Main.Forms.Component.NewEdit;
using Ninject.Parameters;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Spool;

namespace Prizm.Main.Forms.Parts.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PartSearchXtraForm : ChildForm
    {
        private PartSearchViewModel viewModel;
        ICommandManager commandManager = new CommandManager();

        public PartSearchXtraForm()
        {
            InitializeComponent();
        }

        private void PartsSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartSearchViewModel)Program.Kernel.GetService(typeof(PartSearchViewModel));
            BindCommands();
            BindToViewModel();

            var pipeCheck = new EnumWrapper<PartType> { Value = PartType.Pipe };
            var spoolCheck = new EnumWrapper<PartType> { Value = PartType.Spool };
            var componentCheck = new EnumWrapper<PartType> { Value = PartType.Component };

            type.Properties.Items.Add(pipeCheck.Value, pipeCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(spoolCheck.Value, spoolCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(componentCheck.Value, componentCheck.Text, CheckState.Checked, true);
            RefreshTypes();
            activity.SelectedIndex = 1;
            viewModel.Activity = activity.SelectedItem.ToString(); 
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
            number.DataBindings.Add("Editvalue", bindingSource, "Number");
            activity.DataBindings.Add("EditValue", bindingSource, "Activity");
            activity.Properties.Items.AddRange(viewModel.ActivityArray);
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void type_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            RefreshTypes();
        }

        private void RefreshTypes()
        {
            BindingList<PartType> selectedTypes = new BindingList<PartType>();
            for (int i = 0; i < type.Properties.Items.Count; i++)
            {
                if (type.Properties.Items[i].CheckState == CheckState.Checked)
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
            if (selectedPart >= 0)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                switch (viewModel.Parts[selectedPart].Type.Value)
                {
                    case PartType.Component:
                        {
                            parent.CreateChildForm(
                                typeof(ComponentNewEditXtraForm),
                                new ConstructorArgument(
                                    "id",
                                    viewModel.Parts[selectedPart].Id), 
                                new ConstructorArgument (
                                    "number", 
                                    viewModel.Parts[selectedPart].Number)
                                                   );
                        } break;
                    case PartType.Pipe:
                        {
                            parent.CreateChildForm
                                (typeof(MillPipeNewEditXtraForm),
                                new ConstructorArgument("id",
                                viewModel.Parts[selectedPart].Id));
                        } break;
                    case PartType.Spool:
                        {
                            parent.CreateChildForm(
                                typeof(SpoolsXtraForm),
                                new ConstructorArgument("id",
                                    viewModel.Parts[selectedPart].Id)
                                );
                        } break;
                    default: break;
                }
            }
        }

        private void partsView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsView_DoubleClick(sender, e);
            }
        }

        private void PartSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void partsView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Part;
            if (data != null)
            {
                if (!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }
            }
        }
    }
}