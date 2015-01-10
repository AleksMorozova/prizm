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
        AddAttachments,
        NewDataEntry,
        EditData,
        PrintReports,
        EditSettings,
        ViewSettings,
        ExportDataFromMill,
        ExportDataFromMaster,
        ExportDataFromConstruction,
        ImportDataAtMaster,
        ImportDataAtConstruction,
        UnshipAtMill,
        DeactivatePipe,
        DeactivateJoint,
        DeactivateSpool,
        DeactivateComponent
    }
}
