using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Spool")]
   public class SpoolObject
   {
      public SpoolObject()
      {
      }

      public SpoolObject(Spool spool)
      {
         this.Id = spool.Id;
         this.IsActive = spool.IsActive;
         this.PipeNumber = spool.PipeNumber;
         this.Number = spool.Number;
         this.Length = spool.Length;
         this.IsAvailableToJoint = spool.IsAvailableToJoint;
         this.ConstructionStatus = spool.ConstructionStatus;
         this.InspectionStatus = spool.InspectionStatus;

         if (spool.Attachments != null)
         {
             this.Attachments = new List<FileObject>();
             foreach (var file in spool.Attachments)
             {
                 Attachments.Add(new FileObject(file));
             }
         }
      }

      public static implicit operator SpoolObject(Spool spool)
      {
         return spool != null ? new SpoolObject(spool) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("PipeNumber")]
      public string PipeNumber { get; set; }

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
