using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    interface INotRequiredControlOperationMetersManager
    {
        void RefreshNotification(Guid pipe, string oldNumber, string newNumber);
    }
}
