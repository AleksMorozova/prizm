using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Transform;
using Prizm.Data.DAL.Notifications;
using Ninject;
using System.Drawing;
using Prizm.Main.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    public abstract class StrategyNotificationFill
    {

        // Methods
        internal abstract void SetNotificationStatus(Notification notification);

        public void FillAttribute(Notification notification)
        {

            SetNotificationStatus(notification);
        }

    }
}
