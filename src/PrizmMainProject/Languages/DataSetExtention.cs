using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    public static class InspectionDataSetExtention
    {
        public static void TranslateStatus<TEnum>(this DataSet data, string tableName, string columnName,
            List<string> localizedStrings)
            where TEnum : struct,  IComparable, IFormattable, IConvertible // http://stackoverflow.com/questions/79126/create-generic-method-constraining-t-to-an-enum 
        {
            foreach (DataRow row in data.Tables[tableName].Rows)
            {
                TEnum result;
                if (Enum.TryParse<TEnum>(row[columnName].ToString(), out result))
                {
                    row[columnName] = localizedStrings[(int)((object)result)-1];
                }
            }
        }
    }
}
