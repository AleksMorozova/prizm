using Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrizmMain.Security
{
    public interface ISecurityContext
    {
        bool HasAccess(Privileges privilege);
        Domain.Entity.PersonName GetLoggedPerson();
        User LoggedUser { get; set; }
    }
}
