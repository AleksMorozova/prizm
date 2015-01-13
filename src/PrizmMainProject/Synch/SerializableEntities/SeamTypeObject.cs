using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("SeamType")]
   public class SeamTypeObject
   {
      public SeamTypeObject()
      {
      }

      public SeamTypeObject(SeamType seamType)
      {
         this.Id = seamType.Id;
         this.IsActive = seamType.IsActive;
         this.Name = seamType.Name;
         
         if (seamType.SeamTypes != null)
         {
            this.SeamTypes = new List<SeamTypeObject>();
            foreach (var st in seamType.SeamTypes)
            {
               this.SeamTypes.Add(new SeamTypeObject(st));
            }
         }
      }

      public static implicit operator SeamTypeObject(SeamType seamType)
      {
         return seamType != null ? new SeamTypeObject(seamType) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Name")]
      public string Name { get; set; }

      [XmlArray("SeamTypes")]
      public List<SeamTypeObject> SeamTypes { get; set; }

   }
}
