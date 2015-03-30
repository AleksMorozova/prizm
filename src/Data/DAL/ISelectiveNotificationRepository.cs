using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface ISelectiveNotificationRepository
    {
        IList<SelectiveOperation> GetAllSelectiveOperation();
        IList<KeyValuePair<Guid, int>> GetPipesCountPerMillSizeType();
    }
}
