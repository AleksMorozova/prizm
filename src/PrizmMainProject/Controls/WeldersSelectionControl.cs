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


      //  public void ShowOnlyActive 
      //{
      //    get
      //    {
      //        gridViewWelders.Columns["IsActive"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
      //        gridViewWelders.ActiveFilterString = "[IsActive] = false";

      //        //IList<Welder> result = new List<Welder>();

      //        //for (int i=0;i < gridViewWelders.DataRowCount;i++ )
      //        //{
      //        //    Welder w = DataSource[gridViewWelders.GetDataSourceRowIndex(i)] as Welder;
      //        //    if (w.IsActive)
      //        //    {
      //        //        result.Add(w);
      //        //    }
      //        //    else 
      //        //    {
      //        //        gridViewWelders.Columns["IsActive"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
      //        //        gridViewWelders.ActiveFilterString = "[IsActive] = false";
      //        //    }
      //        //}

      //       // return result;
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

      public void SelectActiveWelders(IList<Welder> welders)
      {
          gridViewWelders.ClearSelection();

          foreach (Welder w in welders)
          {
              if (w.IsActive)
              {
                  int rowHandle = gridViewWelders.GetRowHandle(DataSource.IndexOf(w));
                  gridViewWelders.SelectRow(rowHandle);
              }
          }
      }

      public void ShowActiveWelders() 
      {

          gridViewWelders.Columns["isActiveGridColumn"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
          gridViewWelders.ActiveFilterString = "[isActiveGridColumn] = true";
      }
   }
}
