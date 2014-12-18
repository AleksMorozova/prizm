using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;


namespace PrizmMain.DummyData
{
    public class NotificationDummy
    {
        // Methods
        public BindingList<NotificationOwners> GetAllOwners()
        {
            BindingList<Notification> notifications = this.GetNotifications();
            BindingList<NotificationOwners> listOwners = new BindingList<NotificationOwners>();
            NotificationOwners item = new NotificationOwners
            {
                Id = Guid.NewGuid(),
                Name = "труба № 1356 Завод 1",
                Notification = notifications[0]
            };
            listOwners.Add(item);
            NotificationOwners owners2 = new NotificationOwners
            {
                Id = Guid.NewGuid(),
                Name = "труба № 1356 Завод 2",
                Notification = notifications[0]
            };
            listOwners.Add(owners2);
            NotificationOwners owners3 = new NotificationOwners
            {
                Id = Guid.NewGuid(),
                Name = "Иванов И.С сертификат №155",
                Notification = notifications[1]
            };
            listOwners.Add(owners3);
            return listOwners;
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

        private BindingList<Notification> GetNotifications()
        {
            BindingList<Notification> list = new BindingList<Notification>();
            Notification item = new Notification
            {
                Id = Guid.NewGuid(),
                Message = "Error : dublicate number of pipe",
                Status = NotificationStatus.Critical,
                Date = DateTime.Now.AddDays(10),
                Image = this.GetImage(NotificationStatus.Critical)
            };
            list.Add(item);
            Notification notification2 = new Notification
            {
                Id = Guid.NewGuid(),
                Message = "Warning: Sertificate Expared",
                Status = NotificationStatus.Warning,
                Date = DateTime.Now,
                Image = this.GetImage(NotificationStatus.Warning)
            };
            list.Add(notification2);
            return list;
        }
    }


    public class NotificationOwners
    {
        // Methods
        public override string ToString()
        {
            return this.Name;
        }

        // Properties
        public Guid Id { get; set; }

        public byte[] Image
        {
            get
            {
                if (this.Notification != null)
                {
                    return this.Notification.Image;
                }
                return null;
            }
        }

        public string Name { get; set; }

        public Notification Notification { get; set; }
    }


    public class Notification
    {
        // Methods
        public override string ToString()
        {
            return Date.ToString("MM.dd.yyyy") + "  " + this.Message;
        }

        // Properties
        public Guid Id { get; set; }

        public byte[] Image { get; set; }

        public string Message { get; set; }

        public NotificationStatus Status { get; set; }

        public DateTime Date { get; set; }
    }

    public enum NotificationStatus
    {
        Warning,
        Critical
    }

}
