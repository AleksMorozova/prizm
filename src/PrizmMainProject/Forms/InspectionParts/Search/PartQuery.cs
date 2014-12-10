using NHibernate.Transform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class PartQuery : IResultTransformer
    {
        public static readonly string Sql = "";
        public static readonly PartQuery Transformer = new PartQuery();

        private PartQuery()
        { }

        #region IResultTransformer Members

        public IList TransformList(IList collection)
        {
            return collection;
        }

        public object TransformTuple(object[] tuple, string[] aliases)
        {
            return new Part
            {
                Id = (Guid)tuple[0],
                Number = (string)tuple[0],
                Type = (string)tuple[1]
            };
        }

        #endregion
    }
}
