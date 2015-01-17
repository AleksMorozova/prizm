using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Component")]
   public class ComponentObject
   {
      public ComponentObject()
      {
      }

      public ComponentObject(Component component)
      {
         this.Id = component.Id;
         this.IsActive = component.IsActive;
         this.Certificate = component.Certificate;
         this.Type = component.Type;
         this.Number = component.Number;
         this.Length = component.Length;
         this.IsAvailableToJoint = component.IsAvailableToJoint;
         this.ConstructionStatus = component.ConstructionStatus;
         this.InspectionStatus = component.InspectionStatus;

         if (component.Attachments != null)
         {
            this.Attachments = new List<FileObject>();
            foreach (var file in component.Attachments)
            {
               Attachments.Add(new FileObject(file));
            }
         }
      }

      public static implicit operator ComponentObject(Component component)
      {
         return component != null ? new ComponentObject(component) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Certificate")]
      public string Certificate { get; set; }

      [XmlElement("Type")]
      public ComponentTypeObject Type { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("Length")]
      public int Length { get; set; }

      [XmlAttribute("IsAvailableToJoint")]
      public bool IsAvailableToJoint { get; set; }

      [XmlAttribute("ConstructionStatus")]
      public PartConstructionStatus ConstructionStatus { get; set; }

      [XmlAttribute("InspectionStatus")]
      public PartInspectionStatus InspectionStatus { get; set; }

      [XmlArray("Attachments")]
      public List<FileObject> Attachments { get; set; }
   }
}
