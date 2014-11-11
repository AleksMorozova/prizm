using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.Search
{
    public partial class RailcarSearchXtraForm : XtraForm
    {
        private RailcarSearchViewModel viewModel;

        public RailcarSearchXtraForm()
        {
            InitializeComponent();

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
            //railcarNumber.DataBindings.Add("Editvalue", bindingSource, "Number");
            //certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            //destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            //shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
            railcarList.DataSource = viewModel.Railcars;
        }

        private void BindCommands()
        {
            //searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }


        private void railcarListView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                
                string number = (string)view.GetRowCellValue(info.RowHandle, "Number");
                var parent = this.MdiParent as PrizmMain.Forms.MainChildForm.PrizmApplicationXtraForm;
              //  parent.CreateFormChild(new PrizmMain.Forms.Railcar.NewEdit.RailcarNewEditXtraForm(number));
                MessageBox.Show(number);

            }
        }
    }
}