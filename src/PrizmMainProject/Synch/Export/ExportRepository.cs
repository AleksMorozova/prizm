using NHibernate;
using Ninject;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Synch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Export
{
   public class ExportRepository : IExportRepository
   {
      readonly IPipeRepository pipeRepo;
      readonly IPortionRepository portionRepo;
      readonly IProjectRepository projectRepo;

      [Inject]
      public ExportRepository(ISession session)
      {
         pipeRepo = new PipeRepository(session);
         portionRepo = new PortionRepository(session);
         projectRepo = new ProjectRepository(session);
      }

      public IPipeRepository PipeRepo
      {
         get { return pipeRepo; }
      }

      public IPortionRepository PortionRepo
      {
         get { return portionRepo; }
      }

      public IProjectRepository ProjectRepo
      {
         get { return projectRepo; }
      }

      public void Dispose()
      {
         pipeRepo.Dispose();
         portionRepo.Dispose();
         projectRepo.Dispose();
      }
   }
}
