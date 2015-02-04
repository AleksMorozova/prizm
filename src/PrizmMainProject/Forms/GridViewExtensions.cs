using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms
{
   public static class GridViewExtensions
   {
       private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(GridViewExtensions));

      public static void RemoveSelectedItem<T>(this GridView view, System.Windows.Forms.KeyEventArgs e, IList<T> list, Func<T, bool> isNewCondition) where T : class
      {
         if (e.KeyCode == System.Windows.Forms.Keys.Delete && view.IsValidRowHandle(view.FocusedRowHandle))
         {
             object item = view.GetRow(view.FocusedRowHandle);
             if (item != null)
             {
                 if (!(item is T))
                 {
                     var ex = new AggregateException("Incorrect type of object bound to grid.");
                     log.Error(ex.Message);
                     throw ex;
                 }

                 T entity = item as T;
                 if (isNewCondition(entity) && AskDeleteItem())
                 {
                     list.Remove(entity);
                 }
             }
         }
      }

      private static bool AskDeleteItem()
      {
         return MessageBox.Show(
                    Program.LanguageManager.GetString(StringResources.Message_DeleteRecord),
                    Program.LanguageManager.GetString(StringResources.MainWindowHeader_Title), 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == DialogResult.Yes;
      }
   }
}
