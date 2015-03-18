﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;

namespace Prizm.Data.DAL.Mapping
{
    public class PipeTestResultMap : SubclassMap<PipeTestResult>
    {
        public PipeTestResultMap()
        {
            Map(x => x.Date).Column("date");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("status");
            Map(x => x.Order).Column("pipeOrder");

            References<PipeTest>(_ => _.Operation).Column("pipeTestId");

            References<Pipe>(_ => _.Pipe).Column("pipeId");

            HasManyToMany(_ => _.Inspectors)
                    .Table("[TestResult_Inspector]")
                    .ParentKeyColumn("resultId")
                    .ChildKeyColumn("inspectorId")
                    .Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}
