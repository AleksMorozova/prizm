using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Role")]
   public class RoleObject
   {
      public RoleObject()
      {
      }

      public RoleObject(Role role)
      {
         this.Id = role.Id;
         this.Name = role.Name;
         this.Description = role.Description;
         
         if (role.Permissions != null)
         {
            this.Permissions = new List<PermissionObject>();
            foreach (var p in role.Permissions)
            {
               this.Permissions.Add(new PermissionObject(p));
            }
         }
      }

      public static implicit operator RoleObject(Role role)
      {
         return role != null ? new RoleObject(role) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("Name")]
      public string Name { get; set; }

      [XmlAttribute("Description")]
      public string Description { get; set; }

      [XmlArray("Permissions")]
      public List<PermissionObject> Permissions { get; set; }
   }
}
