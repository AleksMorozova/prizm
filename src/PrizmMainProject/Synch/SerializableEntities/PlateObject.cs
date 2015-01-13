using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Plate")]
   public class PlateObject
   {
      public PlateObject()
      {
      }

      public PlateObject(Plate plate)
      {
         this.Id = plate.Id;
         this.IsActive = plate.IsActive;
         this.Number = plate.Number;
         this.Thickness = plate.Thickness;
         this.Heat = plate.Heat;
      }

      public static implicit operator PlateObject(Plate plate)
      {
         return plate != null ? new PlateObject(plate) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("Thickness")]
      public float Thickness { get; set; }

      [XmlElement("Heat")]
      public HeatObject Heat { get; set; }
   }
}
