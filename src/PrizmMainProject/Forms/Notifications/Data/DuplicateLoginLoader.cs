using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Data
{
    public class DuplicateLoginLoader : DataNotificationLoader
    {
                // Methods
        public DuplicateLoginLoader(NotificationManager manager)
            : base(manager)
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"  select 
                                id,
                                login,
                                firstName,
                                lastName 
                                from [User]
                                where login  in 
                                (select login from [User] group by login having count(*) >1)");
            return sb.ToString();
        }

        public override Guid GetId(object[] tuple)
        {
            return (Guid)tuple[0];
        }

        public override string GetOwnerName(object[] tuple)
        {
            return tuple[1].ToString() + ": " + tuple[2].ToString() + " " + tuple[3].ToString();
        }

        public override DateTime GetDateToOccur(object[] tuple)
        {
            return DateTime.Now;
        }
    }
}
