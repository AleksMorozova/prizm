using Domain.Entity.Security;
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
          bool granted = false;
          if (LoggedUser == null || privilege == Privileges.NullPrivilegeRestricted)
          {
              granted = false;
          }
          else if (privilege == Privileges.NullPrivilegeAllowed)
          {
              granted = true;
          }
          else
          {
              granted = (from r in LoggedUser.Roles where RoleHasPermission(r, privilege) select r).Count() > 0;
          }
          return granted;
      }

      private bool RoleHasPermission(Role r, Privileges privilege)
      {
          return SecurityUtil.ExistOnCurrentWorkstation(privilege) &&
              (from p in r.Permissions where p.Name == privilege.ToString() select p).Count() > 0;
      }

      private User loggedUser;
      public User LoggedUser
      {
          get { return loggedUser; }
          set { loggedUser = value; }
      }
   }
}
