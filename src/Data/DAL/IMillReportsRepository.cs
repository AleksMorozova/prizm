using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        DataTable GetPipelineElements();
        DataSet GetUsedProducts(int startPK, int endPK, BindingList<string> selectedTypes);
        DataSet GetPipesFromInspection(DateTime startDate, DateTime finalDate);
    }
}
