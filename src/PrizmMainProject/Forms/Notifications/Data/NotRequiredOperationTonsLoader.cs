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
    class NotRequiredOperationTonsLoader : DataNotificationLoader
    {
        public NotRequiredOperationTonsLoader()
            : base(new NotRequiredOperationTransformer())
        {

        }

        protected string sqlCache = null;


        public override string BuildSql()
        {
            if (sqlCache == null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(
                    @" select * from (
                                Select t.name,t.code, t.frequency as f, t.frequencyMeasure, s.type, s.id 
                                            From pipeTest t, PipeMillSizeType s
                                where t.isRequired = 0 and t.pipeMillSizeTypeId=s.id and t.frequencyMeasure='Tons') b
                                                    right join 
                        (Select Sum(p.weight) weight, p.typeId From Pipe p 
                                        group by p.typeId) a
                                on b.id =a.typeId where b.f" + Constants.PercentForInspectionOperation + "  <= a.weight");
                sqlCache = sb.ToString();
            }
            return sqlCache;
        }
    }
}
