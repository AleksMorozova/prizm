using Domain.Entity.Construction;
using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class JointActionResultMap : SubclassMap<JointActionResult>
    {
        public JointActionResultMap()
        {
            Map(_ => _.Date).Column("date");
            Map(_ => _.IsCompleted).Column("isCompleted");

            References<JointOperation>(_ => _.Operation).Column("jointOperationId");
            References<Joint>(_ => _.Joint).Column("jointId");
        }
    }
}
