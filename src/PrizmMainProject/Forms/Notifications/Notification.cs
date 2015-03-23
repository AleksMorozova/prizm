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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Notifications
{
    public class Notification
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Notification));

        // Methods
        public Notification(Guid ownerId, string ownerName, TypeNotification typeNotification, string information)
        {
            Id = ownerId;
            OwnerName = ownerName;
            TypeNotification = typeNotification;
            Information = information;
            Status = NotificationStatus.Critical;
            DateToOccur = default(DateTime);
            UnitsLeft = 0;

        }

        public Notification(Guid ownerId, string ownerName, TypeNotification typeNotification, string information, DateTime dayToOccur)
            : this(ownerId, ownerName, typeNotification, information)
        {
            DateToOccur = dayToOccur;
            Status = DaysLeft <= 0 ? NotificationStatus.Critical : NotificationStatus.Warning;
        }

        public Notification(Guid ownerId, string ownerName, TypeNotification typeNotification, string information, float unitsLeft)
            : this(ownerId, ownerName, typeNotification, information)
        {
            UnitsLeft = unitsLeft;
            Status = UnitsLeft >= 0 ? NotificationStatus.Critical : NotificationStatus.Warning;
        }

        // TODO: move screen representation to Form
        private string GetResourceMessage(TypeNotification type, NotificationStatus status)
        {
            // TODO: avoid attaching enum names to string names or take care about not changing enum names and bad combinations
            string resourсeName = string.Format("Notification_{0}_{1}", Enum.GetName(typeof(TypeNotification), type), Enum.GetName(typeof(NotificationStatus), status));
            StringResource? res = Program.LanguageManager.FindById(typeof(StringResources), resourсeName);
            if (res != null)
            {
                return Program.LanguageManager.GetString((StringResource)res);
            }
            else
            {
                var e = new ApplicationException("Wrong id of notification text: " + resourсeName);
                log.Error(e.Message);
                throw e;
            }
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

        public string Information { get; set; }

        public float UnitsLeft { get; set; }
        
        public DateTime DateToOccur { get; set; }
       
        public int DaysLeft
        {
            get
            {
                int retVal = 0;

                if (DateToOccur != default(DateTime))
                {
                    retVal = (int)(DateToOccur.Date - DateTime.Now.Date).TotalDays;
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
        DuplicatePipeNumber,
        DuplicateLogin,
        ExpiredInspectorCertificate,
        ExpiredWelderCertificate,
        NotRequiredInspectionOperation,
    }

}
