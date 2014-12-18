using System;
using Prizm.Domain.Entity.Mill;
using NHibernate;

namespace Prizm.Data.DAL.Mill
{
    public interface IRailcarRepository : IRepository<Guid, Railcar>
    {
        Railcar GetByNumber(string number);
    }
}