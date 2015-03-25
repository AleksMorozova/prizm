using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prizm.Domain.Entity;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Domain.Entity.Setup;


namespace Prizm.Main.Controls
{
    public partial class InspectorSelectionControl : UserControl
    {
        private bool checkNotActiveSelection = true;
        public DateTime? inspectionDate = DateTime.Now.Date;

        public InspectorSelectionControl()
        {
            InitializeComponent();
        }

        public BindingSource DataSource
        {
            get
            {
                return inspectorsGridControl.DataSource as BindingSource;
            }
            set
            {
                inspectorsGridControl.DataSource = value;
            }
        }

        
        public DateTime? InspectionDate
        {
            get 
            { 
                return inspectionDate; 
            }
            set 
            { 
                inspectionDate=value;
                inspectorsGridView.LayoutChanged();
                inspectorsGridControl.Refresh();
            }
        }

        public IList<Inspector> SelectedInspectors
        {
            get
            {
                IList<Inspector> result = new List<Inspector>();
                int[] selected = inspectorsGridView.GetSelectedRows();

                foreach (int idx in selected)
                {
                    Inspector i = DataSource[inspectorsGridView.GetDataSourceRowIndex(idx)] as Inspector;
                    result.Add(i);
                }
                return result;
            }
        }

        public void ClearSelection()
        {
            inspectorsGridView.ClearSelection();
        }

        public void SelectInspectors(IList<Inspector> inspectors)
        {
            this.checkNotActiveSelection = false;
            inspectorsGridView.ClearSelection();

            foreach (Inspector i in inspectors)
            {
                int rowHandle = inspectorsGridView.GetRowHandle(DataSource.IndexOf(i));
                inspectorsGridView.SelectRow(rowHandle);
            }
            this.checkNotActiveSelection = true;
        }

        private void inspectorsGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (this.checkNotActiveSelection)
            {
                GridView v = sender as GridView;
                int t = v.SelectedRowsCount;
                if (t == v.DataRowCount)
                {
                    for (int i = 0; i < v.SelectedRowsCount; i++)
                    {
                        var data = v.GetRow(i) as Inspector;
                        if (!data.IsActive)
                        {
                            v.UnselectRow(i);
                        }
                    }
                }
                else
                {
                    var data = v.GetRow(e.ControllerRow) as Inspector;
                    if (data != null && !data.IsActive)
                    {
                        v.UnselectRow(e.ControllerRow);
                    }
                }
            }
        }

        public void inspectorsGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Inspector;
            if (data != null)
            {
                if (!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }

                foreach (InspectorCertificate c in data.Certificates) 
                {
                    if (c.Certificate.ExpirationDate < inspectionDate && data.IsActive)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
