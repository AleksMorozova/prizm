using NHibernate;
using System;
using System.Collections.Generic;

namespace Prizm.Data.DAL
{
    public interface IRepository<TKey, TEntity> : IDisposable where TEntity : class
    {
        IList<KeyValuePair<string, Guid>> GetAllDuplicateEntity(string number);
        TEntity Get(TKey key);
        IList<TEntity> GetAll();
        IList<TEntity> GetByCriteria(NHibernate.Criterion.DetachedCriteria criteria);
        ISQLQuery CreateSQLQuery(string queryString);
        void Clear();
        void Save(TEntity entity);
        void SaveOrUpdate(TEntity entity);
        void Merge(TEntity entity);
        void Delete(TEntity entity);
        void Evict(TEntity entity);
        void Flush();
        void BeginTransaction();
        void Commit();
        void Rollback();
        bool IsTransactionActive();

    }
}