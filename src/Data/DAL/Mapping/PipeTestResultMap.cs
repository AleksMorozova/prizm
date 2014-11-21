using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Domain.Entity.Mill;
using Domain.Entity.Setup;

namespace Data.DAL.Mapping
{
    public class PipeTestResultMap : SubclassMap<PipeTestResult>
    {
        public PipeTestResultMap()
        {
            Map(x => x.Date).Column("date");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("status");

            References<PipeTest>(_ => _.Operation).Column("pipeTestId");
            References<Pipe>(_ => _.Pipe).Column("pipeId");
        }
    }
}
