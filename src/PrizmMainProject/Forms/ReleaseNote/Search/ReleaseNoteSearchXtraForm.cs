using System;
using System.ComponentModel;

using Ninject;
using Ninject.Parameters;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using System.Windows.Forms;

using Prizm.Main.Forms.ReleaseNote.NewEdit;
using Prizm.Main.Forms.MainChildForm;

using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Languages;
using System.Collections.Generic;
using Prizm.Main.Properties;
using System.Drawing;


namespace Prizm.Main.Forms.ReleaseNote.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ReleaseNoteSearchXtraForm : ChildForm
    {
        List<string> localizedSearchResultGroup = new List<string>();

        void UpdateNumberOfFoundItems()
        {
            resultParametersLayoutGroup.Text = localizedSearchResultGroup[0];
            resultParametersLayoutGroup.Text += ": " + viewModel.Amount;
        }
        private ICommandManager commandManager = new CommandManager();
        private ReleaseNoteSearchViewModel viewModel;
        private List<string> localizedAllShipStatus = new List<string>() { "unshipped", "shipped" };
        public ReleaseNoteSearchXtraForm()
        {
            InitializeComponent();
            startDate.Properties.NullDate = DateTime.MinValue;
            startDate.Properties.NullText = string.Empty;
            endDate.Properties.NullDate = DateTime.MinValue;
            endDate.Properties.NullText = string.Empty;
            this.certificateNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
        }

        private void RailcarSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (ReleaseNoteSearchViewModel)Program.Kernel.GetService(typeof(ReleaseNoteSearchViewModel));
            BindCommands();
            BindToViewModel();

            startDate.SetLimits();
            endDate.SetLimits();

            if (localizedSearchResultGroup.Count == 0)
            {
                localizedSearchResultGroup.Add(resultParametersLayoutGroup.Text);
            }
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "RailcarNumber");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Receiver");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "ReleaseNoteNumber");
            startDate.DataBindings.Add("EditValue", bindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", bindingSource, "EndDate");
            pipeNumber.DataBindings.Add("EditValue", bindingSource, "PipeNumber");
            //releasesGrid.DataSource = viewModel.Projection;
            releasesGrid.DataBindings.Add("DataSource", bindingSource, "Projection");

        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            viewModel.SearchCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.SearchCommand.RefreshVisualStateEvent += UpdateNumberOfFoundItems;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releaseNoteNumberayout, StringResources.ReleaseSearch_NumberLabel.Id),
                new LocalizedItem(startDateLayout, StringResources.ReleaseSearch_StartDateLabel.Id),
                new LocalizedItem(endDateLayout, StringResources.ReleaseSearch_EndDateLabel.Id),
                new LocalizedItem(destinationLayout, StringResources.ReleaseSearch_DestinationLabel.Id),
                new LocalizedItem(railcarNumberLayout, StringResources.ReleaseSearch_RailcarLabel.Id),
                new LocalizedItem(certificateNumberLayout, StringResources.ReleaseSearch_CertificateLabel.Id),
                new LocalizedItem(pipeNumberLayout, StringResources.ReleaseSearch_PipeInReleaseNoteLabel.Id),
                //pipeNumberLayout
                // controls
                new LocalizedItem(searchButton, StringResources.NewEditPipe_SearchButton.Id),

                // grid column headers
                new LocalizedItem(releaseNoteNumberGridColumn, StringResources.ReleaseSearch_ReleaseNumberColumnHeader.Id),
                new LocalizedItem(releaseNoteDateGridColumn, StringResources.ReleaseSearch_ReleaseDateColumnHeader.Id),
                new LocalizedItem(statusColumn, StringResources.ReleaseSearch_ReleaseStatusColumnHeader.Id),

                // layout control groups
                new LocalizedItem(searchParametersLayoutGroup, StringResources.ReleaseSearch_SearchGroup.Id),
                new LocalizedItem(resultParametersLayoutGroup, localizedSearchResultGroup, new string[] 
                                {StringResources.ReleaseSearch_ResultGroup.Id}, UpdateNumberOfFoundItems),

                new LocalizedItem( railcarListView, localizedAllShipStatus,
                        new string [] {StringResources.ReleaseNoteNewEdit_PendingStatus.Id, StringResources.ReleaseNoteNewEdit_ShippedStatus.Id }),

                // other
                new LocalizedItem(this, localizedHeader, new string[] {StringResources.ReleaseSearch_Title.Id} )
            };
        }


        #endregion // --- Localization ---

        private void railcarListView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if(info.InRow || info.InRowCell)
            {

                Guid id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                FormManager.Instance.OpenChildForm(DocumentTypes.MillReleaseNote, id);
            }
        }

        private void railcarListView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                railcarListView_DoubleClick(sender, e);
            }
        }

        private void RailcarSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            if(viewModel != null)
            {
                viewModel.Dispose();
                viewModel = null;
            }
        }

        private void railcarListView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == statusColumn.Name)
            {
                {
                    e.DisplayText = ((bool)e.Value) ? localizedAllShipStatus[1].ToString() : localizedAllShipStatus[0].ToString();
                    
                }
            }
        }


    }
}