using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;
using Prizm.DAL.Hibernate;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public class HeatRepositories : IHeatRepositories
    {
        ISession session;
        IHeatRepository heatRepo;
        IPlateManufacturerRepository plateManRepo;
        IFileRepository fileRepo;

        [Inject]
        public HeatRepositories(ISession session)
        {
            this.session = session;
            this.heatRepo = new HeatRepository(session);
            this.plateManRepo = new PlateManufacturerRepository(session);
            this.fileRepo = new FileRepository(session);
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

        public Data.DAL.IFileRepository FileRepo
        { 
            get { return fileRepo; }
        }

        public void Rollback()
        {
            session.Transaction.Rollback();
        }
    }
}
