using NHibernate.Transform;
using Prizm.Main.Forms.Notifications.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Data
{
    class NotRequiredOperationTransformer : IResultTransformer
    {
            public System.Collections.IList TransformList(System.Collections.IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {
                return NotRequiredOperationManager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetUnitsLeft(tuple), GetTextInformation(tuple));
            }

            public Guid GetId(object[] tuple)
            {
                return (Guid)tuple[5];
            }

            public string GetOwnerName(object[] tuple)
            {
                return tuple[4].ToString() + ":" + tuple[1].ToString() + "-" + tuple[0].ToString();
            }

            public float GetUnitsLeft(object[] tuple)
            {
                return (float)Convert.ChangeType(tuple[6], typeof(float)) - (float)Convert.ChangeType(tuple[2], typeof(float));
            }

            public string GetTextInformation(object[] tuple)
            {
                return tuple[6].ToString();
            }
    }
}
