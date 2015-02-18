using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Spool
{
    public interface ISpoolRepositories : IDisposable
    {
        ISpoolRepository SpoolRepo { get; }
        IPipeRepository PipeRepo { get; }
        IInspectorRepository RepoInspector { get; }
        IFileRepository FileRepo { get; }

        void Commit();
        void BeginTransaction();
        void Rollback();
    }
}
