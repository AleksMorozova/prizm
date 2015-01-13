using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("User")]
   public class UserObject
   {
      public UserObject()
      {
      }

      public UserObject(User user)
      {
         this.Id = user.Id;
         this.IsActive = user.IsActive;
         this.Login = user.Login;

         if (user.PasswordExpires != null)
         {
           this.PasswordExpires = user.PasswordExpires.Value;
         }

         this.PasswordHash = user.PasswordHash;
         
         if (user.Name != null)
         {
            this.FirstName = user.Name.FirstName;
            this.LastName = user.Name.LastName;
            this.MiddleName = user.Name.MiddleName;
         }

         this.Undeletable = user.Undeletable;

         if (user.Roles != null)
         {
            this.Roles = new List<RoleObject>();
            foreach (var r in user.Roles)
            {
               this.Roles.Add(new RoleObject(r));
            }
         }
      }

      public static implicit operator UserObject(User user)
      {
         return user != null ? new UserObject(user) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Login")]
      public string Login { get; set; }

      [XmlAttribute("PasswordHash")]
      public string PasswordHash { get; set; }

      [XmlAttribute("LastName")]
      public string LastName { get; set; }

      [XmlAttribute("FirstName")]
      public string FirstName { get; set; }

      [XmlAttribute("MiddleName")]
      public string MiddleName { get; set; }

      [XmlAttribute("PasswordExpires")]
      public DateTime PasswordExpires { get; set; }

      [XmlArray("Roles")]
      public List<RoleObject> Roles { get; set; }

      [XmlAttribute("Undeletable")]
      public bool Undeletable { get; set; }
   }
}
