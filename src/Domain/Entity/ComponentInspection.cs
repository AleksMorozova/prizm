using Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public interface IUserRepository : IRepository<int, User>
    {
        //User Specific Operation
    }
}
