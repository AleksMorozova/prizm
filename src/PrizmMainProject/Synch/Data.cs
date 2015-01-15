using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch
{
   [XmlType("Data")]
   public class Data
   {
      [XmlElement("Project")]
      public ProjectObject Project { get; set; }

      [XmlArray("Pipes")]
      public List<PipeObject> Pipes { get; set; }
   }
}
