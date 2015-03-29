using Domain.Entity.Security;
using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Security
{
    class SecurityUtil
    {
        public static bool ExistOnCurrentWorkstation(Permission permission)
        {
            return ExistOnCurrentWorkstation((Privileges)Enum.Parse(typeof(Privileges), permission.Name));
        }

        public static bool ExistOnCurrentWorkstation(Privileges privilege)
        {
            bool belongs = false;
            switch (Program.ThisWorkstationType)
            {
                case Domain.Entity.Setup.WorkstationType.Master:
                    if (privilege == Privileges.NullPrivilegeAllowed
                        || privilege == Privileges.Audit
                        || privilege == Privileges.ExportDataFromMaster
                        || privilege == Privileges.ImportDataAtMaster
                        || privilege == Privileges.PrintConstructionReports
                        || privilege == Privileges.PrintInspectionReports
                        || privilege == Privileges.PrintMillReports
                        || privilege == Privileges.SearchJoints
                        || privilege == Privileges.SearchParts
                        || privilege == Privileges.SearchPipes
                        || privilege == Privileges.SearchReleaseNotes
                        || privilege == Privileges.ViewComponent
                        || privilege == Privileges.ViewJoint
                        || privilege == Privileges.ViewPipe
                        || privilege == Privileges.ViewReleaseNote
                        || privilege == Privileges.ViewSpool
                        || privilege == Privileges.ViewSettings
                        || privilege == Privileges.EditSettings
                        || privilege == Privileges.ViewExportImportHistory
                        )
                    {
                        belongs = true;
                    }
                    break;
                case Domain.Entity.Setup.WorkstationType.Mill:
                    if (privilege == Privileges.NullPrivilegeAllowed
                        || privilege == Privileges.Audit
                        || privilege == Privileges.CreatePipe
                        || privilege == Privileges.CreateReleaseNote
                        || privilege == Privileges.DeactivatePipe
                        || privilege == Privileges.EditPipe
                        || privilege == Privileges.EditReleaseNote
                        || privilege == Privileges.EditSettings
                        || privilege == Privileges.ExportDataFromMill
                        || privilege == Privileges.PrintMillReports
                        || privilege == Privileges.SearchPipes
                        || privilege == Privileges.SearchReleaseNotes
                        || privilege == Privileges.UnshipAtMill
                        || privilege == Privileges.ViewPipe
                        || privilege == Privileges.ViewReleaseNote
                        || privilege == Privileges.ViewSettings
                        || privilege == Privileges.ViewExportImportHistory
                        )
                    {
                        belongs = true;
                    }
                    break;
                case Domain.Entity.Setup.WorkstationType.Construction:
                    if (privilege == Privileges.NullPrivilegeAllowed
                        || privilege == Privileges.Audit
                        || privilege == Privileges.CreateComponent
                        || privilege == Privileges.CreateJoint
                        || privilege == Privileges.CreateSpool
                        || privilege == Privileges.DeactivateComponent
                        || privilege == Privileges.DeactivateJoint
                        || privilege == Privileges.DeactivateSpool
                        || privilege == Privileges.EditComponent
                        || privilege == Privileges.EditJoint
                        || privilege == Privileges.EditSettings
                        || privilege == Privileges.EditSpool
                        || privilege == Privileges.ExportDataFromConstruction
                        || privilege == Privileges.ImportDataAtConstruction
                        || privilege == Privileges.PartsInspection
                        || privilege == Privileges.PrintConstructionReports
                        || privilege == Privileges.PrintInspectionReports
                        || privilege == Privileges.SearchJoints
                        || privilege == Privileges.SearchParts
                        || privilege == Privileges.SearchPipes
                        || privilege == Privileges.SearchReleaseNotes
                        || privilege == Privileges.ViewComponent
                        || privilege == Privileges.ViewJoint
                        || privilege == Privileges.ViewPipe
                        || privilege == Privileges.ViewReleaseNote
                        || privilege == Privileges.ViewSettings
                        || privilege == Privileges.ViewSpool
                        || privilege == Privileges.ViewExportImportHistory
                        )
                    {
                        belongs = true;
                    }
                    break;
                case Domain.Entity.Setup.WorkstationType.Undefined:
                    belongs = false;
                    break;
                default:
                    belongs = false;
                    break;
            }
            return belongs;
        }
    }
}
