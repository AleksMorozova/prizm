using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Security;

namespace Prizm.Main.Forms.Settings
{
   public interface ISettingsRepositories : IDisposable
   {
      IWelderRepository WelderRepo { get; }
      IMillPipeSizeTypeRepository PipeSizeTypeRepo { get; }
      IPipeTestRepository PipeTestRepo { get; }
      IInspectorRepository InspectorRepo { get; }
      IProjectRepository ProjectRepo { get; }
      IPlateManufacturerRepository PlateManufacturerRepo { get; }
      IRoleRepository RoleRepo { get; }
      IUserRepository UserRepo { get; }
      IPermissionRepository PermissionRepo { get; }
      IJointOperationRepository JointRepo { get; }
      ICategoryRepository СategoryRepo { get; }

      void Commit();
      void BeginTransaction();
   }
}
