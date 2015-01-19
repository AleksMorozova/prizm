using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;

namespace Prizm.Main.Forms.Notifications.Request
{
    class DuplicateNumberNotificationFactory : AbstractNotificationFactory
    {

        internal override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"  select 
                    id,
                    mill,
                    number 
                    from Pipe
                    where number  in 
                    (select number from Pipe group by number having count(*) >1)");
            return sb.ToString();
        }

        internal override string GetRepresentation(object[] tuple)
        {
            return tuple[1].ToString() + "/" + tuple[2].ToString();
        }

        internal override void SetFormTypeEditor(Notification notification)
        {
            notification.Editor = typeof(MillPipeNewEditXtraForm);
        }

        internal override void SetNotificationStatus(Notification notification, object[] tuple)
        {
            notification.Status = NotificationStatus.Critical;
        }


        internal override TypeNotification NotificationType
        {
            get
            {
                return TypeNotification.DublicatePipeNumber;
            }
        }


    }
}
