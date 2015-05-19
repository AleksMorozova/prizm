using Prizm.Data.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity.Mill;
using System.ComponentModel;
using Prizm.Main.Languages;
using Prizm.Data.DAL.ADO;

namespace Prizm.Main.Forms.Reports.Mill
{
    public class CreateReportCommand: ICommand 
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreateReportCommand));

        readonly IMillReportsRepository repo;
        readonly MillReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        
        public CreateReportCommand(MillReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.StartDate, viewModel.EndDate))
            {
                try
                {
                    if (viewModel.SelectedReportType == MillReportType.ByProducing)
                    {
                        data = repo.GetPipes(viewModel.StartDate, viewModel.EndDate);
                        AdditionToTheReport report = new AdditionToTheReport();
                        BindingList<decimal> counts = repo.CountPipe(viewModel.StartDate, viewModel.EndDate);
                        report.PipesCount = counts[0];
                        report.PipesLength = counts[1];
                        report.PipesWeight = counts[2];
                        SetDataSortByColumn("number");
                        report.DataSource = data;
                        report.FootersVisibility = viewModel.IsFooterVisible;
                        report.CreateDocument();
                        var tool = new ReportPrintTool(report);
                        tool.AutoShowParametersPanel = false;
                        tool.ShowPreview();
                    }
                    else if (viewModel.SelectedReportType == MillReportType.General)
                    {
                        data = repo.CountWeldInf(viewModel.StartDate, viewModel.EndDate);
                        SetDataSortByColumn("productionDate");
                        GeneralInformationXtraReport report = new GeneralInformationXtraReport();
                        report.DataSource = data;
                        report.FootersVisibility = viewModel.IsFooterVisible;
                        var tool = new ReportPrintTool(report);
                        tool.AutoShowParametersPanel = false;
                        tool.ShowPreview();
                    }
                    else if (viewModel.SelectedReportType == MillReportType.ByShipped)
                    {
                        data = repo.GetReleaseNotes(viewModel.StartDate, viewModel.EndDate);
                        LoadingXtraReport report = new LoadingXtraReport();
                        SetDataSortByColumn("releaseNote");
                        report.DataSource = data;
                        report.FootersVisibility = viewModel.IsFooterVisible;
                        var tool = new ReportPrintTool(report);
                        tool.AutoShowParametersPanel = false;
                        tool.ShowPreview();
                    }
                    else
                    {
                        data = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate, viewModel.SearchIds, viewModel.SelectedReportType, viewModel.SearchStatuses);
                        MillReportsXtraReport report = new MillReportsXtraReport();
                        SetDataSortByColumn("number");
                        data.TranslateStatus<PipeMillStatus>(SQLProvider.TableNameForMillReport, SQLProvider.ColumnNameForMillReport, viewModel.localizedPipeStatus);
                        report.DataSource = data;
                        report.FootersVisibility = viewModel.IsFooterVisible;
                        report.CreateDocument();
                        var tool = new ReportPrintTool(report);
                        tool.AutoShowParametersPanel = false;
                        tool.ShowPreview();
                    }
                }
                catch (RepositoryException ex)
                {
                    log.Error(string.Concat(ex.InnerException.Message, ex.Message));
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.Message_FailureReportDate),
                    Program.LanguageManager.GetString(StringResources.Message_FailureReportDateHeader));
                log.Warn("Date limits not valid!" + "Diapason: start date= "
                    + viewModel.StartDate.ToString() + " end date= " + viewModel.EndDate.ToString());
            }
           
        }

        private void SetDataSortByColumn(string columnName)
        {
            foreach (DataTable t in data.Tables)
            {
                foreach (DataColumn column in ((DataTable)t).Columns)
                {
                    if (column.ColumnName == columnName)
                    {
                        t.DefaultView.Sort = column.ColumnName;
                        break;
                    }
                }
            }
        }
           
        public bool CanExecute()
        {
            return true;
        }

    }
}
