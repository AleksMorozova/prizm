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
        private readonly IMillReportsRepository repo;
        private readonly ConstructionReportViewModel viewModel;
        private readonly IUserNotify notify;

        private DataSet data;
        private PipelineGraph graph;
        private List<TracingData> tracingDataList;
        private List<PipelineVertex> path;

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

            if (viewModel.ReportType.Value == ReportType.TracingReport && notNullJointsCondition)
            {
                PipelineTracing();
                viewModel.report.DataSource = tracingDataList;
            }
            else if (viewModel.ReportType.Value == ReportType.PipelineLengthReport && notNullJointsCondition)
            {
                PipelineLenghtCalculation();
            }
            else if (viewModel.ReportType.Value == ReportType.UsedProductReport)
            {
                GetUsedProduct();
                viewModel.report.DataSource = data;
            }
        }

        private void GetUsedProduct()
        {
            try
            {
                StringBuilder GetAllUsedProducts = new StringBuilder();
                foreach (var item in viewModel.Types)
                {
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
            catch (RepositoryException ex)
            {
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

                    for (int i = path.Count - 1; i >= 0; --i)
                    {
                        var tracingDataItem = new TracingData()
                        {
                            PartNumber = path[i].Data.Number,
                            PartTypeDescription = path[i].Data.PartTypeDescription,
                            Length = path[i].Data.Length
                        };

                        if (i >= 1)
                        {
                            var commonJoint = path[i].GetCommonJoint(path[i - 1]);

                            tracingDataItem.JointNumber = commonJoint.Data.Number;

                            tracingDataItem.JointСoordinates = 
                                commonJoint.Data.NumberKP.ToString() + " + " + 
                                commonJoint.Data.DistanceFromKP.ToString();
                        }

                        tracingDataList.Add(tracingDataItem);
                    }
                }
            }
        }

        private void PipelineLenghtCalculation()
        {
            PipelineTracing();

            ((PipelineLengthReport)viewModel.report).PipelinePartCount = 
                path.Count;

            ((PipelineLengthReport)viewModel.report).PipelineLength = 
                path.Select<PipelineVertex, int>(x => x.Data.Length).Sum();

            ((PipelineLengthReport)viewModel.report).PipelineJointCount = 
                path.Count - 1;

            ((PipelineLengthReport)viewModel.report).CoordinatesFrom =
                viewModel.StartJoint.NumberKP.ToString() + " + " +
                viewModel.StartJoint.DistanceFromKP.ToString();
                
            ((PipelineLengthReport)viewModel.report).CoordinatesTo =
                viewModel.EndJoint.NumberKP.ToString() + " + " +
                viewModel.EndJoint.DistanceFromKP.ToString();
        }

        public bool CanExecute() { return true; }

        public bool IsExecutable { get; set; }
    }
}
