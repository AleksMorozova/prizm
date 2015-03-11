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
    class NotRequiredControlOperationMetersLoader : DataNotificationLoader
    {
        class NotRequiredControlOperationMetersTransformer : IResultTransformer
        {

            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return NotRequiredControlOperationMetersManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple));
            }

            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[5];
            }

            public string GetOwnerName(object[] tuple)
            {
                return tuple[4].ToString() + ":" + tuple[1].ToString() + "-" + tuple[0].ToString();
            }

            public DateTime GetDateToOccur(object[] tuple)
            {
                return DateTime.Now;
            }

            public float GetTimeToOccur(object[] tuple)
            {
                return (float)Convert.ChangeType(tuple[6], typeof(float)) - (float)Convert.ChangeType(tuple[2], typeof(float));
            }
        }
        public NotRequiredControlOperationMetersLoader()
            : base(new NotRequiredControlOperationMetersTransformer())
        {

        }

        public override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @" select * from (
                        Select t.name, t.code, t.frequency as f, t.frequencyMeasure, s.type, s.id From pipeTest t, PipeMillSizeType s
                               where t.isRequired = 0 and t.pipeMillSizeTypeId=s.id and t.frequencyMeasure='Meters') b
                            right join 
                        (Select Sum(p.length) length, p.typeId From Pipe p 
                               group by p.typeId) a
                               on b.id =a.typeId where b.f "+ Constants.PercentForControlOperation +" <= a.length");
            return sb.ToString();
        }
    }
}
