using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ReleaseNote
{
    public interface IReleaseNoteRepositories : IDisposable
    {
        IPipeRepository PipeRepo { get; }
        IRailcarRepository RailcarRepo { get; }
        IReleaseNoteRepository ReleaseNoteRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
