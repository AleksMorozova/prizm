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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Prizm.Main.Forms.PipeMill.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MillPipeSearchXtraForm : ChildForm
    {
        private MillPipeSearchViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        List<string> localizedSearchResultGroup = new List<string>();

        void UpdateNumberOfFoundItems()
        {
            searchResultLayoutGroup.Text = localizedSearchResultGroup[0];
            searchResultLayoutGroup.Text += ": " + viewModel.Amount;
        }


        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
            pipeNumber.SetAsIdentifier();

            externalCoatingDate.Properties.NullDate = DateTime.MinValue;
            externalCoatingDate.Properties.NullText = string.Empty;
            internalCoatingDate.Properties.NullDate = DateTime.MinValue;
            internalCoatingDate.Properties.NullText = string.Empty;
            weldingDate.Properties.NullDate = DateTime.MinValue;
            weldingDate.Properties.NullText = string.Empty;
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;

            foreach(var s in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(s, true);
            }
            foreach(var item in EnumWrapper<PipeMillStatus>.EnumerateItems(skip0: true))
            {
                pipeMillStatus.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, enabled: true);
            }

            foreach(var item in EnumWrapper<ActivityCriteria>.EnumerateItems())
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
            weldingDate.DataBindings
                .Add("DateTime", MillPipeSearchBindingSource, "WeldingDate");
            externalCoatingDate.DataBindings
                .Add("DateTime", MillPipeSearchBindingSource, "ExternalCoatingDate");
            internalCoatingDate.DataBindings
                .Add("DateTime", MillPipeSearchBindingSource, "InternalCoatingDate");
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            viewModel.SearchCommand.RefreshVisualStateEvent += UpdateNumberOfFoundItems;
        }

        private void MillPipeSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (MillPipeSearchViewModel)Program.Kernel.GetService(typeof(MillPipeSearchViewModel));

            EnumWrapper<PipeMillStatus>.LoadItems(localizedAllPipeMillStatus);

            BindCommands();
            BindToViewModel();

            weldingDate.SetLimits();
            externalCoatingDate.SetLimits();
            internalCoatingDate.SetLimits();
            localizedSearchResultGroup.Add(searchResultLayoutGroup.Text);
        }

        #region --- Localization ---

        // do NOT re-create it because reference passed to localization item. Clean it instead.
        private List<string> localizedAllPipeMillStatus = new List<string>();

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // checked combo boxes
                new LocalizedItem(pipeMillStatus, new string[]
                { 
                    StringResources.SearchPipe_MillStatusProduced.Id, 
                    StringResources.SearchPipe_MillStatusStocked.Id, 
                    StringResources.SearchPipe_MillStatusShipped.Id,
                    StringResources.SearchPipe_ReadyToShip.Id
                }),

                // combo boxes
                new LocalizedItem(pipeActivity, new string[]
                { 
                    StringResources.SearchPipe_ActivityComboActive.Id, 
                    StringResources.SearchPipe_ActivityComboNotActive.Id, 
                    StringResources.SearchPipe_ActivityComboAll.Id }),

                // layout items
                new LocalizedItem(pipeNumberLayout, StringResources.SearchPipe_NumberLabel.Id),
                new LocalizedItem(PipeSizeLayoutControl, StringResources.SearchPipe_TypeSizeLabel.Id),
                new LocalizedItem(pipeMillStatusLayout, StringResources.SearchPipe_StatusLabel.Id),
                new LocalizedItem(pipeActivityLayoutControl, StringResources.SearchPipe_ActivityLabel.Id),
                new LocalizedItem(weldingDateLayout, StringResources.SearchPipe_WeldingDateLabel.Id),
                new LocalizedItem(externalCoatingDateLayout, StringResources.SearchPipe_ExternalCoatingDateLabel.Id),
                new LocalizedItem(internalCoatingDateLayout, StringResources.SearchPipe_InternalCoatingDateLabel.Id),

                // controls
                new LocalizedItem(searchButton, StringResources.SearchPipe_SearchButton.Id),

                // grid column headers
                new LocalizedItem(pipeNumberGridColumn, StringResources.SearchPipe_PipeNumberColumn.Id),
                new LocalizedItem(pipeMillGridColumn, StringResources.SearchPipe_PipeMillColumn.Id),
                new LocalizedItem(pipeTypeSizeGridColumn, StringResources.SearchPipe_PipetypeSizeColumn.Id),
                new LocalizedItem(heatNumberGridColumn, StringResources.SearchPipe_PipeHeatNumberColumn.Id),
                new LocalizedItem(statusSearchGridColumn, StringResources.SearchPipe_PipeStatusColumn.Id),

                // layout control groups
                new LocalizedItem(searchResultLayoutGroup, localizedSearchResultGroup, new string[] 
                                {StringResources.SearchPipe_ResultGroup.Id}, UpdateNumberOfFoundItems),
                new LocalizedItem(searchLayoutGroup, StringResources.SearchPipe_SearchGroup.Id),

                // one-way by-column transformation statuses.
                // See grid's CustomColumnDisplayText for all grid's columns, to understand the connection.
                // one localized item per column. 
                // the same ...CustomColumnDisplayText method must be used for all columns,
                // but private localized list (f.e. localizedAllPipeMillStatus) is different for each column. 
                new LocalizedItem(pipesSearchResultView, localizedAllPipeMillStatus,
                    new string [] { 
                        StringResources.SearchPipe_MillStatusUndefined.Id, 
                        StringResources.SearchPipe_MillStatusProduced.Id, 
                        StringResources.SearchPipe_MillStatusStocked.Id, 
                        StringResources.SearchPipe_MillStatusShipped.Id, 
                        StringResources.SearchPipe_ReadyToShip.Id }),
                // other
                new LocalizedItem(this, localizedHeader, new string[] {StringResources.SearchPipe_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {

                Guid id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.OpenChildForm(DocumentTypes.MillPipe, id);
            }
        }

        private void pipesSearchResultView_DoubleClick(object sender, EventArgs e)
        {
            pipeRepositoryButtonEdit_Click(sender, e);
        }

        private void pipesSearchResultView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pipeRepositoryButtonEdit_Click(sender, e);
            }
        }

        private void pipeSize_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedPipeTypes.Clear();

            for(int i = 0; i < pipeSize.Properties.Items.Count; ++i)
            {
                if(pipeSize.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.CheckedPipeTypes
                        .Add(pipeSize.Properties.Items[i].Value as PipeMillSizeType);
                }
            }
        }

        private void pipeMillStatus_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedStatusTypes.Clear();

            for(int i = 0; i < pipeMillStatus.Properties.Items.Count; i++)
            {
                if(pipeMillStatus.Properties.Items[i].CheckState == CheckState.Checked)
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
            if(data != null)
            {
                if(!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }
            }
        }

        private void pipesSearchResultView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name == statusSearchGridColumn.Name)
            {
                PipeMillStatus result;
                if(Enum.TryParse<PipeMillStatus>((string)e.Value, out result))
                {
                    e.DisplayText = localizedAllPipeMillStatus[(int)result];
                }
            }
        }
    }
}