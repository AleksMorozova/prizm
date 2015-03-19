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
            public Guid OperationId { get; set; }

            private float warningBoundary = 0;
            private int frequency = 0;
            public int Frequency
            {
                get { return frequency; }
                set { frequency = value; warningBoundary = value * Prizm.Main.Common.Constants.PercentForInspectionOperation; } 
            }
            public float WarningBoundary { get { return warningBoundary; } }

            public string Measure { get; set; } // enum type
            public float UnitsSinceLastOperation { get; set; }
            public string OperationCode { get; set; }
            public string OperationName { get; set; }
            public string PipeSizeTypeName { get; set; }
        }
        private Dictionary<Guid, NotRequiredCachePack> internalCache = new Dictionary<Guid, NotRequiredCachePack>();

        public void AddOrReplace(
            Guid notRequiredOperationId,
            int frequency, float unitsSinceLastOperation,
            string operationCode, string operationName, string pipeSizeTypeName,
            string measure)
        {
            internalCache[notRequiredOperationId] =
                new NotRequiredCachePack()
                {
                    OperationId = notRequiredOperationId,
                    Frequency = frequency,
                    Measure = measure,
                    UnitsSinceLastOperation = unitsSinceLastOperation,
                    OperationCode = operationCode,
                    OperationName = operationName,
                    PipeSizeTypeName = pipeSizeTypeName
                };
        }

        public void Clear()
        {
            internalCache.Clear();
        }

        public void SetUnits(Guid pipeTestId, float unitsProducedSinceLastDate)
        {
            internalCache[pipeTestId].UnitsSinceLastOperation = unitsProducedSinceLastDate;
        }

        /// <summary>
        /// Adds units to total count
        /// </summary>
        /// <param name="pipeTestId">id of NRO</param>
        /// <param name="units">number of units to be added</param>
        /// <returns>status, if units were really added (pipeTestId found in cache)</returns>
        public bool AddUnits(Guid pipeTestId, float units)
        {
            bool found = false;
            if (internalCache.ContainsKey(pipeTestId))
            {
                internalCache[pipeTestId].UnitsSinceLastOperation += units;
                found = true;
            }
            return found;
        }

        /// <summary>
        /// Removes units from total count. If result is less than 0 it becomes 0.
        /// </summary>
        /// <param name="pipeTestId">id of NRO</param>
        /// <param name="units">number of units to be removed</param>
        /// <returns>status, if units were really removed (pipeTestId found in cache)</returns>
        public bool RemoveUnits(Guid pipeTestId, float units)
        {
            bool found = false;
            if (internalCache.ContainsKey(pipeTestId))
            {
                internalCache[pipeTestId].UnitsSinceLastOperation -= units;
                if (internalCache[pipeTestId].UnitsSinceLastOperation < 0)
                {
                    internalCache[pipeTestId].UnitsSinceLastOperation = 0;
                }
                found = true;
            }
            return found;
        }

        public bool IsGoingToExpire(Guid pipeTestId)
        {
            return (internalCache[pipeTestId].UnitsSinceLastOperation >= internalCache[pipeTestId].WarningBoundary);
        }

        public string GetMeasure(Guid pipeTestId) // TODO return enum type back
        {
            return internalCache[pipeTestId].Measure;
        }

        public string GetOwnerName(Guid pipeTestId)
        {
            return internalCache[pipeTestId].PipeSizeTypeName + ": " + internalCache[pipeTestId].OperationCode + "-" + internalCache[pipeTestId].OperationName;
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
