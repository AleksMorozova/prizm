using PrizmMain.Common;
using PrizmMain.Forms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class Part
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public EnumWrapper<PartType> Type { get; set; }
    }
}
