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
            shippedDate.Properties.NullDate = DateTime.MinValue;
            shippedDate.Properties.NullText = string.Empty;
            this.certificateNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();
        }

        private void RailcarSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (RailcarSearchViewModel)Program.Kernel.GetService(typeof(RailcarSearchViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("Editvalue", bindingSource, "RailcarNumber");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Receiver");
            shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
            railcarList.DataBindings.Add("DataSource", bindingSource, "Railcars");
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void railcarListView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {

                Guid id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.CreateChildForm(typeof(RailcarNewEditXtraForm), new ConstructorArgument("id", id));
            }
        }

        private void railcarListView_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "ShippingButton")
            {
                return;
            }
            GridView gv = sender as GridView;
            var tmp = (bool)gv.GetRowCellValue(e.RowHandle, "IsShipped");
            if (tmp)
            {
                e.RepositoryItem = unshipGridButton;
            }
            else
            {
                e.RepositoryItem = shipGridButton;
            }
        }

        private void shipGridButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ship");
        }

        private void unshipGridButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unship");
        }

        private void railcarListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                railcarListView_DoubleClick(sender, e);
            }
        }

        private void RailcarSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

    }
}