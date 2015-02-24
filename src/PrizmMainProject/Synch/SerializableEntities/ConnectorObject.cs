using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Connector")]
   public class ConnectorObject
   {
      public ConnectorObject()
      {
      }

      public ConnectorObject(Connector connector)
      {
         this.Id = connector.Id;
         this.IsActive = connector.IsActive;
         this.Diameter = connector.Diameter;
         this.WallThickness = connector.WallThickness;
      }

      public static implicit operator ConnectorObject(Connector connector)
      {
         return connector != null ? new ConnectorObject(connector) : connector;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Diameter")]
      public int Diameter { get; set; }

      [XmlAttribute("WallThickness")]
      public float WallThickness { get; set; }
   }
}
