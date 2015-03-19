using Prizm.Domain.Entity.Construction;
using NHibernate.Transform;
using Prizm.Main.Common;
using Prizm.Main.Forms.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Parts.Search
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
                Type = new EnumWrapper<PartType>(tuple[3].ToString()),
                IsActive=Boolean.Parse(tuple[2].ToString())
            };
        }

        #endregion

        internal static string BuildSql(System.ComponentModel.BindingList<PartType> partTypes, string number, ActivityCriteria Activity)
        {
            if(partTypes.Count == 0)
            {
                return " ";
            }
            if (!string.IsNullOrWhiteSpace(number))
            {
                if (Activity == ActivityCriteria.StatusActive)
                {
                    number = string.Format(@"WHERE isActive = N'{0}' and number LIKE N'%{1}%' ESCAPE '\' ", true ,number.EscapeCharacters()); 
                }
                else if (Activity == ActivityCriteria.StatusUnactive)
                {
                    number = string.Format(@"WHERE isActive = N'{0}' and number LIKE N'%{1}%' ESCAPE '\' ", false, number.EscapeCharacters());
                }
                else
                {
                    number = string.Format(@"WHERE number LIKE N'%{0}%' ESCAPE '\' ", number.EscapeCharacters());
                }
            }

            else
            {
                if (Activity == ActivityCriteria.StatusActive)
                {
                    number = string.Format(@"WHERE isActive = N'{0}' ", true);
                }
                else if (Activity == ActivityCriteria.StatusUnactive)
                {
                    number = string.Format(@"WHERE isActive = N'{0}' ", false);
                }
              
            }

            StringBuilder sb = new StringBuilder();
            List<string> queries = new List<string>();

            foreach(var item in partTypes)
            {
                switch(item)
                {
                    case PartType.Undefined:
                        break;
                    case PartType.Pipe:
                        queries.Add(string.Format(" SELECT id, number, isActive,'{0}' FROM pipe {1}", PartType.Pipe, number));
                        break;
                    case PartType.Spool:
                        queries.Add(string.Format(" SELECT id, number, isActive, '{0}' FROM Spool {1}", PartType.Spool, number));
                        break;
                    case PartType.Component:
                        queries.Add(string.Format(" SELECT id, number, isActive, '{0}' FROM Component {1}",PartType.Component, number));
                        break;
                    default:
                        break;
                }
                queries.Add(" UNION ");
            }
            //delete last UNION
            queries.RemoveAt(queries.Count - 1);

            queries.Add(" ORDER BY number ASC ");

            queries.ForEach(x => sb.Append(x));

            return sb.ToString();
        }

        internal static string BuildSqlForInspection(string number)
        {
            if (!string.IsNullOrWhiteSpace(number))
            {
                number = string.Format(@"WHERE number LIKE N'%{0}%' ESCAPE '\' ", number.EscapeCharacters());
            }
            return string.Format(
                                @"SELECT id, number, isActive,'{1}' FROM Pipe {0}
                                UNION ALL
                                SELECT id, number, isActive,'{2}' FROM Spool {0}
                                UNION ALL
                                SELECT id, number, isActive,'{3}' FROM Component {0}  ORDER BY number ASC ", number, PartType.Pipe, PartType.Spool, PartType.Component
                                );


        }
    }
}
