using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Pipe")]
   public class PipeObject
   {
      public PipeObject()
      {
      }

      public PipeObject(Pipe pipe)
      {
         this.Id = pipe.Id;
         this.IsActive = pipe.IsActive;
         this.Number = pipe.Number;
         this.Length = pipe.Length;
         this.IsAvailableToJoint = pipe.IsAvailableToJoint;
         this.ConstructionStatus = pipe.ConstructionStatus;
         this.InspectionStatus = pipe.InspectionStatus;
         this.Plate = pipe.Plate;
         this.Mill = pipe.Mill;
         this.Diameter = pipe.Diameter;
         this.WallThickness = pipe.WallThickness;
         this.Weight = pipe.Weight;
         this.ProductionDate = pipe.ProductionDate;
         this.Type = pipe.Type;
         this.Railcar = pipe.Railcar;
         this.PurchaseOrder = pipe.PurchaseOrder;
         this.Status = pipe.Status;

         if (pipe.Spools != null)
         {
            this.Spools = new List<SpoolObject>();
            foreach (var spool in pipe.Spools)
            {
               this.Spools.Add(new SpoolObject(spool));
            }
         }

         if (pipe.Attachments != null)
         {
            this.Attachments = new List<FileObject>();
            foreach (var attach in pipe.Attachments)
            {
               this.Attachments.Add(new FileObject(attach));
            }
         }
      }

      public static implicit operator PipeObject(Pipe pipe)
      {
         return pipe != null ? new PipeObject(pipe) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

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

      [XmlElement("Plate")]
      public PlateObject Plate { get; set; }

      [XmlAttribute("Mill")]
      public string Mill { get; set; }

      [XmlAttribute("Diameter")]
      public int Diameter { get; set; }

      [XmlAttribute("WallThickness")]
      public float WallThickness { get; set; }

      [XmlAttribute("Weight")]
      public float Weight { get; set; }

      [XmlAttribute("ProductionDate")]
      public DateTime ProductionDate { get; set; }

      [XmlElement("SizeType")]
      public SizeTypeObject Type { get; set; }

      [XmlElement("Railcar")]
      public RailcarObject Railcar { get; set; }

      [XmlElement("PurchaseOrder")]
      public PurchaseOrderObject PurchaseOrder { get; set; }

      [XmlArray("Spools")]
      public List<SpoolObject> Spools { get; set; }

      [XmlAttribute("Status")]
      public PipeMillStatus Status { get; set; }

      [XmlArray("Attachments")]
      public List<FileObject> Attachments { get; set; }

   }
}
