using Data.DAL;
using Data.DAL.Mill;
using Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PrizmMain.Forms.PipeMill
{
    public interface IMillRepository : IDisposable
    {
        IPipeRepository RepoPipe { get; }
        IPlateRepository RepoPlate { get; }
        IHeatRepository RepoHeat { get; }
        IWeldRepository RepoWeld { get; }
        IMillPipeSizeTypeRepository RepoPipeType { get; }
        IPurchaseOrderRepository RepoPurchaseOrder { get; }
        IWelderRepository WelderRepo { get; }
        IPipeTestResultRepository RepoPipeTestResult { get; }
        IPipeTestRepository RepoPipeTest { get; }
        IInspectorRepository RepoInspector { get; }
        IProjectRepository RepoProject { get; }

        void Commit();
        void BeginTransaction();
    }
}
