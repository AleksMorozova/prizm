using Prizm.Data.DAL;
using Prizm.Data.DAL.Security;
using Prizm.Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public interface IFirstSetupRepo : IDisposable
    {
        IUserRepository UserRepo { get; }
        IProjectRepository ProjectRepo { get; }
        ICertificateTypeRepository CertificateTypeRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
