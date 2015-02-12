using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Controls
{
    public static class GridViewValidation
    {
         public static void ValidateNotEmpty (this GridView view, GridColumn NameColumn, ValidateRowEventArgs e)
        {

            string Name = (string)view.GetRowCellValue(e.RowHandle, NameColumn);
           
            view.ClearColumnErrors();

            if (String.IsNullOrEmpty(Name))
            {
                view.SetColumnError(NameColumn,
                   Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                e.Valid = false;
            }

        }

         public static void ColorGrid(this GridView view, GridColumn NameColumn, List<string> duplicates, RowCellStyleEventArgs e)
         {
             if (e.Column.ToString() == NameColumn.Caption)
             {
                 if (duplicates.Count > 0)
                 {
                     for (int i = 0; i < 2; i++)
                     {
                         foreach (var item in duplicates)
                         {
                             if ((e.CellValue != null) && (item == e.CellValue.ToString()))
                             {
                                 e.Appearance.ForeColor = Color.Red;
                             }
                         }
                     }
                     
                 }
             }
         }

         public static void ValidateDuplicate(this GridView view, GridColumn NameColumn, List<string> duplicates, ValidateRowEventArgs e)
         {
             view.ClearColumnErrors();
             if (duplicates.Count > 0)
             {
                 view.SetColumnError(NameColumn,

                     Program.LanguageManager.GetString(StringResources.Settings_UniqueValueRequired));
                 e.Valid = false;
             }

         }
    }
}
