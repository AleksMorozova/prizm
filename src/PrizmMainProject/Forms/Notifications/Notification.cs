using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Notifications
{
    public class Notification
    {

        // Methods
        public Notification(Guid ownerId, string ownerName, TypeNotification typeNotification, DateTime dateToOccur)
        {
            Id = ownerId;
            OwnerName = ownerName;
            TypeNotification = typeNotification;
            DateToOccur = dateToOccur;
        }

        private string GetResourceMessage(TypeNotification type, NotificationStatus status)
        {
            string resourseName = string.Format("Notification_{0}_{1}", Enum.GetName(typeof(TypeNotification), type), Enum.GetName(typeof(NotificationStatus), status));
            return Resources.ResourceManager.GetString(resourseName);
        }

        private byte[] GetImage(NotificationStatus status)
        {
            Image image;
            switch (status)
            {
                case NotificationStatus.Warning:
                    image = new Bitmap(Resources.warning);
                    break;

                case NotificationStatus.Critical:
                    image = new Bitmap(Resources.critical_warning);
                    break;

                default:
                    image = new Bitmap(Resources.warning);
                    break;
            }
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        // Properties

        public Guid Id { get; private set; }

        public string OwnerName { get; private set; }

        public NotificationStatus Status { get; set; }

        public TypeNotification TypeNotification { get; private set; }

        public Type Editor { get; set; }

        public byte[] Image
        {
            get
            {

                return GetImage(Status);
            }
        }

        public string Message
        {
            get
            {
                return GetResourceMessage(TypeNotification, Status);
            }
        }

        public DateTime DateToOccur { get; set; }

        public int DayToOccur
        {
            get
            {
                int retVal = 0;

                if (DateToOccur != null)
                {
                    retVal = (int)(DateToOccur - DateTime.Now).TotalDays;
                }
                return retVal;
            }
        }
    }

    public enum NotificationStatus
    {
        Warning,
        Critical
    }

    public enum TypeNotification
    {
        DublicatePipeNumber,
        ExpiredCertificate,
        WelderCrtificateExpired
    }

}
