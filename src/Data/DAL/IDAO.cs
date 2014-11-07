using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Domain.Entity;

namespace Domain.DAL
{
    interface IDAO<TItem> where TItem : Item
    {
        TItem Get(Guid id);
        IQueryable<TItem> GetAll();
        
        //FIX: add nHibernate for criteria
        //IQueryable<TItem> GetByCriteria(Criteria criteria);

        TItem Insert(TItem item);
        bool Save(TItem item);

        void Delete(TItem item);
        void Delete(Guid id);
    }
}
