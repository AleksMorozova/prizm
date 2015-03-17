using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface INORNotificationRepository
    {
        List<NotRequiredOperation> GetAllNotRequiredOperation();
        List<KeyValuePair<DateTime, Guid>> GetAllNotRequiredOperationResult();
        KeyValuePair<Guid, float> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, string measure);
    }
}
