using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Domain.Entity.AuditTrail
{
    public class AuditableChemicalCompositionMap : ClassMap<AuditableChemicalComposition>
    {
        public AuditableChemicalCompositionMap()
        {
            Id(a => a.Id);
            Map(a => a.Number);
        }
    }
}
