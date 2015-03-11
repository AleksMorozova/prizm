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
        CreatePipe,
        CreateJoint,
        CreateSpool,
        CreateComponent,
        CreateReleaseNote,
        EditPipe,
        EditJoint,
        EditSpool,
        EditComponent,
        EditReleaseNote,
        ViewPipe,
        ViewJoint,
        ViewSpool,
        ViewComponent,
        ViewReleaseNote,
        SearchPipes,
        SearchJoints,
        SearchParts,
        SearchReleaseNotes,
        PrintMillReports,
        PrintInspectionReports,
        PrintConstructionReports,
        PartsInspection,
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
        DeactivateComponent,
        ViewExportImportHistory
    }
}
