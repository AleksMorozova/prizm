using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch
{
   [XmlType("Conflict")]
   public class Conflict
   {
      [XmlAttribute("PortionID")]
      public Guid PortionID { get; set; }

      [XmlElement("Pipe")]
      public PipeObject Pipe { get; set; }
   }
}
