using Data.DAL.Hibernate;
using Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatRepositories : IHeatRepositories
    {
        ISession session;
        IHeatRepository heatRepo;
        IPlateManufacturerRepository plateManRepo;

        [Inject]
        public HeatRepositories(ISession session)
        {
            this.session = session;
            this.heatRepo = new HeatRepository(session);
            this.plateManRepo = new PlateManufacturerRepository(session);
        }

        public IHeatRepository HeatRepo
        {
            get { return heatRepo; }
        }

        public IPlateManufacturerRepository PlateManRepo
        {
            get { return plateManRepo; }
        }

        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Dispose()
        {
            session.Dispose();
        }



    }
}
