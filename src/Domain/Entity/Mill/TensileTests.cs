using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public interface IRepository<TKey, TEntity> : IDisposable
    {
       TEntity Get(TKey key);
       void Save(TEntity entity);
       void SaveOrUpdate(TEntity entity);
       void Delete(TEntity entity);
       void Evict(TEntity entity);
       void Flush();
       void BeginTransaction();
       void Commit();
       void Rollback();
       bool IsTransactionActive();
    }
}
