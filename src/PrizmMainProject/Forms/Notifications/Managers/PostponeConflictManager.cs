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
            string conflictDir = Path.Combine(System.Environment.CurrentDirectory, "Conflicts");
            var dir = new DirectoryInfo(conflictDir); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles()) // извлекаем все файлы
            {
                //Path.GetFileNameWithoutExtension(file.FullName)); -  получаем полный путь к файлу и потом вычищаем ненужное, оставляем только имя файла. 
                notifications.Add(new Notification(Guid.Empty, "Pipe number", TypeNotification.PostponeConflict, "Pipe number", DateTime.Now.Date));
            }
        }

        public void RefreshNotifications()
        {
            LoadNotifications();
            NotificationService.Instance.NotifyInterested();
        }
    }
}
