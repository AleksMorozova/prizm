using Prizm.Data.DAL;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Synch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Export
{
   public interface IExportRepository : IDisposable
   {
      IPipeRepository PipeRepo { get; }
      IPortionRepository PortionRepo { get; }
      IProjectRepository ProjectRepo { get; }
   }
}
