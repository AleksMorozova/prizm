using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Notifications;
using Prizm.Main.Forms.Notifications;
using Ninject;
using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Managers;

namespace Prizm.Main.Forms.Notifications.Data
{
    class DuplicateNumberLoader : DataNotificationLoader
    {
        class DuplicateNumberTransformer : IResultTransformer
        {

            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return DuplicateNumberManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple), GetInformationToOccur(tuple));
            }


            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[0];
            }

            public string GetOwnerName(object[] tuple)
            {
                return tuple[1].ToString() + "/" + tuple[2].ToString();
            }

            public DateTime GetDateToOccur(object[] tuple)
            {
                return DateTime.Now;
            }

            public string GetInformationToOccur(object[] tuple)
            {
                return DateTime.Now.Date.ToString("d");
            }
        }
        // Methods
        public DuplicateNumberLoader()
            : base(new DuplicateNumberTransformer())
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
    }
}
