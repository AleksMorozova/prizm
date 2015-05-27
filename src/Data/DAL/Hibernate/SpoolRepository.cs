using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class SpoolRepository : AbstractHibernateRepository<Guid, Spool>, ISpoolRepository
    {
        [Inject]
        public SpoolRepository(ISession session)
            : base(session)
        {

        }

        public IList<Spool> GetAllSpoolFromPipe(string number)
        {
            try
            {
                return session
                    .QueryOver<Spool>()
                    .Where(x => x.PipeNumber == number)
                    .List<Spool>(); //.Count;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }

        }

        public IList<Spool> GetActiveByNumber(Spool spool)
        {
            try
            {
                return session
                    .QueryOver<Spool>()
                    .Where(x => x.IsActive && x.Number == spool.Number && x.Id != spool.Id)
                    .List<Spool>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }

        public IList<string> GetActiveByNumber(string number)
        {
            try
            {
                var l = new List<string>();

                IList<Pipe> t = session.QueryOver<Pipe>().Where(x => x.IsActive && x.Number == number).List<Pipe>();
                foreach (Pipe p in t)
                {
                    l.Add("Pipe");
                }


                IList<Component> c = session.QueryOver<Component>().Where(x => x.IsActive && x.Number == number).List<Component>();
                foreach (Component comp in c)
                {
                    l.Add("Component");
                }

                IList<Spool> s = session.QueryOver<Spool>().Where(x => x.IsActive && x.Number == number).List<Spool>();
                foreach (Spool spool in s)
                {
                    l.Add("Spool");
                }

                return l;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }

        //public int GetActiveByNumber(string number)
        //{
        //    try
        //    {
        //        int p = session
        //            .QueryOver<Pipe>()
        //            .Where(x => x.IsActive && x.Number == number)
        //            .List<Pipe>().Count();

        //        int c = session.QueryOver<Component>()
        //            .Where(x => x.IsActive && x.Number == number)
        //            .List<Component>().Count();

        //        int s = session
        //            .QueryOver<Spool>()
        //            .Where(x => x.IsActive && x.Number == number)
        //            .List<Spool>().Count();

        //        return p + c + s;
        //    }
        //    catch (GenericADOException ex)
        //    {
        //        throw new RepositoryException("Get", ex);
        //    }
        //}
    
    }
}
