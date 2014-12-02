using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domain.Entity;

namespace Data.DAL.Mapping
{
    public class ProjectMap : SubclassMap<Project>
    {
        public ProjectMap()
        {
            Map(x => x.Client).Column("client");
            Map(x => x.MillName).Column("millName");
            Map(x => x.DocumentSizeLimit).Column("documentSizeLimit");      
        }
    }
}
