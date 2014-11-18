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
    public class PurchaseOrderRepository : AbstractHibernateRepository<Guid, PurchaseOrder>, IPurchaseOrderRepository
    {
        [Inject]
        public PurchaseOrderRepository(ISession session)
            : base(session)
        {

        }

        public PurchaseOrder GetByNumber(string number)
        {
            return session.QueryOver<PurchaseOrder>().Where(_ => _.Number == number).Take(1).SingleOrDefault();
        }
    }
}
