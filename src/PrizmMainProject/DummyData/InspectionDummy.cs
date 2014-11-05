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
                new Inspection{Code="", Name="Приемка листа по сертификатам ", TestSubject="Идентификация листаПроверка на соответствие  НД", ControlType="Визуальный контроль", ResultType="bool",  BollExpected=true, IsRequired=true },
                new Inspection{Code="", Name="Приемка сварочного флюса по сертификатам", TestSubject="Проверка на соответствие  НД", ControlType="Визуальный контроль", ResultType="",  BollExpected=true, IsRequired=true },
                new Inspection{Code="", Name="Приварка планок", TestSubject="Приварка планок, ремонт технологического шва", ControlType="Визуальный контроль", ResultType="", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=false },
                //new Inspection{Code="", Name="", TestSubject="", ControlType="", ResultType="", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=true },
                //new Inspection{Code="", Name="", TestSubject="", ControlType="", ResultType="", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=true },
                //new Inspection{Code="", Name="", TestSubject="", ControlType="", ResultType="", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=true },
                //new Inspection{Code="", Name="", TestSubject="", ControlType="", ResultType="", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=true },
                new Inspection{Code="", Name="Гидростатическое испытание ", TestSubject="Время выдержки под давлением", ControlType="Проверка по документам", ResultType="Диапазон", MinExpected=100, MaxExpected=200, BollExpected=true, IsRequired=true }
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
    }
}
