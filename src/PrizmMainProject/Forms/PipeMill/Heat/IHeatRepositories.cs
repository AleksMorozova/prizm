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

        void Commit();
        void BeginTransaction();
    }
}
