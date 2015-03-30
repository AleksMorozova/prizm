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

            public int selectivePercent { get; set; }
            public int pipeAmount { get; set; }

            public string OperationCode { get; set; }
            public string OperationName { get; set; }
            public string PipeSizeTypeName { get; set; }
        }


        private Dictionary<Guid, SelectiveCachePack> internalCache = new Dictionary<Guid, SelectiveCachePack>();

        public void AddOrReplace(Guid pipeSizeTypeId,
            Guid selectiveOperationId)
        {
            internalCache[selectiveOperationId] =
                new SelectiveCachePack()
                {
                    OperationId = selectiveOperationId
                    //TODO all filds
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

        public bool IsExpired(Guid pipeTestId)
        {
            try
            {
                //implment logic
                return false;
            }
            catch (KeyNotFoundException)
            {
                log.Error("IsExpired called for wrong pipe test. id: " + pipeTestId);
                return false;
            }
        }

        public void SetPipeAmount(Guid pipeTestId)
        {
            try
            {
                //pipeAmount
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
