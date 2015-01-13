using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("SizeType")]
   public class SizeTypeObject
   {
      public SizeTypeObject()
      {
      }

      public SizeTypeObject(PipeMillSizeType sizeType)
      {
         this.Id = sizeType.Id;
         this.IsActive = sizeType.IsActive;
         this.Type = sizeType.Type;
         this.Length = sizeType.Length;
         this.Diameter = sizeType.Diameter;
         this.Thickness = sizeType.Thickness;
         this.SeamType = sizeType.SeamType;
      }

      public static implicit operator SizeTypeObject(PipeMillSizeType sizeType)
      {
         return sizeType != null ? new SizeTypeObject(sizeType) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Type")]
      public string Type { get; set; }

      [XmlAttribute("Length")]
      public int Length { get; set; }

      [XmlAttribute("Diameter")]
      public int Diameter { get; set; }

      [XmlAttribute("Thickness")]
      public int Thickness { get; set; }

      [XmlElement("SeamType")]
      public SeamTypeObject SeamType { get; set; }
   }
}
