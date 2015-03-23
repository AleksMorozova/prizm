using DevExpress.XtraReports.UI;
using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construct = Prizm.Domain.Entity.Construction;


namespace Prizm.Main.Forms.Reports.Construction
{
    public class ReportCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ReportCommand));

        private readonly IJointRepository repoJoint;
        private readonly IMillReportsRepository repo;
        private readonly ConstructionReportViewModel viewModel;
        private readonly IUserNotify notify;

        //private XtraReport report;
        private DataSet data;
        private PipelineGraph graph;
        private List<TracingData> tracingDataList;
        private List<PipelineVertex> path;

        private List<construct.Joint> joints = null;
        private IList<PartData> partDataList = null;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public ReportCommand(
            ConstructionReportViewModel viewModel,
            IMillReportsRepository repo, 
            IJointRepository repoJoint,
            IUserNotify notify)
        {
            this.repoJoint = repoJoint;
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        public void Execute()
        {
            if (viewModel.ReportType == ReportType.TracingReport 
                && viewModel.StartJoint != null 
                && viewModel.EndJoint != null)
            {
                PipelineTracing();
                viewModel.ReportDataSource = tracingDataList;
            }
            else if (viewModel.ReportType == ReportType.UsedProductReport)
            {
                GetUsedProduct();
                viewModel.ReportDataSource = data;
            }
        }

        private void GetUsedProduct()
        {
            try
            {
                if (viewModel.Types.Count > 0)
                {
                    StringBuilder GetAllUsedProducts = new StringBuilder();
                    foreach (var item in viewModel.Types)
                    {
                        if (!string.IsNullOrWhiteSpace(GetAllUsedProducts.ToString()))
                        {
                            GetAllUsedProducts.Append(" UNION ");
                        }

                        switch (item)
                        {
                            case PartType.Undefined:
                                GetAllUsedProducts.Append(" ");
                                break;
                            case PartType.Pipe:
                                GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedPipe));
                                GetAllUsedProducts.Append(" ");
                                break;
                            case PartType.Spool:
                                GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedSpool));
                                GetAllUsedProducts.Append(" ");
                                break;
                            case PartType.Component:
                                GetAllUsedProducts.Append(" ");
                                GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedComponent));
                                break;
                            default:
                                GetAllUsedProducts.Append(" ");
                                break;
                        }
                    }

                    data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK, GetAllUsedProducts.ToString());
                    SetDataSortByColumn("number");
                }
            }
            catch (RepositoryException ex)
            {
                log.Error(string.Concat( ex.InnerException.Message, ex.Message));
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }

        private void PipelineTracing()
        {
            if (joints == null)
            {
                this.joints = repoJoint.GetJointsForTracing().ToList<construct.Joint>();
                if (this.joints == null || this.joints.Count <= 0)
                    log.Warn("Report at Construction: List of Joints is NULL or empty.");
            }
            if (partDataList == null)
            {
                var data = repo.GetPipelineElements(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetWeldedParts).ToString());
                if (data == null || data.Rows.Count <= 0)
                    log.Warn("Report at Construction: Data Table of Pieces is NULL or empty.");

                this.partDataList = this.FormWeldedParts(data);
            }

            graph = new PipelineGraph(partDataList.Count);
            tracingDataList = new List<TracingData>();

            if (partDataList != null)
            {
                foreach (var partData in partDataList)
                {
                    graph.AddPipelineVertex(partData);
                }
                foreach (var joint in this.joints)
                {
                    graph.AddJointEdge(joint);
                }

                var startJoint = joints.First<construct.Joint>(x => x.Id == viewModel.StartJoint.Id);
                var endJoint = joints.First<construct.Joint>(x => x.Id == viewModel.EndJoint.Id);

                if (viewModel.TracingMode == TracingModeEnum.TracingByKP
                    && viewModel.AllKP.Contains(viewModel.StartPK)
                    && viewModel.AllKP.Contains(viewModel.EndPK))
                {
                    startJoint = joints.First<construct.Joint>(
                        x => x.NumberKP == viewModel.StartPK && x.DistanceFromKP == joints
                            .Where<construct.Joint>(y => y.NumberKP == viewModel.StartPK)
                            .Min<construct.Joint>(z => z.DistanceFromKP));

                    endJoint = joints.First<construct.Joint>(
                        x => x.NumberKP == viewModel.EndPK && x.DistanceFromKP == joints
                            .Where<construct.Joint>(y => y.NumberKP == viewModel.EndPK)
                            .Min<construct.Joint>(z => z.DistanceFromKP));
                }

                var paths = graph.Pathfinder(startJoint.FirstElement, endJoint.FirstElement);

                if (paths.Count != 0)
                {
                    path = graph.ShortestPath(paths);

                    path = graph.RemovalExternalComponents(startJoint, endJoint, path);

                    for (int i = path.Count - 1; i > 0; --i)
                    {
                        var tracingDataItem = new TracingData(path[i].Data, path[i - 1].Data);

                        var commonJoint = path[i].GetCommonJoint(path[i - 1]);

                        tracingDataItem.JointNumber = commonJoint.Data.Number;
                        tracingDataItem.WeldingDate = commonJoint.Data.JointWeldResults.First().Date.Value.ToShortDateString();

                        tracingDataList.Add(tracingDataItem);
                    }

                    var firstTracingDataItem = new TracingData(null, path.Last().Data);
                    firstTracingDataItem.JointNumber = startJoint.Number;
                    firstTracingDataItem.WeldingDate = startJoint.JointWeldResults.First().Date.Value.ToShortDateString();
                    tracingDataList.Insert(0, firstTracingDataItem);

                    var lastTracingDataItem = new TracingData(path.First().Data, null);
                    lastTracingDataItem.JointNumber = endJoint.Number;
                    lastTracingDataItem.WeldingDate = endJoint.JointWeldResults.First().Date.Value.ToShortDateString();
                    tracingDataList.Add(lastTracingDataItem);


                    PipelineLenghtCalculation();
                }
            }
            else
            {
                log.Warn(string.Format("List of Pipeline elements is NULL for construction report type: {0}", viewModel.ReportType));
            }
        }



        private void PipelineLenghtCalculation()
        {
            viewModel.PipelineJointCount = 
                path.Count + 1;

            viewModel.PipelinePipeCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Pipe).Count<PipelineVertex>();

            viewModel.PipelineSpoolCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Spool).Count<PipelineVertex>();

            viewModel.PipelineComponentCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Component).Count<PipelineVertex>();

            viewModel.PipelineLength =
                path.Select<PipelineVertex, int>(x => x.Data.Length).Sum();
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

        private IList<PartData> FormWeldedParts(DataTable dataTable)
        {
            List<PartData> list = new List<PartData>();

            dataTable.Columns.Add("typeTranslated", typeof(String));

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.Field<string>("type") != "Component")
                {
                    row.SetField(
                        "typeTranslated",
                        Resources.ResourceManager.GetString(row.Field<string>("type")));
                }
                else
                {
                    row.SetField(
                        "typeTranslated",
                        row.Field<string>("componentTypeName"));
                }

                PartData p = new PartData()
                {
                    Id = row.Field<Guid>("id"),
                    Number = row.Field<string>("number"),
                    PartType = (PartType)Enum.Parse(typeof(PartType), row.Field<string>("type")),
                    Length = row.Field<int>("length"),
                    PartTypeDescription = row.Field<string>("typeTranslated")
                };

                list.Add(p);
            }

            return list;
        }

        public bool CanExecute() { return true; }

        public bool IsExecutable { get; set; }
    }
}
