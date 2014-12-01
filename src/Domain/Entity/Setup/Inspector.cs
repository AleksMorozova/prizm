using Domain.Entity.Setup;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Inspector : Item
    {
        public Inspector()
        {
            this.Certificates = new List<InspectorCertificate>();
        }
        public virtual PersonName Name { get; set; }
        public virtual IList<InspectorCertificate> Certificates { get; set; }
    }
}