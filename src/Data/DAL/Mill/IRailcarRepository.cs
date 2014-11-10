using System;
using Domain.Entity.Mill;

namespace Data.DAL
{
    public interface IRailcarRepository : IRepository<Guid, Railcar>
    {
    }
}