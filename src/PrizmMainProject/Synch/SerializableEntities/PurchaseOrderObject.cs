using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("PurchaseOrder")]
   public class PurchaseOrderObject
   {
      public PurchaseOrderObject()
      {
      }

      public PurchaseOrderObject(PurchaseOrder order)
      {
         this.Id = order.Id;
         this.IsActive = order.IsActive;
         this.Number = order.Number;
         this.Date = order.Date;
      }

      public static implicit operator PurchaseOrderObject(PurchaseOrder order)
      {
         return order != null ? new PurchaseOrderObject(order) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("Date")]
      public DateTime Date { get; set; }


   }
}
