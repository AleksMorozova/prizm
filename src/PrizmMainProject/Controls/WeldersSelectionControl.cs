using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Domain.Entity;

namespace PrizmMain.Controls
{
   public partial class WeldersSelectionControl : UserControl
   {
      public WeldersSelectionControl()
      {
         InitializeComponent();
      }

      public BindingSource DataSource
      {
         get
         {
            return gridControlWelders.DataSource as BindingSource;
         }
         set
         {
            gridControlWelders.DataSource = value;
         }
      }

      public IList<Welder> SelectedWelders
      {
         get
         {
            IList<Welder> result = new List<Welder>();
            int[] selected = gridViewWelders.GetSelectedRows();

            foreach (int idx in selected)
            {
               Welder w = DataSource[gridViewWelders.GetDataSourceRowIndex(idx)] as Welder;
               result.Add(w);
            }

            return result;
         }
      }

      public void ClearSelection()
      {
         gridViewWelders.ClearSelection();
      }

      public void SelectWelders(IList<Welder> welders)
      {
         gridViewWelders.ClearSelection();

         foreach (Welder w in welders)
         {
            int rowHandle = gridViewWelders.GetRowHandle(DataSource.IndexOf(w));
            gridViewWelders.SelectRow(rowHandle);
         }
      }

   }
}
