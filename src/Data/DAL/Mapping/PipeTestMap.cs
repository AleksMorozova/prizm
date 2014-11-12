using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PipeTestMap : ClassMap<PipeTest>
    {
        public PipeTestMap() 
        {
            Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(_ => _.Code, "code");
            Map(_ => _.Name, "name");
            Map(_ => _.BoolExpected, "boolExpected");
            Map(_ => _.ControlType, "controlType");
            Map(_ => _.IsRequired, "isRequired");
            Map(_ => _.MaxExpected, "maxExpected");
            Map(_ => _.MinExpected, "minExpected");
            Map(_ => _.ResultType, "resultType");
            Map(_ => _.TestSubject, "testSubject");
            References(_=>_.PipeSizeID);

        }
    }
}
