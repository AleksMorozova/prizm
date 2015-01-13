using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Permission")]
   public class PermissionObject
   {
      public PermissionObject()
      {
      }

      public PermissionObject(Permission perm)
      {
         this.Id = perm.Id;
         this.Name = perm.Name;
         this.NameTranslation = perm.NameTranslation;
      }

      public static implicit operator PermissionObject(Permission perm)
      {
         return perm != null ? new PermissionObject(perm) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }
      
      [XmlAttribute("Name")]
      public string Name { get; set; }

      [XmlAttribute("NameTranslation")]
      public string NameTranslation { get; set; }
   }
}
