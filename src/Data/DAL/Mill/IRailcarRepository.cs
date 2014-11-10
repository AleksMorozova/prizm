using Data.DAL;
using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
   public interface IRailcarRepository : IRepository<Guid, Railcar>
   {
   }
}
