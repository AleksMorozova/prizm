using System;
using System.Collections.Generic;

namespace Data.DAL
{
    public interface IRepository<TKey, TEntity> : IDisposable where TEntity : class
    {
        TEntity Get(TKey key);
        ICollection<TEntity> GetAll();
        ICollection<TEntity> GetByCriteria(NHibernate.Criterion.DetachedCriteria criteria);
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