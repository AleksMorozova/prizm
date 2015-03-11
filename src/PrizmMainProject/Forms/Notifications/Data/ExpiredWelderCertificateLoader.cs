using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Properties;
using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Managers;

namespace Prizm.Main.Forms.Notifications.Data
{
    class ExpiredWelderCertificateLoader : DataNotificationLoader
    {
        class ExpiredWelderCertificateTransformer : IResultTransformer
        {

            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return ExpiredWelderCertificateManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple));
            }

            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[0];
            }

            public string GetOwnerName(object[] tuple)
            {
                string middleName = (tuple[3] == null) ? "" : tuple[3].ToString();
                return tuple[1].ToString() + " " + tuple[2].ToString() + " " + middleName;
            }

            public DateTime GetDateToOccur(object[] tuple)
            {
                return (DateTime)tuple[4];
            }
        }
        // Methods
        public ExpiredWelderCertificateLoader()
            : base(new ExpiredWelderCertificateTransformer())
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @" SELECT  id, firstName, lastName, middleName, certificateExpiration
                       FROM  Welder
                WHERE   (DATEDIFF(day, GETDATE(), certificateExpiration) < 5) AND (isActive = 1) ");
            return sb.ToString();
        }
    }
}
