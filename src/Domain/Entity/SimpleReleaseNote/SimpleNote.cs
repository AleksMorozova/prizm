using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.SimpleReleaseNote
{
    public class SimpleNote : Item
    {
        public SimpleNote()
        {
            this.Railcars = new List<SimpleRailcar>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual bool Shipped { get; set; }

        public virtual IList<SimpleRailcar> Railcars { get; set; }

        public virtual IList<File> Attachments { get; set; }
    }
}
