using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.DAL.Mapping
{
    public class PipelinePieceMap: ClassMap<PipelinePiece>
    {
        public PipelinePieceMap()
        {
            Id(x => x.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(x => x.Number, "number");

            //UseUnionSubclassForInheritanceMapping();
        }
    }
}
