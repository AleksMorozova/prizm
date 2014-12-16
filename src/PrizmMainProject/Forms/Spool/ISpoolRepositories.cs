using Data.DAL.Construction;
using Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Spool
{
    public interface ISpoolRepositories : IDisposable
    {
        ISpoolRepository SpoolRepo { get; }
        IPipeRepository PipeRepo { get; }
        IInspectorRepository RepoInspector { get; }

        void Commit();
        void BeginTransaction();
    }
}
