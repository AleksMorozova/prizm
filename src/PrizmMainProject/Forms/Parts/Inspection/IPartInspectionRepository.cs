using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public interface IPartInspectionRepository : IDisposable
    {
        IInspectionTestResultRepository RepoInspectionTestResult { get; } 
        IInspectorRepository RepoInspector { get; }
        IPipeRepository RepoPipe { get; }
        ISpoolRepository RepoSpool { get; }
        IComponentRepository RepoComponent { get; }
        void Commit();
        void BeginTransaction();
    }
}
