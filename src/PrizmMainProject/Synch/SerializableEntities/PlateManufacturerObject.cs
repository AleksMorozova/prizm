using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("PlateManufacturer")]
   public class PlateManufacturerObject
   {
      public PlateManufacturerObject()
      {
      }

      public PlateManufacturerObject(PlateManufacturer manufacturer)
      {
         this.Id = manufacturer.Id;
         this.Name = manufacturer.Name;
         this.IsActive = manufacturer.IsActive;
      }

      public static implicit operator PlateManufacturerObject(PlateManufacturer manufacturer)
      {
         return manufacturer != null ? new PlateManufacturerObject(manufacturer) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Name")]
      public string Name { get; set; }

   }
}
