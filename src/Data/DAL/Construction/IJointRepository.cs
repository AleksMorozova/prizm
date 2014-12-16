using Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Construction
{
    public interface IJointRepository : IRepository<Guid, Joint>
    {
        IList<Joint> GetActiveByNumber(Joint joint);
    }
}
