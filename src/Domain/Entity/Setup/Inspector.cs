using Domain.Entity.Setup;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Inspector : Item
    {
        public virtual PersonName Name { get; set; }
        public virtual InspectorCertificate Certificate { get; set; }
    }
}