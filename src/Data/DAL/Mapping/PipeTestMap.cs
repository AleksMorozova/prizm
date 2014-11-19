﻿using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PipeTestMap : SubclassMap<PipeTest>
    {
        public PipeTestMap() 
        {
            Map(_ => _.Code, "code");
            Map(_ => _.Name, "name");
            Map(_ => _.TestSubject, "testSubject");
            Map(_ => _.ControlType, "controlType");       
            Map(_ => _.ResultType, "resultType");
            Map(_ => _.MinExpected, "minExpected");
            Map(_ => _.MaxExpected, "maxExpected");
            Map(_ => _.BoolExpected, "boolExpected");
            Map(_ => _.IsRequired, "isRequired");

            References(_ => _.pipeType).Column("pipeMillSizeTypeId");
        }
    }
}