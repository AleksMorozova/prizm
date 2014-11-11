using System;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Weld : Item
    {
        public Weld(DateTime date, ICollection<Welder> welders)
        {
            this.Date = date;
            this.Welders = welders;
        }

        protected Weld()
        {
            this.Welders = new List<Welder>();
        }

        public virtual DateTime Date { get; set; }
        public virtual ICollection<Welder> Welders { get; set; }
    }
}