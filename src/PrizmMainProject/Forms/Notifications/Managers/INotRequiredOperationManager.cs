using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    interface INotRequiredOperationManager
    {
        /*
         * What can happen at Save Pipe: (NRO - non required inspection operation)
         * - pipe is new and have no previous state (to update: NROs from current size type(new))
         * - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
         * - pipe is existing and operations were edited (to update: NROs from current size type(track changes))
         * - pipe deactivation (to update: NRO (remove))
         */

        /// <summary>
        /// This method should be used when "Passed" NRO at pipe was removed or set to other not ready state, or pipe was deactivated.
        /// </summary>
        void NotRequiredOperationWasRemoved(Guid operationId);

        /// <summary>
        /// This method works only with non-required inspection operations. Required operations will be ignored.
        /// Updates cache with non-required operations calculations. Can create new notifications in case 
        /// limit of pipes without this inspection operation has been reached. Can remove existing notifications
        /// in case non-required inspection operation was performed.
        /// </summary>
        /// <param name="operationId">id of not required inspection operation (pipe test)</param>
        /// <param name="unitsToAdd">can be negative in case if pipe test result status changed from Passed to other status</param>
        void RefreshNotification(Guid operationId, float unitsToAdd);
    }
}
