using NHibernate;
using Ninject;
using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;

namespace Prizm.Data.DAL.Hibernate
{
    public class InspectionTestResultRepository : AbstractHibernateRepository<Guid, InspectionTestResult>, IInspectionTestResultRepository
    {
         [Inject]
        public InspectionTestResultRepository(ISession session)
            : base(session)
        {
        }

        /// <summary>
        /// Is used SQL query instead of queryOver because we cannot form instance on Domain.Entity.Part class with defined id
        /// </summary>
        public IList<InspectionTestResult> GetByPartId(Guid partId)
        {
            ISQLQuery query = session.CreateSQLQuery(
                    @"select i.* " +
                    "from InspectionTestResult i " +
                    "where i.partId = :PartId");

            query.SetString("PartId", partId.ToString());
            query.AddEntity(typeof(InspectionTestResult));

            IList<InspectionTestResult> results = query.List<InspectionTestResult>();
          
            return results;
        }
    }
}
