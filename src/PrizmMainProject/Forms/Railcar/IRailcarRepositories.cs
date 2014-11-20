using Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Railcar
{
    public interface IRailcarRepositories : IDisposable
    {
        IPipeRepository PipeRepo { get; }
        IRailcarRepository RailcarRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
