using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Mill
{
    public class Weld : Item
    {
        public Weld()
        {
            this.Welders = new List<Welder>();
        }

        public virtual DateTime Date { get; set; }
        public virtual Pipe Pipe { get; set; }
        public virtual IList<Welder> Welders { get; set; }
    }
}