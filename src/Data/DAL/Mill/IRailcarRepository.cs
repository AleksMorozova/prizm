using System;
using Domain.Entity.Mill;
using NHibernate;

namespace Data.DAL.Mill
{
    public interface IRailcarRepository : IRepository<Guid, Railcar>
    {
        Railcar GetByNumber(string number);
    }
}