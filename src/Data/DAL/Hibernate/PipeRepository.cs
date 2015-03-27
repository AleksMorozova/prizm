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
using NHibernate.Linq;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.SqlCommand;
using Prizm.Domain.Entity.Setup;

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
                PipeTestResult result = null;
                Inspector inspector = null;
                Certificate certificate = null;
                Coat coat = null;
                Weld weld = null;
                Spool spool = null;

                var q = session.QueryOver<Pipe>()
                    .Where(n => ((n.Status == PipeMillStatus.Stocked) && (n.IsActive == true) && n.Railcar == null))
                    .JoinAlias(r => r.PipeTestResult, () => result, JoinType.LeftOuterJoin)
                    .JoinAlias(() => result.Inspectors, () => inspector, JoinType.LeftOuterJoin)
                    .JoinAlias(() => inspector.Certificates, () => certificate, JoinType.LeftOuterJoin)
                    .JoinAlias(r => r.Coats, () => coat,JoinType.LeftOuterJoin)
                    .JoinAlias(r => r.Welds, () => weld, JoinType.LeftOuterJoin)
                    .JoinAlias(r => r.Spools, () => spool, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity)
                    .List<Pipe>();

                return q;

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
              // PipeTestResult result = null;
              // Inspector inspector = null;
              // Certificate certificate = null;
              // var q = session.QueryOver<Pipe>()
              //     .Where(n => ((n.ToExport == true)))
              //     .JoinAlias(r => r.PipeTestResult, () => result, JoinType.LeftOuterJoin)
              //     .JoinAlias(() => result.Inspectors, () => inspector, JoinType.LeftOuterJoin)
              //     .JoinAlias(() => inspector.Certificates, () => certificate, JoinType.LeftOuterJoin)
              //     .TransformUsing(Transformers.DistinctRootEntity)
              //     .List<Pipe>();
              //return q;

               Plate plate = null;
               Heat heat = null;
               PlateManufacturer plateMan = null;
               PipeMillSizeType type = null;
               PipeTest tests = null;
               PipeTestResult result = null;
               Inspector inspector = null;
               Certificate certificate = null;
               Project proj = null;
               SeamType seam = null;
               Spool spool = null;
               File attach = null;
               
               var q = session.QueryOver<Pipe>()
                   .Where(n => ((n.ToExport == true)))

                   .JoinAlias(r => r.PipeTestResult, () => result, JoinType.LeftOuterJoin)
                   .JoinAlias(() => result.Inspectors, () => inspector, JoinType.LeftOuterJoin)
                   .JoinAlias(() => inspector.Certificates, () => certificate, JoinType.LeftOuterJoin)

                   .JoinAlias(p => p.Plate, () => plate, JoinType.LeftOuterJoin)
                   .JoinAlias(() => plate.Heat, () => heat, JoinType.LeftOuterJoin)
                   .JoinAlias(() => heat.PlateManufacturer, () => plateMan, JoinType.LeftOuterJoin)

                   .JoinAlias(t => t.Type, () => type, JoinType.LeftOuterJoin)
                   .JoinAlias(() => type.SeamType, () => seam, JoinType.LeftOuterJoin)
                   .JoinAlias(() => type.PipeTests, () => tests, JoinType.LeftOuterJoin)

                   .JoinAlias(t => t.Spools, () => spool, JoinType.LeftOuterJoin)
                   .JoinAlias(t => t.Attachments, () => attach, JoinType.LeftOuterJoin)
                   .JoinAlias(t => t.Project, () => proj, JoinType.LeftOuterJoin)

                   .Fetch(o => o.PurchaseOrder).Eager
                   .Fetch(r => r.Railcar).Eager

                   .TransformUsing(Transformers.DistinctRootEntity)
                   .List<Pipe>();
               return q;
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
