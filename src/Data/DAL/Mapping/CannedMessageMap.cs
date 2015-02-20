using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class CannedMessageMap : SubclassMap<CannedMessage>
    {
        public CannedMessageMap()
        {
            Map(_ => _.Language).Column("[language]");
            Map(_ => _.Text).Column("[text]");
            Map(_ => _.IdDefect).Column("[idDefect]");
        }
    }
}
