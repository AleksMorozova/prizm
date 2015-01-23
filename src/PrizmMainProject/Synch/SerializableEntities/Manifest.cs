using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [XmlType("Manifest")]
   public class Manifest
   {
      [XmlAttribute("ExportDateTime")]
      public DateTime ExportDateTime { get; set; }

      [XmlAttribute("PortionID")]
      public Guid PortionID { get; set; }


      [XmlAttribute("PortionNumber")]
      public int PortionNumber { get; set; }

      [XmlAttribute("WorkstationType")]
      public WorkstationType WorkstationType { get; set; }

   }
}
