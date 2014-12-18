using Data.DAL.Mill;
using Domain.Entity;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class WelderRepository :AbstractHibernateRepository<Guid,Welder>, IWelderRepository
    {
        [Inject]
        public WelderRepository(ISession session)
            : base(session)
        {

        }

        public void RefreshWelder()
        {
            try
            {
                IList<Welder> list= session.QueryOver<Welder>().Where(_=>_.Certificate.ExpirationDate<DateTime.Now.Date).List<Welder>();
                foreach(Welder w in list)
                {
                    w.IsActive = false;
                    session.Update(w);
                }
            }
            catch 
            {

            }
        }
    }
}
