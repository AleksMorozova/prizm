using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Dev
{
    public class DummyData
    {
        // SeetingsExtraForm ControlOperationTab Grid
        public static DataTable CreateControlOperationTable()
        {
            //table
            DataTable table = new DataTable("Data");

            //columns
            table.Columns.Add("Id", typeof (Int32));
            table.Columns.Add("Stage", typeof (String));
            table.Columns.Add("Object", typeof (String));
            table.Columns.Add("Frequency", typeof (String));
            table.Columns.Add("Document", typeof (String));
            table.Columns.Add("Sertification", typeof (String));
            table.Columns.Add("InspectionPlant", typeof (String));
            table.Columns.Add("InspectionCustomer", typeof (String));
            table.Columns.Add("InspectionOther", typeof (String));

            table.Rows.Add(new object[]
            {
                1, "Сварка внутренних швов", "Параметры сварки", "Каждая труба",
                "MPS-AGP(c X-BO-E-PL-SIP-0007-000-0 M WPS DUMMY DATA)", "R,C", "WP", "", "R,M R,M R,M R,M R,M R,M R,M R,M R,M "
            });
            table.Rows.Add(new object[]
            {
                2, "Сварка внутренних швов", "Параметры сварки", "Каждая труба",
                "MPS-AGP(c X-BO-E-PL-SIP-0007-000-0 M WPS DUMMY DATA)", "R", "X,WP", "X", "R,M"
            });
            table.Rows.Add(new object[]
            {
                3, "Сварка внутренних швов", "Параметры сварки", "Каждая труба",
                "MPS-AGP(c X-BO-E-PL-SIP-0007-000-0 M WPS DUMMY DATA)", "R", "WP", "", "R,M"
            });
            table.Rows.Add(new object[]
            {
                4, "Сварка внутренних швов", "Параметры сварки", "Каждая труба",
                "MPS-AGP(c X-BO-E-PL-SIP-0007-000-0 M WPS DUMMY DATA)", "R,C", "X,WP", "", "R,M"
            });
            table.Rows.Add(new object[]
            {
                99999, "Сварка внутренних швов", "Параметры сварки", "Каждая труба",
                "MPS-AGP(c X-BO-E-PL-SIP-0007-000-0 M WPS DUMMY DATA)", "R,C", "X", "WP", "R,M"
            });

            return table;
        }
    }
}
