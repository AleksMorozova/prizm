using Prizm.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ExternalFile
{
    public interface IExternalFilesRepositories : IDisposable
    {
        IFileRepository FileRepo { get; set; }
        IProjectRepository ProjectRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
