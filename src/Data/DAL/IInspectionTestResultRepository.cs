using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface IInspectionTestResultRepository : IRepository <Guid, InspectionTestResult>
    {
        IList<InspectionTestResult> GetByPartId(Guid partId);
    }
}
