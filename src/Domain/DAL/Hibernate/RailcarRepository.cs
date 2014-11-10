using Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL.Hibernate
{
   public class RailcarRepository : AbstractHibernateRepository<Guid, Railcar>, IRailcarRepository
   {
      [Inject]
      public RailcarRepository(ISession session)
         : base(session)
      {
      }
   }
}
