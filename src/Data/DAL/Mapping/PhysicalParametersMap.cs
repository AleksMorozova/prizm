using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    class PhysicalParametersMap : SubclassMap<PhysicalParameters>
    {
        public PhysicalParametersMap()
        {
            Table("PhysicalParameters");
        }
    }
}
