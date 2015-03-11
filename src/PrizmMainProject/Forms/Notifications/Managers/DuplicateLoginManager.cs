using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class DuplicateLoginManager : NotificationManager
    {

        public DuplicateLoginManager()
            : base(new DuplicateLoginLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.DuplicateLogin; } }

        public static Notification CreateNotification(Guid userId, string ownerName, DateTime dateToOccur)
        {
            return new Notification(userId, ownerName, TypeNotification.DuplicateLogin, dateToOccur, 0);
        }

    }
}
