using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public static class ComponentryDummy
    {
           private static readonly string[] inspectors = { "Иванов И.И.", "Петров П.В.", "Сидоров Н.Н.", "Овсиенко А.А.", "Иваненко И.И.", "Сорокин Т.В." };
           private static readonly string[] components = { "T-joint", "flange connection", "T-joint", "Connector", "Cross", "Stub" };

        public static List<ComponentDataDemo> GetCmpDummy()
        {
            Random rnd = new Random();

            List<ComponentDataDemo> cmpDataList = new List<ComponentDataDemo>();
            const int NUMBER_OF_COMPONENTS = 4;
            for (int i = 0; i <= NUMBER_OF_COMPONENTS; ++i)
                cmpDataList.Add(new ComponentDataDemo()
                {
                    Number = i.ToString(),
                    Type = components[i],
                    CertificateNumber = (rnd.Next(200) * 1000 + rnd.Next(200)).ToString(),
                    Inspector = inspectors[i],
                    InspectionResult = "Accepted",
                    InspectionDate = "22/11/2016",
                    Tails = new List<Tail>()
                });


            const int UNREACHED_JOINTS_NUMBER_ON_COMPONENT = 5;
            foreach (ComponentDataDemo cd in cmpDataList)
            {
                for (int i = 0; i < rnd.Next(UNREACHED_JOINTS_NUMBER_ON_COMPONENT); ++i )
                {
                    cd.Tails.Add(new Tail() { Diameter = rnd.Next(10).ToString(), Thickness = rnd.Next(3).ToString() });
                }
            }

            return cmpDataList;
        }

        public static void FillComboComponentType(DevExpress.XtraEditors.Controls.ComboBoxItemCollection coll)
        {
            coll.BeginUpdate();
            for (int i = 0; i < components.Length; ++i)
                coll.Add(components[i]);
            coll.EndUpdate();
        }
    }

    public class ComponentDataDemo
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string CertificateNumber { get; set; }
        public string Inspector { get; set; }
        public string InspectionResult { get; set; }
        public string InspectionDate { get; set; }
        public List<Tail> Tails { get; set; }
    }

    public class Tail
    {
        public string Diameter { get; set; }
        public string Thickness { get; set; }
    }
}
