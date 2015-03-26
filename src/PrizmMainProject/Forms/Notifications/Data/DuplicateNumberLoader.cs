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
using Prizm.Main.Languages;

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
                return DuplicateNumberManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), 
                    Program.LanguageManager.GetString(StringResources.Notification_DuplicatePipeNumber_Critical));
            }


            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[0];
            }

            public string GetOwnerName(object[] tuple)
            {
                var number = (tuple[2] == null) ? string.Empty : tuple[2].ToString();
                var mill = (tuple[1] == null) ? string.Empty : tuple[1].ToString() ;
                return number + "/" + mill;
            }

        }
        // Methods
        public DuplicateNumberLoader()
            : base(new DuplicateNumberTransformer())
        {

        }

        protected string sqlCache = null;

        public override string BuildSql()
        {
            if (sqlCache == null)
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
                sqlCache=sb.ToString();
            }
            return sqlCache;
        }
    }
}
