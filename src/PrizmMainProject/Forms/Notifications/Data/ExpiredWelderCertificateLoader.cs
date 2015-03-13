using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Properties;
using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Managers;
using Prizm.Main.Common;

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
                return ExpiredWelderCertificateManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetExpirationDate(tuple), GetTextInformation(tuple));
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

            public DateTime GetExpirationDate(object[] tuple)
            {
                return (DateTime)tuple[4];
            }

            public string GetTextInformation(object[] tuple)
            {
                DateTime t = (DateTime)tuple[4];
                return t.Date.ToString("d");
            }
        }
        // Methods
        public ExpiredWelderCertificateLoader()
            : base(new ExpiredWelderCertificateTransformer())
        {

        }

        protected string sqlCache = null;

        public override string BuildSql()
        {
            if (sqlCache == null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(
                    @" SELECT  id, firstName, lastName, middleName, certificateExpiration
                       FROM  Welder
                WHERE   (DATEDIFF(day, GETDATE(), certificateExpiration) < " + Constants.DaysToExpirationWarning + ") AND (isActive = 1) ");
                sqlCache = sb.ToString();
            }
            return sqlCache;
            
        }
    }
}
