using Prizm.Domain.Entity.Construction;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Search
{
    public class Part
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public EnumWrapper<PartType> Type { get; set; }
    }
}
