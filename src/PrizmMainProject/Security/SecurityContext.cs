using Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Security
{
   public class SecurityContext : ISecurityContext
   {
      public bool HasAccess(Privileges privilege)
      {
         if (LoggedUser == null)
            return false;

         return (from r in LoggedUser.Roles where RoleHasPermission(r, privilege) select r).Count() > 0;
      }

      public Domain.Entity.PersonName GetLoggedPerson()
      {
         return LoggedUser.Name;
      }

      bool RoleHasPermission(Role r, Privileges privilege)
      {
         return (from p in r.Permissions where p.Name == privilege.ToString() select p).Count() > 0;
      }


      public User LoggedUser
      {
         get;
         set;
      }
   }
}
