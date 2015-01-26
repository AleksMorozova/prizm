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
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using Prizm.Main.Languages;

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
            foreach (var item in EnumWrapper<PipeMillStatus>.EnumerateItems(skip0 : true))
            {
                pipeMillStatus.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, enabled: true);
            }

            foreach (var item in EnumWrapper<ActivityCriteria>.EnumerateItems())
            {
                pipeActivity.Properties.Items.Add(item.Item2);
            }
            viewModel.Activity = ActivityCriteria.StatusActive;

 
            pipesSearchResult.DataBindings
                .Add("DataSource", MillPipeSearchBindingSource, "Pipes");
            pipeNumber.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");
            pipeActivity.DataBindings
                .Add("SelectedIndex", MillPipeSearchBindingSource, "ActivityIndex");
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

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // checked combo boxes
                new LocalizedItem(pipeMillStatus, new string[]{ "SearchPipe_MillStatusProduced", "SearchPipe_MillStatusStocked", "SearchPipe_MillStatusShipped" }),

                // combo boxes
                new LocalizedItem(pipeActivity, new string[]{ "SearchPipe_ActivityComboActive", "SearchPipe_ActivityComboNotActive", "SearchPipe_ActivityComboAll" }),

                // readonly grid cell
                new LocalizedItem(pipeActivity, new string[]{ "SearchPipe_MillStatusUndefined", "SearchPipe_MillStatusProduced", 
                                                              "SearchPipe_MillStatusStocked", "SearchPipe_MillStatusShipped" }),

                // other
            };
        }

        #endregion // --- Localization ---

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {
            int selectedPipe = pipesSearchResultView.GetFocusedDataSourceRowIndex();
            var id = viewModel.Pipes[selectedPipe].Id;
            if (selectedPipe >= 0)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;

                parent.OpenChildForm(typeof(MillPipeNewEditXtraForm), id);
            }
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
                    viewModel.CheckedStatusTypes.Add((PipeMillStatus)pipeMillStatus.Properties.Items[i].Value);
                }
            }
        }

        private void MillPipeSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void pipesSearchResultView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Pipe;
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