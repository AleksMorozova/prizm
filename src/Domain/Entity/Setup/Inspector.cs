using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity
{
    public class Inspector : Item
    {
        public Inspector()
        {
            this.Certificates = new List<InspectorCertificate>();
        }
        public virtual PersonName Name { get; set; }
        public virtual IList<InspectorCertificate> Certificates { get; set; }

        public virtual void CheckExpirationDate()
        {
            foreach (InspectorCertificate c in this.Certificates)
            {
                if (c.Certificate.ExpirationDate< DateTime.Now.Date)
                {
                    this.IsActive = false;
                }
            }

        }
    }
}