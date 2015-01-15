﻿using NHibernate;
using Ninject;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL.Synch;
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
      readonly IProjectRepository projectRepo;
      readonly IPortionRepository portionRepo;

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
         projectRepo = new ProjectRepository(session);
         portionRepo = new PortionRepository(session);
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

      public IFileRepository FileRepo
      {
         get { return fileRepo; }
      }

      public IProjectRepository ProjectRepo
      {
         get { return projectRepo; }
      }

      public IPortionRepository PortionRepo
      {
         get { return portionRepo; }
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
         projectRepo.Dispose();
         portionRepo.Dispose();
      }


      
   }
}
