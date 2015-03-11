using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications
{
    interface INotificationManager
    {
        void LoadNotifications();

        TypeNotification Type { get; }
        int Count { get; }
    }
}
