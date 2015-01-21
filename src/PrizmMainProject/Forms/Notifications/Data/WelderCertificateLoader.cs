using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Notifications.Data
{
    class WelderCertificateLoader : DataNotificationLoader
    {
        // Methods
        public WelderCertificateLoader(NotificationManager manager)
            : base(manager)
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @" SELECT 
                       [id]
                      ,[firstName]
                      ,[lastName]
                      ,[middleName]
                      ,[certificate]
                      ,[certificateExpiration]
                      ,[stamp]
                      ,[grade]
                      ,[isActive]
                  FROM [prizm].[dbo].[Welder] 
                  Where (DATEDIFF(day, GETDATE(), [certificateExpiration] ) < 5)");
            return sb.ToString();
        }

        public override Guid GetId(object[] tuple)
        {
            return (Guid)tuple[0];
        }

        public override string GetOwnerName(object[] tuple)
        {
            return tuple[1].ToString() + " " + tuple[2].ToString() + " " + tuple[3].ToString() + " " +
            Resources.ResourceManager.GetString("Certificate") + " №" + tuple[4].ToString();
        }

        public override DateTime GetDateToOccur(object[] tuple)
        {
            return (DateTime)tuple[5];
        }


    }
}
