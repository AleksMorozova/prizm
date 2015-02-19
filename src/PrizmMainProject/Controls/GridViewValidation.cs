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
        public static void ValidateNotEmpty(this GridView view, GridColumn NameColumn, ValidateRowEventArgs e)
        {
            string Name = (string)view.GetRowCellValue(e.RowHandle, NameColumn);

            if (String.IsNullOrEmpty(Name))
            {
                view.SetColumnError(NameColumn,
                   Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                e.Valid = false;
            }

        }
        
        public static void ValidatePersonName(this GridView view, GridColumn firstNameColumn, GridColumn lastNameColumn, ValidateRowEventArgs e)
        {
            string firstName = (string)view.GetRowCellValue(e.RowHandle, firstNameColumn);
            string lastName = (string)view.GetRowCellValue(e.RowHandle, lastNameColumn);

            view.ClearColumnErrors();

            if (String.IsNullOrEmpty(firstName))
            {
                view.SetColumnError(firstNameColumn,
                    Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                e.Valid = false;
            }

            if (String.IsNullOrEmpty(lastName))
            {
                view.SetColumnError(lastNameColumn,
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

        public static void ValidateDuplicate(this GridView view, GridColumn NameColumn, List<string> duplicates, ValidateRowEventArgs e)
        {
            if (duplicates.Count > 0)
            {
                view.SetColumnError(NameColumn,
                    Program.LanguageManager.GetString(StringResources.Settings_UniqueValueRequired));
                e.Valid = false;
            }

        }
    }
}
