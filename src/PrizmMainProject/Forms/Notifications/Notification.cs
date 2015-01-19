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
        // Fields

        // Methods
        public Notification(TypeNotification typeNotification)
        {
            TypeNotification = typeNotification;
        }

        public override string ToString()
        {
            return Date.ToString("MM.dd.yyyy") + "  " + this.Message;
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
        public Guid Id { get; set; }

        public string Name { get; set; }

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

        public DateTime Date { get; set; }
    }

    public enum NotificationStatus
    {
        Warning,
        Critical
    }

    public enum TypeNotification
    {
        DublicatePipeNumber,
        ExpiredCertificate
    }
}
