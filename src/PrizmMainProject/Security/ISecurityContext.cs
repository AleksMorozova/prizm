using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrizmMain.Security
{
    interface ISecurityContext
    {
        bool HasAccess(Privileges privilege);
    }
}
