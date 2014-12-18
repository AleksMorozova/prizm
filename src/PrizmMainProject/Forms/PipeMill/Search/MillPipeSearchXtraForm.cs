using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Ninject.Parameters;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prizm.Main.Forms.PipeMill.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class MillPipeSearchXtraForm : ChildForm
    {
        private MillPipeSearchViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();
        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
            pipeNumber.SetAsIdentifier();
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;

            foreach (var s in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(s,true);
            }
            foreach (var s in viewModel.StatusTypes)
            {
                pipeMillStatus.Properties.Items.Add(s,true);
            }
            pipeActivity.Properties.Items.AddRange(viewModel.ActivityArray);

            pipesSearchResult.DataBindings
                .Add("DataSource", MillPipeSearchBindingSource, "Pipes");
            pipeNumber.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");
            pipeActivity.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "Activity");


        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void MillPipeSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (MillPipeSearchViewModel)Program.Kernel.GetService(typeof(MillPipeSearchViewModel));

            BindCommands();
            BindToViewModel();
        }

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {
            int selectedPipe = pipesSearchResultView.GetFocusedDataSourceRowIndex();

            var parent = this.MdiParent as PrizmApplicationXtraForm;

            parent.CreateChildForm(
                    typeof(MillPipeNewEditXtraForm),
                    new ConstructorArgument(
                        "pipeId",
                        viewModel.Pipes[selectedPipe].Id));
        }

        private void pipesSearchResultView_DoubleClick(object sender, EventArgs e)
        {
            pipeRepositoryButtonEdit_Click(sender, e);
        }

        private void pipesSearchResultView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pipeRepositoryButtonEdit_Click(sender, e);
            }
        }

        private void pipeSize_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedPipeTypes.Clear();

            for(int i = 0; i < pipeSize.Properties.Items.Count; ++i)
            {
                if (pipeSize.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.CheckedPipeTypes
                        .Add(pipeSize.Properties.Items[i].Value as PipeMillSizeType);
                }
            }
        }

        private void pipeMillStatus_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedStatusTypes.Clear();

            for (int i = 0; i < pipeMillStatus.Properties.Items.Count; i++)
            {
                if (pipeMillStatus.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.CheckedStatusTypes.Add(pipeMillStatus.Properties.Items[i].Value as EnumWrapper<PipeMillStatus>);
                }
            }
        }

        private void MillPipeSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }
    }
}