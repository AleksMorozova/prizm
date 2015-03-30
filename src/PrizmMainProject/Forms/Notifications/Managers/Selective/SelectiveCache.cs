using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.Selective
{
    internal class SelectiveCache : IEnumerable<Guid>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SelectiveCache));

        private class SelectiveCachePack
        {
            public Guid OperationId { get; set; }
            public Guid PipeSizeTypeId { get; set; }

            public int SelectivePercent { get; set; }
            public int PipeAmount { get; set; }
            public int AllPipeAmount { get; set; }

            public string OperationCode { get; set; }
            public string OperationName { get; set; }
            public string PipeSizeTypeName { get; set; }

            public int checkValue { get; set; }
        }


        private Dictionary<Guid, SelectiveCachePack> internalCache = new Dictionary<Guid, SelectiveCachePack>();

        public void AddOrReplace(Guid pipeSizeTypeId,string pipeSizeTypeName ,
            Guid selectiveOperationId, string operationCode, string operationName, int selectivePercent, int pipeAmount, int allPipeAmount)
        {
            internalCache[selectiveOperationId] =
                new SelectiveCachePack()
                {
                    PipeSizeTypeId = pipeSizeTypeId,
                    PipeSizeTypeName = pipeSizeTypeName,
                    OperationId = selectiveOperationId,
                    OperationName = operationName,
                    SelectivePercent = selectivePercent,
                    PipeAmount = pipeAmount,
                    AllPipeAmount = allPipeAmount,
                    OperationCode = operationCode
                };
        }

        public void Clear()
        {
            internalCache.Clear();
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

        public int GetCheckValue(Guid pipeTestId)
        {
            try
            {
                return (internalCache[pipeTestId].PipeAmount / internalCache[pipeTestId].AllPipeAmount * 100);
            }
            catch (KeyNotFoundException)
            {
                log.Error("GetCheckValue called for wrong pipe test. id: " + pipeTestId);
                return 0;
            }
        }

        public bool IsExpired(Guid pipeTestId)
        {
            try
            {
                return (internalCache[pipeTestId].AllPipeAmount==0)? false : (int)(internalCache[pipeTestId].PipeAmount / internalCache[pipeTestId].AllPipeAmount * 100) < internalCache[pipeTestId].SelectivePercent;
            }
            catch (KeyNotFoundException)
            {
                log.Error("IsExpired called for wrong pipe test. id: " + pipeTestId);
                return false;
            }
        }

        public void SetPipeAmount(Guid pipeTestId, int amount)
        {
            try
            {
                internalCache[pipeTestId].AllPipeAmount = amount;
            }
            catch (KeyNotFoundException)
            {
                log.Error("SetPipeAmount called for wrong pipe test. id: " + pipeTestId);
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

    }
}
