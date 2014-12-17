using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class ChemicalCompositionRepository : AbstractHibernateRepository<Guid, ChemicalComposition>, 
        IChemicalCompositionRepository
    {
        [Inject]
        public ChemicalCompositionRepository(ISession session)
            : base(session)
        {

        }

        public IList<ChemicalComposition> GetByHeatId(Guid heatId)
        {
            return session.QueryOver<ChemicalComposition>().Where(x => x.Id == heatId).List();
        }
    }
}
