using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domain.Entity;

namespace Data.DAL.Mapping
{
    public class TestResultMap : SubclassMap<TestResult<Enum>>
    {
        public TestResultMap()
        {
            Map(x => x.Date).Column("date");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("value");
            HasManyToMany(x => x.Inspectors).Cascade.All().Table("TestResult_Inspector");
        }
    }
}
