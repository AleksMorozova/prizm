using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    public class CannedMessage : Item
    {
        public virtual string Language { get; set; }
        public virtual string Text { get; set; }
        public virtual string IdDefect { get; set; }
    }
}
