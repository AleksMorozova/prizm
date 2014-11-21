using System;
using System.ComponentModel;

namespace PrizmMain.DummyData
{
    public class JointsDummy
    {
        public static BindingList<Joint> GetAllJoints()
        {
            return new BindingList<Joint>
            {
                new Joint
                {
                    Id = 234,
                    Status = "Контроль",
                    ControlState = "Принято",
                    WeldingDate = DateTime.Today,
                    ControlDate = DateTime.Today
                },
                new Joint
                {
                    Id = 231,
                    Status = "Ремонт",
                    ControlState = "Принято",
                    WeldingDate = DateTime.Today,
                    ControlDate = DateTime.Today
                },
                new Joint
                {
                    Id = 245,
                    Status = "Ремонт",
                    ControlState = "Принято",
                    WeldingDate = DateTime.Today,
                    ControlDate = DateTime.Today
                }
            };
        }

        public static BindingList<ControlType> GetAllControlTypes()
        {
            return new BindingList<ControlType>
            {
                new ControlType {Type = "Вырезка стыка"},
                new ControlType {Type = "Сварка стыка"},
            };
        }
    }

    public class Joint
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string ControlState { get; set; }
        public DateTime WeldingDate { get; set; }
        public string Repair { get; set; }
        public DateTime ControlDate { get; set; }
    }

    public class ControlType
    {
        public string Type { get; set; }
    }
}