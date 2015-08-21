using Prizm.Data.DAL;
using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public interface IHeatRepositories : IDisposable
    {
        IHeatRepository HeatRepo { get; }
        IPlateManufacturerRepository PlateManRepo { get; }
        IFileRepository FileRepo { get; }

        void Commit();
        void BeginTransaction();
        void Rollback();
    }
}
