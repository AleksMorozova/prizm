using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public static class ComponentryDummy
    {
           public static string componentNumber = "11-22-33";
           public static string certificate = "certificate - 1";

        public class ComponentDataDemo
        {
            public string Number { get; set; }
            public string Type { get; set; }
            public string CertificateNumber { get; set; }
            public string Inspector { get; set; }
            public string InspectionResult { get; set; }
            public string InspectionDate { get; set; }
        }

        public static IList<ComponentDataDemo> GetCmpDummy()
        {
            IList<ComponentDataDemo> cmpDataList = new List<ComponentDataDemo>();
            for (int i = 0; i < 5; ++i )
                cmpDataList.Add(new ComponentDataDemo()
                {
                    Number = i.ToString(),
                    Type = "Type - " + i.ToString(),
                    CertificateNumber = i.ToString() + " - " + i.ToString(),
                    Inspector = i.ToString(),
                    InspectionResult = "Accepted",
                    InspectionDate = "22/11/2016"
                });
            return cmpDataList;
        }

        public static void FillComboComponentType(DevExpress.XtraEditors.Controls.ComboBoxItemCollection coll)
        {
            coll.BeginUpdate();
            for (int i = 0; i < 5; ++i)
                coll.Add("Type - Valve - " + i.ToString());
            coll.EndUpdate();
        }
    }
}
