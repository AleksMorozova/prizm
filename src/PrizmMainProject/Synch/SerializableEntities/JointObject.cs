using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Joint")]
   public class JointObject
   {
      public JointObject()
      {
      }

      public JointObject(Joint joint)
      {
         this.Id = joint.Id;
         this.IsActive = joint.IsActive;
         this.Number = joint.Number;
         this.NumberKP = joint.NumberKP;
         this.DistanceFromKP = joint.DistanceFromKP;

         if (joint.LoweringDate != null && joint.LoweringDate.HasValue)
         {
            this.LoweringDate = joint.LoweringDate.Value;
         }

         this.Status = joint.Status;
         this.GpsLatitude = joint.GpsLatitude;
         this.GpsLongitude = joint.GpsLongitude;
         this.GpsHeight = joint.GpsHeight;
         this.FirstElement = joint.FirstElement;
         this.SecondElement = joint.SecondElement;

         if (joint.Attachments != null)
         {
            Attachments = new List<FileObject>();
            foreach (var file in joint.Attachments)
            {
               Attachments.Add(new FileObject(file));
            }
         }
      }

      public static implicit operator JointObject(Joint joint)
      {
         return joint != null ? new JointObject(joint) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("NumberKP")]
      public int NumberKP { get; set; }

      [XmlAttribute("DistanceFromKP")]
      public float DistanceFromKP { get; set; }

      [XmlAttribute("LoweringDate")]
      public DateTime LoweringDate { get; set; }

      [XmlAttribute("Status")]
      public JointStatus Status { get; set; }

      [XmlAttribute("GpsLatitude")]
      public float GpsLatitude { get; set; }

      [XmlAttribute("GpsLongitude")]
      public float GpsLongitude { get; set; }

      [XmlAttribute("GpsHeight")]
      public float GpsHeight { get; set; }

      [XmlElement("FirstElement")]
      public PartDataObject FirstElement { get; set; }

      [XmlElement("SecondElement")]
      public PartDataObject SecondElement { get; set; }

      [XmlArray("Attachments")]
      public List<FileObject> Attachments { get; set; }

   }
}
