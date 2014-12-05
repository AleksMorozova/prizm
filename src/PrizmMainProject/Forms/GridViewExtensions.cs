using DevExpress.XtraGrid.Views.Grid;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms
{
   public static class GridViewExtensions
   {
      public static void RemoveSelectedItem<T>(this GridView view, System.Windows.Forms.KeyEventArgs e, IList<T> list, Func<T, bool> isNewCondition) where T : class
      {
         if (e.KeyCode == System.Windows.Forms.Keys.Delete && view.IsValidRowHandle(view.FocusedRowHandle))
         {
            object item = view.GetRow(view.FocusedRowHandle);
            if (!(item is T))
               throw new AggregateException("Incorrect type of object bound to grid.");

            T entity = item as T;
            if (isNewCondition(entity) && AskDeleteItem())
            {
               list.Remove(entity);
            }
         }
      }

      private static bool AskDeleteItem()
      {
         return MessageBox.Show(Resources.IDS_QUESTION_DELETE_SELECTED, Resources.PRIZM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
      }
   }
}
