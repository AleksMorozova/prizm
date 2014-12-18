using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prizm.Main.Security
{
    public interface ISecurityContext
    {
        bool HasAccess(Privileges privilege);
        Prizm.Domain.Entity.PersonName GetLoggedPerson();
        User LoggedUser { get; set; }
    }
}
