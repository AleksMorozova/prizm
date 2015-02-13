using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Security
{
   public class User : Item
   {
      public User()
      {
         Roles = new List<Role>();
         Name = new PersonName();
      }

      public virtual string Login { get; set; }
      public virtual string PasswordHash { get; set; }
      public virtual PersonName Name { get; set; }
      public virtual DateTime? PasswordExpires { get; set; }
      public virtual IList<Role> Roles { get; set; }
      public virtual bool Undeletable { get; set; }
      public virtual string UILanguage { get; set; }
   }
}
