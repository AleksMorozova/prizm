using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Welder : Entity
    {
        public virtual string Certificate { get; set; }
        public virtual DateTime CertificateExpitation { get; set; }
        public virtual string Stamp { get; set; }
        public virtual int Grade { get; set; }

        public virtual PersonName Name { get; set; }
        public virtual ICollection<Weld> Welds { get; set; }

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
    }
}
