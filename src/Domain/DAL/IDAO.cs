using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Domain.Entity;

namespace Domain.DAL
{
    interface IDAO
    {
        Item Get(Guid id);
        IQueryable<Item> GetAll();
        IQueryable<Item> GetByCriteria(Criteria criteria);
    }
}
