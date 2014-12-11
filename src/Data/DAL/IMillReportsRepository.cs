using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public interface IMillReportsRepository
    {
        DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories, ReportType reportType, List<string> statuses);
        DataTable GetAuditResults(DateTime startDate, DateTime finalDate, string user);
        DataSet GetPipesFromInspection(DateTime startDate, DateTime finalDate);
    }
}
