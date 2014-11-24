using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entity;


namespace PrizmMain.Controls
{
    public partial class InspectorSelectionControl : UserControl
    {
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
            inspectorsGridView.ClearSelection();

            foreach (Inspector i in inspectors)
            {
                int rowHandle = inspectorsGridView.GetRowHandle(DataSource.IndexOf(i));
                inspectorsGridView.SelectRow(rowHandle);
            }
        }
    }
}
