using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.NotRequired
{
    internal class NotRequiredCache : IEnumerable<Guid>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotRequiredCache));

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

            public float UnitsSinceLastOperation { get; set; }
            public float UnitsLeft { get { return Frequency - UnitsSinceLastOperation; } }

            public string Measure { get; set; } // enum type
            public string OperationCode { get; set; }
            public string OperationName { get; set; }
            public string PipeSizeTypeName { get; set; }
        }
        private Dictionary<Guid, NotRequiredCachePack> internalCache = new Dictionary<Guid, NotRequiredCachePack>();
        private Dictionary<Guid, HashSet<Guid>> operationsAtSizeType = new Dictionary<Guid, HashSet<Guid>>();

        public void AddOrReplace(
            Guid pipeSizeTypeId,
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
            if (!operationsAtSizeType.ContainsKey(pipeSizeTypeId))
            {
                operationsAtSizeType[pipeSizeTypeId] = new HashSet<Guid>();
            }
            operationsAtSizeType[pipeSizeTypeId].Add(notRequiredOperationId);
        }

        public void Clear()
        {
            internalCache.Clear();
        }

        /// <summary>
        /// sets number of units produced since last operation date
        /// </summary>
        /// <param name="pipeTestId">id of NRO</param>
        /// <param name="unitsProducedSinceLastDate">number of units to be set</param>
        /// <returns>status, if units were really set (pipeTestId found in cache)</returns>
        public bool SetUnits(Guid pipeTestId, float unitsProducedSinceLastDate)
        {
            bool found = false;
            if (internalCache.ContainsKey(pipeTestId))
            {
                internalCache[pipeTestId].UnitsSinceLastOperation = unitsProducedSinceLastDate;
                found = true;
            }
            return found;
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
            try
            {
                return (internalCache[pipeTestId].UnitsSinceLastOperation >= internalCache[pipeTestId].WarningBoundary);
            }
            catch(KeyNotFoundException)
            {
                log.Error("IsGoingToExpire called for wrong pipe test. id: " + pipeTestId);
                return false;
            }
        }

        public bool IsExpired(Guid pipeTestId)
        {
            try
            {
                return (internalCache[pipeTestId].UnitsSinceLastOperation >= internalCache[pipeTestId].Frequency);
            }
            catch (KeyNotFoundException)
            {
                log.Error("IsExpired called for wrong pipe test. id: " + pipeTestId);
                return false;
            }
        }

        public string GetMeasure(Guid pipeTestId) // TODO return enum type back
        {
            try
            {
                return internalCache[pipeTestId].Measure;
            }
            catch (KeyNotFoundException)
            {
                log.Error("GetMeasure called for wrong pipe test. id: " + pipeTestId);
                return "";
            }
        }

        public string GetOwnerName(Guid pipeTestId)
        {
            try
            {
                return internalCache[pipeTestId].PipeSizeTypeName + ": " + internalCache[pipeTestId].OperationCode + "-" + internalCache[pipeTestId].OperationName;
            }
            catch (KeyNotFoundException)
            {
                log.Error("GetOwnerName called for wrong pipe test. id: " + pipeTestId);
                return "";
            }
        }

        public float GetUnits(Guid pipeTestId)
        {
            try
            {
                return internalCache[pipeTestId].UnitsSinceLastOperation;
            }
            catch (KeyNotFoundException)
            {
                log.Error("GetUnits called for wrong pipe test. id: " + pipeTestId);
                return 0;
            }
        }
        public IEnumerator<Guid> GetEnumerator()
        {
            return internalCache.Keys.AsEnumerable<Guid>().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Guid> EnumerateOperationsForSizeType(Guid pipeSizeTypeId)
        {
            try
            {
                return operationsAtSizeType[pipeSizeTypeId];
            }
            catch (KeyNotFoundException)
            {
                log.Error("EnumerateOperationsForSizeType called for wrong pipe size type. id: " + pipeSizeTypeId);
                return new HashSet<Guid>();
            }
        }
    }
}
