using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Security
{
    public enum Privileges
    {
        Audit,
        NewDataEntry,
        EditData,
        PrintReports,
        EditSettings,
        ViewSettings,
        ExportDataFromMaster,
        ImportData,
        ImportDataAtProduction,
        ImportDataAtInspectionConstruction,
        UnshipAtMaster,
        DeactivatePipe,
        DeactivateJoint,
        DeactivateSpool,
        DeactivateComponent
    }
}
