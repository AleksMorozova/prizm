using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public class PipeReportData
    {
        public PipeReportData() { }
        public PipeReportData(DataRow row)
            :this()
        {
            PipeNumber = row.Field<string>("Number");
            Length = row.Field<int>("Length");
            Thickness = row.Field<double>("Thickness");
            Diameter = Convert.ToInt32(row.Field<float>("Diameter")); // diameter in row are float
            SeamType = row.Field<string>("Seam");
            GradeType = row.Field<string>("Grade");
            FirstJointNumber = row.Field<string>("Joint1");
            SecondJointNumber = row.Field<string>("Joint2");
        }

        public string PipeNumber { get; set; }
        public int Length { get; set; }
        public int Diameter { get; set; }
        public double Thickness { get; set; }

        public string SeamType { get; set; }
        public string GradeType { get; set; }
        //public string CertNumber {get; set;}
        //public DateTime? CertDate {get; set;}
        public string FirstJointNumber { get; set; }
        public string SecondJointNumber { get; set; }
    }
}
