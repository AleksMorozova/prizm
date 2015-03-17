using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.NotRequired
{
    internal class NotRequiredCache : IEnumerable<Guid>
    {
        private class NotRequiredCachePack
        {
            public Guid operationId { get; set; }
            public int frequency { get; set; }
            public string measure { get; set; } // enum type
            public float unitsLeft { get; set; }
            public string operationCode { get; set; }
            public string operationName { get; set; }
            public string pipeSizeTypeName { get; set; }
        }
        private Dictionary<Guid, NotRequiredCachePack> internalCache = new Dictionary<Guid, NotRequiredCachePack>();

        public void AddOrReplace(
            Guid notRequiredOperationId,
            int Frequency, float unitsLeft,
            string operationCode, string operationName, string pipeSizeTypeName,
            string measure)
        {
            internalCache[notRequiredOperationId] =
                new NotRequiredCachePack()
                {
                    operationId = notRequiredOperationId,
                    frequency = Frequency,
                    measure = measure,
                    unitsLeft = unitsLeft,
                    operationCode = operationCode,
                    operationName = operationName,
                    pipeSizeTypeName = pipeSizeTypeName
                };
        }

        public void Clear()
        {
            internalCache.Clear();
        }

        public void SetUnitsLeft(Guid pipeTestId, float unitsProducedSinceLastDate)
        {
            internalCache[pipeTestId].unitsLeft = internalCache[pipeTestId].frequency - unitsProducedSinceLastDate;
        }

        /// <summary>
        /// Adds units to total count
        /// </summary>
        /// <param name="pipeTestId">id of NRO</param>
        /// <param name="units">number of units to be added</param>
        /// <returns>status, if units were really added (pipeTestId found in cache)</returns>
        public bool AddUnits(Guid pipeTestId, float units)
        {
            // TODO implement this method
            return true;
        }

        public bool IsGoingToExpire(Guid pipeTestId)
        {
            return (internalCache[pipeTestId].unitsLeft >= internalCache[pipeTestId].frequency * Prizm.Main.Common.Constants.PercentForInspectionOperation);
        }

        public string GetMeasure(Guid pipeTestId) // TODO return enum type back
        {
            return internalCache[pipeTestId].measure;
        }

        public string GetOwnerName(Guid pipeTestId)
        {
            return internalCache[pipeTestId].pipeSizeTypeName + ": " + internalCache[pipeTestId].operationCode + "-" + internalCache[pipeTestId].operationName;
        }

        public IEnumerator<Guid> GetEnumerator()
        {
            return internalCache.Keys.AsEnumerable<Guid>().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
