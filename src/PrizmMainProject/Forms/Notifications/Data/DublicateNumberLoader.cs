using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Notifications;
using Prizm.Main.Forms.Notifications;
using Ninject;
using NHibernate.Transform;

namespace Prizm.Main.Forms.Notifications.Data
{
    class DublicateNumberLoader : DataNotificationLoader
    {
        // Methods
        public DublicateNumberLoader(NotificationManager manager)
            : base(manager)
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"  select 
                                id,
                                mill,
                                number 
                                from Pipe
                                where number  in 
                                (select number from Pipe group by number having count(*) >1)");
            return sb.ToString();
        }

        public override Guid GetId(object[] tuple)
        {
            return (Guid)tuple[0];
        }

        public override string GetOwnerName(object[] tuple)
        {
            return tuple[1].ToString() + "/" + tuple[2].ToString();
        }

        public override DateTime GetDateToOccur(object[] tuple)
        {
            return DateTime.Now;
        }

    }
}
