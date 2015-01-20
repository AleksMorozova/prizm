using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public class WeldDateReportData
    {
        public WeldDateReportData() { }
        public WeldDateReportData(DataRow row)
            :this()
        {
            //Date = row.Field<DateTime>("Date");
            JointNumber = row.Field<string>("JointNumber");
            //FipstPartNumber = row.Field<string>("FipstPartNumber");
            //SecondPartNumber = row.Field<string>("SecondPartNumber");
            //FipstPartLength = row.Field<int>("FipstPartLength");
            //SecondPartLength = row.Field<int>("SecondPartLength");
        }

        public DateTime? Date { get; set; }
        public string JointNumber { get; set; }
        public string FipstPartNumber { get; set; }
        public string SecondPartNumber { get; set; }
        public int FipstPartLength { get; set; }
        public int SecondPartLength { get; set; }

        /*
        • NDT date – дата проведения НК (неразрушающий контроль)
        • NDT result - результат проведения НК 
        • NDT after repair - результат проведения НК после ремонта стыка
        • Insulation date – дата изоляции стыка
        */
    }
}
