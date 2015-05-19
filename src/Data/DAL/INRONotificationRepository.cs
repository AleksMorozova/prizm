using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface INRONotificationRepository
    {
        List<NotRequiredOperation> GetAllNotRequiredOperation();
        List<KeyValuePair<DateTime, Guid>> GetAllNotRequiredOperationResult();
        KeyValuePair<Guid, decimal> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, FrequencyMeasure measure);
        KeyValuePair<Guid, decimal> GetUnitsProducedSinceLastDateTest(Guid testId, FrequencyMeasure measure);
    }
}
