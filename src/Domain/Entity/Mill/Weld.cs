using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Weld
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime Date { get; set; }
        ICollection<Welder> Welders { get; set; }

        public Weld()
        {
            this.Welders = new List<Welder>();
        }
    }
}
