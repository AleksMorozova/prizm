using Prizm.Main.Common;
using Prizm.Main.Synch.Import;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class PostponeConflictManager : NotificationManager, IPostponeConflictManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PostponeConflictManager));
        public PostponeConflictManager()
            : base(null)
        {
        }

        public override TypeNotification Type { get { return TypeNotification.PostponeConflict; } }

        public static Notification CreateNotification(Guid ownerId, string ownerName, float unitsLeft, string information)
        {
            return new Notification(ownerId, ownerName, TypeNotification.SelectiveInspectionOperation, information, unitsLeft);
        }

        public override void LoadNotifications()
        {
            notifications.Clear();
            string conflictDir = Path.Combine(System.Environment.CurrentDirectory, "Conflicts");
            var dir = new DirectoryInfo(conflictDir); // папка с файлами 

            DirectoryInfo dInfo = new DirectoryInfo(conflictDir);
            DirectoryInfo[] subdirs = dInfo.GetDirectories();
            foreach (DirectoryInfo d in subdirs) 
            {
                string fileName = d.Name;
                ConflictFileName f = new ConflictFileName(fileName);
                string pipeNumber = f.PipeNumber;
                notifications.Add(new Notification(Guid.Empty, pipeNumber, TypeNotification.PostponeConflict, pipeNumber, DateTime.Now.Date, fileName));
            }
        }

        public void RefreshNotifications()
        {
            LoadNotifications();
            NotificationService.Instance.NotifyInterested();
        }
    }
}
