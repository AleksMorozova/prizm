using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("ComponentType")]
   public class ComponentTypeObject
   {
      public ComponentTypeObject()
      {
      }

      public ComponentTypeObject(ComponentType type)
      {
         this.Id = type.Id;
         this.IsActive = type.IsActive;
         this.Name = type.Name;
         this.ConnectorsCount = type.ConnectorsCount;
         this.Project = type.Project;
      }

      public static implicit operator ComponentTypeObject(ComponentType type)
      {
         return type != null ? new ComponentTypeObject(type) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Name")]
      public string Name { get; set; }

      [XmlAttribute("ConnectorsCount")]
      public int ConnectorsCount { get; set; }

      [XmlElement("Project")]
      public ProjectObject Project { get; set; }
   }
}
