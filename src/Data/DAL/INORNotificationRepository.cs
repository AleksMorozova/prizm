using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
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
        KeyValuePair<Guid, float> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, FrequencyMeasure measure);
        KeyValuePair<Guid, float> GetUnitsProducedSinceLastDateTest(Guid testId, FrequencyMeasure measure);
    }
}
