using DevExpress.XtraReports.UI;
using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
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

        private readonly IMillReportsRepository repo;
        private readonly ConstructionReportViewModel viewModel;
        private readonly IUserNotify notify;

        private XtraReport report;
        private DataSet data;
        private PipelineGraph graph;
        private List<TracingData> tracingDataList;
        private List<PipelineVertex> path;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public ReportCommand(
            ConstructionReportViewModel viewModel,
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        public void Execute()
        {
            bool notNullJointsCondition = viewModel.StartJoint != null && viewModel.EndJoint != null;

            if (viewModel.TracingMode == TracingModeEnum.TracingByKP
                && viewModel.AllKP.Contains(viewModel.StartPK)
                && viewModel.AllKP.Contains(viewModel.EndPK))
            {
                viewModel.StartJoint =
                    viewModel.Joints
                    .First<construct.Joint>(
                    x => x.NumberKP == viewModel.StartPK && x.DistanceFromKP ==
                        viewModel.Joints
                        .Where<construct.Joint>(y => y.NumberKP == viewModel.StartPK)
                        .Min<construct.Joint>(z => z.DistanceFromKP));

                viewModel.EndJoint =
                    viewModel.Joints
                    .First<construct.Joint>(
                    x => x.NumberKP == viewModel.EndPK && x.DistanceFromKP ==
                        viewModel.Joints
                        .Where<construct.Joint>(y => y.NumberKP == viewModel.EndPK)
                        .Min<construct.Joint>(z => z.DistanceFromKP));
            }
            else if (notNullJointsCondition)
            {
                viewModel.StartPK = viewModel.StartJoint.NumberKP;
                viewModel.EndPK = viewModel.EndJoint.NumberKP;
            }

            if (viewModel.ReportType == ReportType.TracingReport && notNullJointsCondition)
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
            graph = new PipelineGraph(viewModel.PartDataList.Count);
            tracingDataList = new List<TracingData>();

            if (viewModel.PartDataList != null)
            {
                foreach (var partData in viewModel.PartDataList)
                {
                    graph.AddPipelineVertex(partData);
                }
                foreach (var joint in viewModel.Joints)
                {
                    graph.AddJointEdge(joint);
                }

                var paths = graph.Pathfinder(
                    viewModel.StartJoint.FirstElement,
                    viewModel.EndJoint.FirstElement);

                if (paths.Count != 0)
                {
                    path = graph.ShortestPath(paths);

                    path = graph.RemovalExternalComponents(
                        viewModel.StartJoint,
                        viewModel.EndJoint,
                        path);

                    for (int i = path.Count - 1; i > 0; --i)
                    {
                        var tracingDataItem = new TracingData()
                        {
                            FirstPartNumber = path[i].Data.Number,
                            FirstPartTypeDescription = path[i].Data.PartTypeDescription,
                            FirstPartLength = path[i].Data.Length,

                            SecondPartNumber = path[i - 1].Data.Number,
                            SecondPartTypeDescription = path[i - 1].Data.PartTypeDescription,
                            SecondPartLength = path[i - 1].Data.Length
                        };

                        var commonJoint = path[i].GetCommonJoint(path[i - 1]);
                        tracingDataItem.JointNumber = commonJoint.Data.Number;
                        tracingDataItem.WeldingDate =
                            commonJoint.Data
                            .JointWeldResults.First().Date.Value.ToShortDateString();

                        tracingDataList.Add(tracingDataItem);
                    }

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
                path.Count - 1;

            viewModel.PipelinePipeCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Pipe).Count<PipelineVertex>();

            viewModel.PipelineSpoolCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Spool).Count<PipelineVertex>();

            viewModel.PipelineComponentCount =
                path.Where<PipelineVertex>(x => x.Data.PartType == PartType.Component).Count<PipelineVertex>();

            viewModel.PipelineLength =
                path.Select<PipelineVertex, int>(x => x.Data.Length).Sum();
        }

        public bool CanExecute() { return true; }

        public bool IsExecutable { get; set; }
    }
}
