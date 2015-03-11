using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Data
{
    class NotRequiredControlOperationPipesLoader : DataNotificationLoader
    {
        public NotRequiredControlOperationPipesLoader(NotificationManager manager)
            : base(manager)
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"  select * from (Select t.name,  t.code, t.frequency as f, t.frequencyMeasure, s.type, s.id From pipeTest t, PipeMillSizeType s
                            where t.isRequired = 0 and t.pipeMillSizeTypeId=s.id and t.frequencyMeasure='Pipes') b
                            right join 
                    (Select Count(p.number) number, p.typeId From Pipe p 
                        group by p.typeId) a
                        on b.id =a.typeId where b.f" + Constants.PercentForControlOperation + " <= a.number");
            return sb.ToString();
        }

        public override Guid GetId(object[] tuple)
        {
            return (Guid)tuple[5];
        }

        public override string GetOwnerName(object[] tuple)
        {
            return tuple[4].ToString() + ":" + tuple[1].ToString() + "-" + tuple[0].ToString();
        }

        public override DateTime GetDateToOccur(object[] tuple)
        {
            return DateTime.Now;
        }

        public override float GetTimeToOccur(object[] tuple)
        {
            return (float)Convert.ChangeType(tuple[6], typeof(float)) - (float)Convert.ChangeType(tuple[2], typeof(float));
        }
    }
}
