using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mill
{
    public interface IPipeRepository : IRepository<Guid, Pipe>
    {
        Pipe GetByNumber(string number);
        IList<Pipe> GetStored();
        IList<Pipe> GetActiveByNumber(Pipe pipe);
        IList<Pipe> GetPipesToExport();
        IList<Pipe> GetAvailableForCutPipes();
    }
}
