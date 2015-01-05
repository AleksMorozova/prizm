using NHibernate.Transform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Railcar.Search
{
    public class RailcarQuery : IResultTransformer
    {
        public static readonly RailcarQuery Transformer = new RailcarQuery();

        private RailcarQuery(){ }



        public IList TransformList(IList collection)
        {
            return collection;
        }

        public object TransformTuple(object[] tuple, string[] aliases)
        {
            return
                new Railcar()
                {
                    Id = (Guid)tuple[0],
                    Number = (string)tuple[1],
                    Certificate = (string)tuple[2],
                    Destination = (string)tuple[3],
                    ShippingDate = (DateTime?)tuple[4],
                    IsShipped = (bool)tuple[5]
                };
        }


        internal static string BuildSql(
            string RailcarNumber,
            string Certificate,
            string Receiver,
            DateTime ShippingDate)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(
                @"  SELECT 
                        [id], 
                        [number], 
                        [certificate], 
                        [destination], 
                        [shippingDate], 
                        [isShipped]  
                    FROM 
                        [Railcar] ");

            sb.Append(string.Format(@" WHERE [number] LIKE N'%{0}%' ESCAPE '\' ", RailcarNumber.EscapeCharacters()));
            sb.Append(string.Format(@"AND [certificate] LIKE N'%{0}%' ESCAPE '\' ", Certificate.EscapeCharacters()));
            sb.Append(string.Format(@"AND [destination] LIKE N'%{0}%' ESCAPE '\' ", Receiver.EscapeCharacters()));

            if (ShippingDate != DateTime.MinValue)
            {
                sb.Append(string.Format(
                    @"AND [shippingDate] = CAST('{0}' as date)", ShippingDate));
            }
            return sb.ToString();
        }
    }
}
