using Data.DAL.Mill;
using Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class ChemicalCompositionRepository : AbstractHibernateRepository<Guid, ChemicalComposition>, 
        IChemicalCompositionRepository
    {
        [Inject]
        public ChemicalCompositionRepository(ISession session)
            : base(session)
        {

        }
    }
}
