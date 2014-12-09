using Domain.Entity.Construction;
using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class SpoolMap: ClassMap<Spool>
    {
        public SpoolMap()
        {
            Map(_ => _.PipeNumber).Column("pipeNumber");

            References<Pipe>(x => x.Pipe).Column("pipeId");
        }
    }
}
