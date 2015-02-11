using System;
using System.ComponentModel;

using Ninject;
using Ninject.Parameters;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using System.Windows.Forms;

using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.MainChildForm;

using Prizm.Main.DummyData;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Languages;
using System.Collections.Generic;
using Prizm.Main.Properties;
using System.Drawing;


namespace Prizm.Main.Forms.Railcar.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class RailcarSearchXtraForm : ChildForm
    {
        private ICommandManager commandManager = new CommandManager();
        private RailcarSearchViewModel viewModel;

        public RailcarSearchXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.search_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            releaseNoteDate.Properties.NullDate = DateTime.MinValue;
            releaseNoteDate.Properties.NullText = string.Empty;
            this.certificateNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
        }

        private void RailcarSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (RailcarSearchViewModel)Program.Kernel.GetService(typeof(RailcarSearchViewModel));
            BindCommands();
            BindToViewModel();

            releaseNoteDate.SetLimits();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "RailcarNumber");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Receiver");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "ReleaseNoteNumber");
            releaseNoteDate.DataBindings.Add("EditValue", bindingSource, "ReleaseNoteDate");
            //releasesGrid.DataSource = viewModel.Projection;
            releasesGrid.DataBindings.Add("DataSource", bindingSource, "Projection");

        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            viewModel.SearchCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releaseNoteNumberayout, StringResources.ReleaseSearch_NumberLabel.Id),
                new LocalizedItem(releaseNoteDateLayout, StringResources.ReleaseSearch_DateLabel.Id),
                new LocalizedItem(destinationLayout, StringResources.ReleaseSearch_DestinationLabel.Id),
                new LocalizedItem(railcarNumberLayout, StringResources.ReleaseSearch_RailcarLabel.Id),
                new LocalizedItem(certificateNumberLayout, StringResources.ReleaseSearch_CertificateLabel.Id),

                // controls
                new LocalizedItem(searchButton, StringResources.NewEditPipe_SearchButton.Id),

                // grid column headers
                new LocalizedItem(releaseNoteNumberGridColumn, StringResources.ReleaseSearch_ReleaseNumberColumnHeader.Id),
                new LocalizedItem(releaseNoteDateGridColumn, StringResources.ReleaseSearch_ReleaseDateColumnHeader.Id),
                new LocalizedItem(number, StringResources.ReleaseSearch_RailcarNumberColumnHeader.Id),
                new LocalizedItem(dest, StringResources.ReleaseSearch_DestinationColumnHeader.Id),
                new LocalizedItem(certificate, StringResources.ReleaseSearch_CertificateColumnHeader.Id),
                new LocalizedItem(statusColumn, StringResources.ReleaseSearch_RailcarNumberColumnHeader.Id),

                // layout control groups
                new LocalizedItem(searchParametersLayoutGroup, StringResources.ReleaseSearch_SearchGroup.Id),
                new LocalizedItem(resultParametersLayoutGroup, StringResources.ReleaseSearch_ResultGroup.Id)

                // other
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
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.OpenChildForm(typeof(RailcarNewEditXtraForm), id);
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
    }
}