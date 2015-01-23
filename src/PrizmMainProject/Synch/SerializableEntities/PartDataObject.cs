using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("PartData")]
   public class PartDataObject
   {
      public PartDataObject()
      {
      }

      public PartDataObject(PartData part)
      {
         this.Id = part.Id;
         this.PartType = part.PartType;
         this.Number = part.Number;
         this.PartTypeDescription = part.PartTypeDescription;
         this.Length = part.Length;
         this.Diameter = part.Diameter;
         this.WallThickness = part.WallThickness;
         this.ConstructionStatus = part.ConstructionStatus;
         this.ConnectorsCount = part.ConnectorsCount;

         if (part.Connectors != null)
         {
            Connectors = new List<ConnectorObject>();
            foreach (var c in part.Connectors)
            {
               Connectors.Add(new ConnectorObject(c));
            }
         }
      }

      public static implicit operator PartDataObject(PartData part)
      {
         return part != null ? new PartDataObject(part) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("PartType")]
      public PartType PartType { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("PartTypeDescription")]
      public string PartTypeDescription { get; set; }

      [XmlAttribute("Length")]
      public int Length { get; set; }

      [XmlAttribute("WallThickness")]
      public float WallThickness { get; set; }

      [XmlAttribute("Diameter")]
      public int Diameter { get; set; }

      [XmlArray("Connectors")]
      public List<ConnectorObject> Connectors { get; set; }

      [XmlAttribute("ConstructionStatus")]
      public PartConstructionStatus ConstructionStatus { get; set; }

      [XmlAttribute("ConnectorsCount")]
      public string ConnectorsCount { get; set; }

   }
}
