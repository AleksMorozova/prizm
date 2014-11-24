using System;
using System.Collections.Generic;
using Domain.Entity.Mill;
using Domain.Entity.Setup;

namespace Domain.Entity
{
    public class Inspector : Item
    {
        public Inspector()
        {
        }

        public virtual PersonName Name { get; set; }
        public virtual string Certificate { get; set; }
        public virtual DateTime? CertificateExpiration { get; set; }
    }
}