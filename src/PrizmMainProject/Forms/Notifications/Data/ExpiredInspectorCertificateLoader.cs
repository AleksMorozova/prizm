using System;
using DevExpress.Xpo;
using NHibernate.Transform;
using Prizm.Data.DAL.Notifications;
using Ninject;
using System.Collections.Generic;
using Prizm.Main.Properties;
using System.Text;
using Prizm.Main.Forms.Notifications.Managers;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Notifications.Data
{

    public class ExpiredInspectorCertificateLoader : DataNotificationLoader
    {
        class ExpiredInspectorCertificateTransformer : IResultTransformer
        {

            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return ExpiredInspectorCertificateManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetExpirationDate(tuple), GetTextInformation(tuple));
            }

            public  Guid GetId(object[] tuple)
            {
                return (Guid)tuple[0];
            }

            public string GetOwnerName(object[] tuple)
            {
                string middleName = (tuple[3] == null) ? "" : tuple[3].ToString() + " ";
                string text = tuple[1].ToString() + " " + tuple[2].ToString() + " " +
                Resources.ResourceManager.GetString("Certificate") + " №" + tuple[4].ToString();
                return text;
            }

            public DateTime GetExpirationDate(object[] tuple)
            {
                return (DateTime)tuple[5];
            }

            public string GetTextInformation(object[] tuple)
            {
                DateTime t = (DateTime)tuple[5];
                return t.Date.ToString("d");
            }
        }
        // Methods 
        public ExpiredInspectorCertificateLoader()
            : base(new ExpiredInspectorCertificateTransformer())
        {

        }

        protected string sqlCache = null;

        public override string BuildSql()
        {
            if (sqlCache == null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(
                    @" SELECT
                    InspectorCertificate.id,
                    Inspector.firstName,
                    Inspector.lastName,
                    Inspector.middleName,
                    InspectorCertificate.number,
                    InspectorCertificate.expirationDate,
                    DATEDIFF(day, GETDATE(), InspectorCertificate.expirationDate) As DayToExpired
                    FROM  InspectorCertificate 
                    LEFT OUTER JOIN Inspector ON 
                    InspectorCertificate.inspectorId = Inspector.id
                    WHERE (InspectorCertificate.isActive = 1) 
                    AND (DATEDIFF(day, GETDATE(), InspectorCertificate.expirationDate) < " + Constants.DaysToExpirationWarning + ")");
                sqlCache = sb.ToString();
            }

            return sqlCache;
        }

    }

}