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
using Prizm.Domain.Entity;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace Prizm.Main.Controls
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


      //public void ShowOnlyActive
      //{
      //    set
      //    {
      //        gridViewWelders.Columns["colIsActive"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
      //        gridViewWelders.ActiveFilterString = "[colIsActive] = true";
      //    }
      //}


      public IList<Welder> SelectedActiveWelders
      {
          get
          {
              IList<Welder> result = new List<Welder>();
              int[] selected = gridViewWelders.GetSelectedRows();

              foreach (int idx in selected)
              {
                  Welder w = DataSource[gridViewWelders.GetDataSourceRowIndex(idx)] as Welder;
                  if (w.IsActive)
                  {
                      result.Add(w);
                  }
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

      public void ShowActiveWelders() 
      {
          gridViewWelders.ClearColumnsFilter();
          GridColumn columnCountry = gridViewWelders.Columns[3];
          ColumnFilterInfo info = new ColumnFilterInfo("[Active] = 'Checked'");
          gridViewWelders.Columns[3].FilterInfo = info;
          ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(gridViewWelders.Columns[3], info);
          gridViewWelders.ActiveFilter.Add(viewFilterInfo);

      }

      private void gridViewWelders_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
      {

          var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

          var ct = view.DataSource as BindingList<Prizm.Domain.Entity.Welder>;

          if (ct != null)
          {
              if ((bool)ct[e.ListSourceRow].IsActive)
              {
                  e.Visible = false;
                  e.Handled = true;
              }
          }
      }
   }
}
