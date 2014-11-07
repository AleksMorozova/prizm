using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.AuditTrail
{
    public class AuditableChemicalComposition : Domain.Entity.Mill.ChemicalComposition, Domain.Entity.AuditTrail.IAuditable
    {
        public virtual Guid GetID()
        {
            return Guid.Parse("341b7199-a9c2-4991-bc4b-a58337d94d16");
        }
        public virtual string GetUser()
        {
            return "";
        }

    }
}