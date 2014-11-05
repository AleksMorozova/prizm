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
using PrizmMain.DummyData;
using DevExpress.XtraGrid.Views.Grid;

namespace PrizmMain.Forms
{
    public partial class RailcarNewEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public RailcarNewEditXtraForm()
        {
           
            InitializeComponent();
            railcarNumber.Text = "15";
            certificateNumber.Text = "7635356";
            destination.Text = "Trans Gas LLC";

            shippedDate.Text = "16.10.2014";

            BindingList<PipesDummy> pipeList = new BindingList<PipesDummy>();
            pipeList.Add(new PipesDummy { PipeNumber = 1342352, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634626, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 2141532, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634624, Size = "1100x20", Status = "production" });

            pipesList.DataSource = pipeList;

            pipesNumbers.Items.Add("154262");
            pipesNumbers.Items.Add("262843");
            pipesNumbers.Items.Add("159545");
 
            pipesListView.AddNewRow();
        }

        private void pipesListView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = pipesListView.GetDataRow(e.RowHandle);
            //row["pipeNumberGridColumn"] = 0;
        }


        void SetPosition()
        {
            if (pipesListView.OptionsView.NewItemRowPosition == NewItemRowPosition.Bottom && pipesListView.SortInfo.GroupCount == 0)
            {
                pipesListView.FocusedRowHandle = pipesListView.RowCount - 2;
                pipesListView.MakeRowVisible(pipesListView.FocusedRowHandle, false);
            }
        }

        private void pipesListView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SetPosition();
            pipesListView.AddNewRow();
        }

    }
}