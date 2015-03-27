using NHibernate.Transform;
using Prizm.Main.Common;
using Prizm.Main.Forms.Notifications.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Data
{
    class NotRequiredOperationMetersLoader : DataNotificationLoader
    {
        public NotRequiredOperationMetersLoader()
            : base(new NotRequiredOperationTransformer())
        {

        }

        protected string sqlCache = null;

        // TODO: remove from SQL request the filter PercentForInspectionOperation because we need all data for internalCache

        // TODO: change request to take into account the date of latest inspection operation on pipe

        public override string BuildSql()
        {
            if (sqlCache == null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(
                    @" select * from (
                        Select t.name, t.code, t.frequency as f, t.frequencyMeasure, s.type, s.id From pipeTest t, PipeMillSizeType s
                               where t.frequencyType != 'R' and t.pipeMillSizeTypeId=s.id and t.frequencyMeasure='Meters') b
                            right join 
                        (Select Sum(p.length) length, p.typeId From Pipe p 
                               group by p.typeId) a
                               on b.id =a.typeId where b.f " + Constants.PercentForInspectionOperation + " <= a.length");
                sqlCache=sb.ToString();
            }
            return sqlCache;
        }
    }
}
