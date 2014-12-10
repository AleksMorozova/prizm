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
            return new Part()
            {
                Id = (Guid)tuple[0],
                Number = (string)tuple[1],
                Type = (string)tuple[2]
            };
        }

        #endregion

        internal static string BuildSql(System.ComponentModel.BindingList<Common.PartType> partTypes, string number)
        {
            if(partTypes.Count == 0)
            {
                return string.Empty;
            }
            if(!string.IsNullOrWhiteSpace(number))
            {
                number = string.Format("WHERE number LIKE '%{0}%' ",number);
            }

            StringBuilder sb = new StringBuilder();
            List<string> queries = new List<string>();

            foreach(var item in partTypes)
            {
                switch(item)
                {
                    case PrizmMain.Forms.Common.PartType.Undefined:
                        break;
                    case PrizmMain.Forms.Common.PartType.Pipe:
                        queries.Add(string.Format(" SELECT id, number, 'pipe' FROM pipe {0}",number));
                        break;
                    case PrizmMain.Forms.Common.PartType.Spool:
                        queries.Add(string.Format(" SELECT id, number, 'spool' FROM Spool {0}",number));
                        break;
                    case PrizmMain.Forms.Common.PartType.Component:
                        queries.Add(string.Format(" SELECT id, number, 'component' FROM Component {0}", number));
                        break;
                    default:
                        break;
                }
                queries.Add(" UNION ");
            }
            //delete last UNION
            queries.RemoveAt(queries.Count - 1);

            queries.ForEach(x => sb.Append(x));

            return sb.ToString();



        }
    }
}
