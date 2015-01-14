using NHibernate;
using Ninject;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Import
{
   public class ImportRepository : IImportRepository
   {
      readonly IPipeRepository pipeRepo;
      readonly IPlateRepository plateRepo;
      readonly IHeatRepository heatRepo;
      readonly IRailcarRepository railcarRepo;
      readonly IPlateManufacturerRepository plateManufacturerRepo;
      readonly IMillPipeSizeTypeRepository sizeTypeRepo;
      readonly ISeamTypeRepository seamTypeRepo;
      readonly IPurchaseOrderRepository orderRepo;
      readonly IFileRepository fileRepo;

      [Inject]
      public ImportRepository(ISession session)
      {
         pipeRepo = new PipeRepository(session);
         plateRepo = new PlateRepository(session);
         heatRepo = new HeatRepository(session);
         railcarRepo = new RailcarRepository(session);
         plateManufacturerRepo = new PlateManufacturerRepository(session);
         sizeTypeRepo = new MillPipeSizeTypeRepository(session);
         seamTypeRepo = new SeamTypeRepository(session);
         orderRepo = new PurchaseOrderRepository(session);
         fileRepo = new FileRepository(session);
      }

      public IPipeRepository PipeRepo
      {
         get { return pipeRepo; }
      }

      public IPlateRepository PlateRepo
      {
         get { return plateRepo; }
      }

      public IHeatRepository HeatRepo
      {
         get { return heatRepo; }
      }

      public IRailcarRepository RailcarRepo
      {
         get { return railcarRepo; }
      }

      public IPlateManufacturerRepository PlateManufacturerRepo
      {
         get { return plateManufacturerRepo; }
      }

      public IMillPipeSizeTypeRepository SizeTypeRepo
      {
         get { return sizeTypeRepo; }
      }

      public ISeamTypeRepository SeamTypeRepo
      {
         get { return seamTypeRepo; }
      }

      public IPurchaseOrderRepository PurchaseOrderRepo
      {
         get { return orderRepo; }
      }

      public Data.DAL.IFileRepository FileRepo
      {
         get { return fileRepo; }
      }

      public void Dispose()
      {
         pipeRepo.Dispose();
         plateRepo.Dispose();
         heatRepo.Dispose();
         railcarRepo.Dispose();
         plateManufacturerRepo.Dispose();
         sizeTypeRepo.Dispose();
         seamTypeRepo.Dispose();
         orderRepo.Dispose();
         fileRepo.Dispose();
      }


      
   }
}
