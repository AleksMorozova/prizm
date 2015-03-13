using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    interface INotRequiredOperationManager
    {
        void RefreshNotification(Guid pipeSizeTypeId, string pipeSizeTypeName, string operationCode, string operationName, float units);
    }
}
