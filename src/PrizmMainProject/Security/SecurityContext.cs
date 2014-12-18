using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Security
{
   public class SecurityContext : ISecurityContext
   {
      public bool HasAccess(Privileges privilege)
      {
         if (LoggedUser == null)
            return false;

         return (from r in LoggedUser.Roles where RoleHasPermission(r, privilege) select r).Count() > 0;
      }

      public Prizm.Domain.Entity.PersonName GetLoggedPerson()
      {
         return loggedUser.Name;
      }

      bool RoleHasPermission(Role r, Privileges privilege)
      {
         return (from p in r.Permissions where p.Name == privilege.ToString() select p).Count() > 0;
      }


      private User loggedUser;
      public User LoggedUser
      {
          get { return loggedUser; }
          set { loggedUser = value; }
      }
   }
}
