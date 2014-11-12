using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class PipelinePieceMap : SubclassMap<PipelinePiece>
    {
        public PipelinePieceMap()
        {

            Map(x => x.Number).Column("number");
            Map(x => x.Length).Column("length");

        }
    }
}
