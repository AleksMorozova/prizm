using Prizm.Data.DAL;
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
   public interface IImportRepository : IDisposable
   {
      IPipeRepository PipeRepo { get; }
      IPlateRepository PlateRepo { get; }
      IHeatRepository HeatRepo { get; }
      IRailcarRepository RailcarRepo { get; }
      IPlateManufacturerRepository PlateManufacturerRepo { get; }
      IMillPipeSizeTypeRepository SizeTypeRepo { get; }
      ISeamTypeRepository SeamTypeRepo { get; }
      IPurchaseOrderRepository PurchaseOrderRepo { get; }
      IFileRepository FileRepo { get; }
      IProjectRepository ProjectRepo { get; }
      IPortionRepository PortionRepo { get; }
   }
}
