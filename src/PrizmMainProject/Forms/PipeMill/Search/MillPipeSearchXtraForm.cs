using Domain.Entity.Mill;
using Domain.Entity.Setup;
using Ninject.Parameters;
using PrizmMain.Common;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrizmMain.Forms.PipeMill.Search
{
    public partial class MillPipeSearchXtraForm : ChildForm
    {
        private MillPipeSearchViewModel viewModel;
        private Dictionary<PipeMillStatus, string> statusTypeDict 
            = new Dictionary<PipeMillStatus, string>();

        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
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
            //pipeMillStatus.DataBindings
             //   .Add("EditValue", MillPipeSearchBindingSource, "PipeMillStatus");  
            pipeActivity.DataBindings.Add("EditValue", MillPipeSearchBindingSource, "Activity");

            statusTypeDict.Clear();
            statusTypeDict.Add(PipeMillStatus.Produced, Resources.Produced);
            statusTypeDict.Add(PipeMillStatus.Shipped, Resources.Shipped);
            statusTypeDict.Add(PipeMillStatus.Stocked, Resources.Stocked);
            repositoryLookUpEditStatus.DataSource = statusTypeDict;


        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
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

        private void repositoryLookUpEditStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            try
            {
                if (e.Value is PipeMillStatus)
                {
                    e.DisplayText = statusTypeDict[(PipeMillStatus)e.Value];
                }
            }
            catch (KeyNotFoundException exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
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
    }
}