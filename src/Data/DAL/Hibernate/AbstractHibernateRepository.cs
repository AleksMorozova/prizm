using NHibernate;
using NHibernate.Exceptions;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;

namespace Prizm.Data.DAL.Hibernate
{
    public abstract class AbstractHibernateRepository<TKey, TEntity> : IRepository<TKey, TEntity>
        where TEntity : class
    {
        protected readonly ISession session;

        protected AbstractHibernateRepository(ISession session)
        {
            this.session = session;
        }

        public TEntity Get(TKey key)
        {
            try
            {
                return session.Get<TEntity>(key);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }

        public void Save(TEntity entity)
        {
            try
            {
                session.Save(entity);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Save", ex);
            }
        }

        public virtual IList<TEntity> GetAll()
        {
            try
            {
                return session.CreateCriteria<TEntity>().List<TEntity>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetAll", ex);
            }
        }

        public IList<TEntity> GetByCriteria(NHibernate.Criterion.DetachedCriteria criteria)
        {
            try
            {
                return criteria.GetExecutableCriteria(session).List<TEntity>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByCriteria", ex);
            }
        }

        public void SaveOrUpdate(TEntity entity)
        {
            try
            {
                session.SaveOrUpdate(entity);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("SaveOrUpdate", ex);
            }
        }

        public void Merge(TEntity entity)
        {
            try
            {
                session.Merge(entity);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Merge", ex);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                session.Delete(entity);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Delete", ex);
            }
        }

        public void Evict(TEntity entity)
        {
            try
            {
                session.Evict(entity);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Evict", ex);
            }
        }

        public void Flush()
        {
            try
            {
                session.Flush();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Flush", ex);
            }
        }

        public void Commit()
        {
            if (IsTransactionActive())
            {
                try
                {
                    session.Transaction.Commit();
                }
                catch (GenericADOException ex)
                {
                    throw new RepositoryException("Commit", ex);
                }
            }
        }

        public void Rollback()
        {
            if (IsTransactionActive())
            {
                try
                {
                    session.Transaction.Rollback();
                }
                catch (GenericADOException ex)
                {
                    throw new RepositoryException("Rollback", ex);
                }
            }
        }

        public void BeginTransaction()
        {
            try
            {
                session.BeginTransaction();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("BeginTransaction", ex);
            }
        }

        public bool IsTransactionActive()
        {
            try
            {
                return session.Transaction.IsActive;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("IsTransactionActive", ex);
            }
        }

        public void Dispose()
        {
            try
            {
                session.Dispose();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Dispose", ex);
            }
        }


        public void Clear()
        {
            try
            {
                session.Clear();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Clear", ex);
            }
        }

        public ISQLQuery CreateSQLQuery(string queryString)
        {
            try
            {
                return session.CreateSQLQuery(queryString);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("CreateSQLQuery", ex);
            }
        }

        public IList<KeyValuePair<string, Guid>> GetAllDuplicateEntity(string number)
        {

            try
            {
                var l = new List<KeyValuePair<string, Guid>>();

                IList<Pipe> t = session.QueryOver<Pipe>().Where(x => x.IsActive && x.Number == number).List<Pipe>();
                foreach (Pipe pipe in t)
                {
                    l.Add(new KeyValuePair<string, Guid>("Pipe", pipe.Id));
                }


                IList<Component> c = session.QueryOver<Component>().Where(x => x.IsActive && x.Number == number).List<Component>();
                foreach (Component comp in c)
                {
                    l.Add(new KeyValuePair<string, Guid>("Component", comp.Id));

                }

                IList<Spool> s = session.QueryOver<Spool>().Where(x => x.IsActive && x.Number == number).List<Spool>();
                foreach (Spool spool in s)
                {
                    l.Add(new KeyValuePair<string, Guid>("Spool", spool.Id));
                }


                IList<Joint> j = session.QueryOver<Joint>().Where(x => x.IsActive && x.Number == number).List<Joint>();
                foreach (Joint joint in j)
                {
                    l.Add(new KeyValuePair<string, Guid>("Joint", joint.Id));
                }

                return l;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }
    }
}