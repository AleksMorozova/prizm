using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    public class ReleaseNote: Item
    {
        public ReleaseNote()
        {
            this.Railcars = new List<Railcar>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual bool Shipped { get; set; }

        public virtual IList<Railcar> Railcars { get; set; }

    }
}
