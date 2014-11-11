using NHibernate;

namespace Data.DAL.Hibernate
{
    public abstract class AbstractHibernateRepository<TKey, TEntity> : IRepository<TKey, TEntity>
    {
        protected readonly ISession session;

        protected AbstractHibernateRepository(ISession session)
        {
            this.session = session;
        }

        public TEntity Get(TKey key)
        {
            return session.Get<TEntity>(key);
        }

        public void Save(TEntity entity)
        {
            session.Save(entity);
        }


        public void SaveOrUpdate(TEntity entity)
        {
            session.SaveOrUpdate(entity);
        }

        public void Delete(TEntity entity)
        {
            session.Delete(entity);
        }

        public void Evict(TEntity entity)
        {
            session.Evict(entity);
        }


        public void Flush()
        {
            session.Flush();
        }

        public void Commit()
        {
            if (IsTransactionActive())
            {
                session.Transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (IsTransactionActive())
            {
                session.Transaction.Rollback();
            }
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public bool IsTransactionActive()
        {
            return session.Transaction.IsActive;
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}