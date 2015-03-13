using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class NotRequiredCache
    { 
        private struct NotRequiredCachePack
        {
            int frequency;
            float unitsLeft;
            string operationCode;
            string operationName;
            string pipeSizeTypeName;
        }
        private Dictionary<Tuple<Guid, Guid>, NotRequiredCachePack> cache = new Dictionary<Tuple<Guid, Guid>, NotRequiredCachePack>();

        public void Add(
            Guid pipeSizeTypeId, Guid notRequiredOperationId, 
            int Frequency, float unitsLeft, 
            string operationCode, string operationName, string pipeSizeTypeName)
        {
            cache[new Tuple<Guid, Guid>(pipeSizeTypeId, notRequiredOperationId)] = 
                new NotRequiredCachePack() 
                {
                    // TODO: init all struct members from arguments
                };
        }

        public void Clear()
        {
            cache.Clear();
        }


    }

    class NotRequiredOperationManager : NotificationManager,  INotRequiredOperationManager
    {
        public NotRequiredOperationManager()
            : base(new NotRequiredOperationMetersLoader())
        {
            AddLoader(new NotRequiredOperationPipesLoader());
            AddLoader(new NotRequiredOperationTonsLoader());
        }

        public override TypeNotification Type { get { return TypeNotification.NotRequiredInspectionOperation; } }

        public static Notification CreateNotification(Guid userId, string ownerName, float unitsLeft, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.NotRequiredInspectionOperation, information, unitsLeft);
        }


        public void RefreshNotification(Pipe savedPipe, PipeMillSizeType savedSizeType, PipeTest savedInspectionOperation)
        {
            
        }
    }
}
