using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Data
{
    public class DuplicateLoginLoader : DataNotificationLoader
    {
        class DuplicateLoginResultTransformer : IResultTransformer
        {

            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return DuplicateLoginManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple), GetInformationToOccur(tuple));
            }
            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[0];
            }

            public string GetOwnerName(object[] tuple)
            {
                return tuple[1].ToString() + ": " + tuple[2].ToString() + " " + tuple[3].ToString();
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
        public DuplicateLoginLoader()
            : base(new DuplicateLoginResultTransformer())
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

    }
}
