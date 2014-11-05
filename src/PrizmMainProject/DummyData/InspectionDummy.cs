using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class InspectionDummy
    {
        public BindingList<Inspection> GetDummyInspection()
        {
            var inspections = new BindingList<Inspection> 
            {
                new Inspection{Code="1", Name="Приемка листа по сертификатам ", TestSubject="Идентификация листаПроверка на соответствие  НД", ControlType="Визуальный контроль", ResultType="да/нет",  BollExpected=true, IsRequired=true,  InspectionResults="пройдено", Inspectors="Иванов", Measurements="true", ControlDate= "04.11.2014",ExpectedResult="true" },
                new Inspection{Code="2", Name="Приемка сварочного флюса по сертификатам", TestSubject="Проверка на соответствие  НД", ControlType="Визуальный контроль", ResultType="да/нет",  BollExpected=true, IsRequired=true, InspectionResults="пройдено", Inspectors="Иванов", Measurements="true", ControlDate= "04.11.2014" ,ExpectedResult="true"},
                new Inspection{Code="3", Name="Приварка планок", TestSubject="Приварка планок, ремонт технологического шва", ControlType="Визуальный контроль", ResultType="Диапазон", MinExpected=100, MaxExpected=200,  IsRequired=false, InspectionResults="пройдено", Inspectors="Иванов", Measurements="150", ControlDate= "04.11.2014",ExpectedResult="100-200" },
                new Inspection{Code="4", Name="Гидростатическое испытание ", TestSubject="Время выдержки под давлением", ControlType="Проверка по документам", ResultType="Диапазон", MinExpected=100, MaxExpected=200,  IsRequired=true, InspectionResults="ремонт", Inspectors="Иванов", Measurements="85", ControlDate= "04.11.2014", ExpectedResult="100-200"}
            };
            return inspections;
        }

    }


    public class Inspection 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string TestSubject { get; set; }
        public string ControlType { get; set; }
        public string ResultType { get; set; }
        public int MinExpected { get; set; }
        public int MaxExpected { get; set; }
        public bool BollExpected { get; set; }
        public bool IsRequired { get; set; }

        public string Measurements { get; set; }
        public string InspectionResults { get; set; }
        public string Inspectors { get; set; }
        public string ControlDate { get; set; }
        public string ExpectedResult{ get; set; }
    }
}
