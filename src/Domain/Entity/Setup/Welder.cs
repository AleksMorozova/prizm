using System;
using System.Collections.Generic;
using Domain.Entity.Mill;
using Domain.Entity.Setup;

namespace Domain.Entity
{
    public class Welder : Item
    {
        public Welder()
        {
           Welds = new List<Weld>();
        }

        public virtual PersonName Name { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual string Stamp { get; set; }
        public virtual int Grade { get; set; }
        public virtual IList<Weld> Welds { get; set; }

        public virtual void CheckExpirationDate() 
        {
            if (Certificate.ExpirationDate < DateTime.Now.Date) 
            {
                this.IsActive = false;
            }

        }
    }
}