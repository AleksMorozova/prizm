using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.Selective
{
    class SelectiveOperationManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SelectiveOperationManager));
        private SelectiveCache cache = new SelectiveCache();

        public override void LoadNotifications()
        {
            try
            {
                cache.Clear();

               //1) typeSize - Selective operations - pipe with this operation
                //2) all pipe for type size

             //3) for selective operation set general pipe amount
                //4) for selective operation call isExpired 
            }
            catch (Exception ex)
            {
                log.Error("Unable to load Not Required Operation Notifications: ", ex);
            }
            //NotificationService.Instance.NotifyInterested();
        }
    }
}
