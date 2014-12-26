using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Properties;


namespace PrizmMain.DummyData
{
    public class NotificationDummy
    {


        // Methods
        public static List<Notification> QueryNotification(TypeNotification typeNotification)
        {
            List<Notification> list = null;
            switch (typeNotification)
            {
                case TypeNotification.DublicatePipeNumber:
                    list = GetDublicatePipeNumber();
                    break;
                case TypeNotification.ExpiredCertificate:
                    list = GetExpiredCertificate();
                    break;
                default:
                    break;
            }
            return list;
        }


        private static List<Notification> GetDublicatePipeNumber()
        {
            List<Notification> list = new List<Notification>();

            Notification item = new Notification(TypeNotification.DublicatePipeNumber, NotificationStatus.Critical)
            {
                Id = new Guid("681EE872-C79F-4A0D-979D-636924C3516C"),
                Name = "труба № 1356 Завод 1",
                Date = DateTime.Now.AddDays(10),
            };
            list.Add(item);

            Notification item1 = new Notification(TypeNotification.DublicatePipeNumber, NotificationStatus.Critical)
            {
                Id = new Guid("B20A4F5B-E578-491C-888B-914BDDE9DB09"),
                Name = "труба № 1356 Завод 2",
                Date = DateTime.Now.AddDays(10),
            };
            list.Add(item1);
            return list;
        }

        private static List<Notification> GetExpiredCertificate()
        {
            List<Notification> list = new List<Notification>();

            Notification notification2 = new Notification(TypeNotification.ExpiredCertificate, NotificationStatus.Warning)
            {
                Id = new Guid("7DA1EF56-C5DE-46A8-8298-167E17BF087A"),
                Name = "Иванов И.С сертификат №155",
                Date = DateTime.Now,
            };
            list.Add(notification2);

            Notification notification3 = new Notification(TypeNotification.ExpiredCertificate, NotificationStatus.Critical)
            {
                Id = new Guid("7DA1EF56-C5DE-46A8-8298-167E17BF087A"),
                Name = "Петров И.С сертификат №155",
                Date = DateTime.Now,
            };
            list.Add(notification3);

            return list;
        }

    }

    public class Notification
    {
        // Fields
        Type typeEditor;
        byte[] image;
        string message;

        // Methods
        public Notification(TypeNotification typeNotification, NotificationStatus staus)
        {
            typeEditor = GetTypeFormEditor(typeNotification);
            message = GetResourceMessage(typeNotification, staus);
            image = GetImage(staus);
        }

        public override string ToString()
        {
            return Date.ToString("MM.dd.yyyy") + "  " + this.Message;
        }

        private Type GetTypeFormEditor(TypeNotification type)
        {
            Type editor = null;

            switch (type)
            {
                case TypeNotification.DublicatePipeNumber:
                    editor = typeof(MillPipeNewEditXtraForm);
                    break;
                case TypeNotification.ExpiredCertificate:
                    editor = typeof(SettingsXtraForm);
                    break;
                default:
                    break;
            }
            return editor;
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

        public byte[] Image
        {
            get
            {
                return image;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
        }

        public Type Editor
        {
            get
            {
                return typeEditor;
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
