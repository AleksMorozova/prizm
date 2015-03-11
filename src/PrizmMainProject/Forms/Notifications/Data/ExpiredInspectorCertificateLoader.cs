using System;
using DevExpress.Xpo;
using NHibernate.Transform;
using Prizm.Data.DAL.Notifications;
using Ninject;
using System.Collections.Generic;
using Prizm.Main.Properties;
using System.Text;
using Prizm.Main.Forms.Notifications.Managers;

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
                return ExpiredInspectorCertificateManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple));
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

            public DateTime GetDateToOccur(object[] tuple)
            {
                return (DateTime)tuple[5];
            }
        }
        // Methods 
        public ExpiredInspectorCertificateLoader()
            : base(new ExpiredInspectorCertificateTransformer())
        {

        }

        public override string BuildSql()
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
                    AND (DATEDIFF(day, GETDATE(), InspectorCertificate.expirationDate) < 5)");
            return sb.ToString();
        }

    }

}