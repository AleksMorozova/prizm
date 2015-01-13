using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Heat")]
   public class HeatObject
   {
      public HeatObject()
      {
      }

      public HeatObject(Heat heat)
      {
         this.Id = heat.Id;
         this.IsActive = heat.IsActive;
         this.Number = heat.Number;
         this.SteelGrade = heat.SteelGrade;
         this.PlateManufacturer = heat.PlateManufacturer;
      }

      public static implicit operator HeatObject(Heat heat)
      {
         return heat != null ? new HeatObject(heat) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("SteelGrade")]
      public string SteelGrade { get; set; }

      [XmlElement("PlateManufacturer")]
      public PlateManufacturerObject PlateManufacturer { get; set; }
   }
}
