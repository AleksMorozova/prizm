using System;
using System.Collections.Generic;
using Domain.Entity.Mill;

namespace Domain.Entity
{
    public class Welder : Item
    {
        public Welder(PersonName name, string certificate, DateTime certifExp, string stamp, int grade) : this()
        {
            this.Name = name;
            this.Certificate = certificate;
            this.CertificateExpitation = certifExp;
            this.Stamp = stamp;
            this.Grade = grade;
        }

        protected Welder()
        {
            this.Welds = new List<Weld>();
        }

        public virtual string Certificate { get; set; }
        public virtual DateTime CertificateExpitation { get; set; }
        public virtual string Stamp { get; set; }
        public virtual int Grade { get; set; }

        public virtual PersonName Name { get; set; }
        public virtual ICollection<Weld> Welds { get; set; }
    }
}