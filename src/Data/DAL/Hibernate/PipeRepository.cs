using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Data.DAL.Hibernate
{
    public class PipeRepository : AbstractHibernateRepository<Guid, Pipe>, IPipeRepository
    {
        [Inject]
        public PipeRepository(ISession session)
            : base(session)
        {

        }

        public Pipe GetByNumber(string number)
        {
            try
            {
                return session.QueryOver<Pipe>().Where(n => n.Number == number).SingleOrDefault();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByNumber", ex);
            }
        }


        public IList<Pipe> GetStored()
        {
            try
            {
                return session.QueryOver<Pipe>().Where(n => ((n.Status == PipeMillStatus.Stocked) && (n.IsActive==true))).List<Pipe>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetStored", ex);
            }

        }

        public IList<Pipe> GetActiveByNumber(Pipe pipe)
        {
            try
            {
                return session
                    .QueryOver<Pipe>()
                    .Where(x => x.IsActive && x.Number == pipe.Number && x.Id != pipe.Id)
                    .List<Pipe>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }

        }



        public IList<Pipe> GetPipesToExport()
        {
           try
           {
              return session
                 .QueryOver<Pipe>()
                 .Where(p => p.ToExport)
                 .List<Pipe>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetPipesToExport", ex);
           }
        }


        public IList<Pipe> GetAvailableForCutPipes()
        {
            try
            {
                return session
                    .QueryOver<Pipe>()
                    .Where(x => (x.ConstructionStatus == PartConstructionStatus.Pending) && (x.InspectionStatus == PartInspectionStatus.Accepted) && x.IsActive == true)
                    .List<Pipe>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }

        }
    }
}
