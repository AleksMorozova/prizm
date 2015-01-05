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
            if (viewModel.ReportType.Value == ReportType.HighwayReport)
            {
                PipelineTracing();
            }
            else if (viewModel.ReportType.Value == ReportType.PipelineLengthReport)
            {

            }
            else
            {
                GetUsedProduct();
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
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedPipe);
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Spool:
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedSpool);
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Component:
                            GetAllUsedProducts.Append(" ");
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedComponent);
                            break;
                        default:
                            GetAllUsedProducts.Append(" ");
                            break;
                    }
                }

                data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK, GetAllUsedProducts.ToString());

                viewModel.report.DataSource = data;

            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }


        private void PipelineTracing()
        {
            if (viewModel.PartDataList != null)
            {
                var graph = new PipelineGraph(viewModel.PartDataList.Count);

                foreach (var partData in viewModel.PartDataList)
                {
                    graph.AddPipelineVertex(partData);
                }

                foreach (var joint in viewModel.Joints)
                {
                    graph.AddJointEdge(joint);
                }

                var paths = graph.Pathfinder(viewModel.StartJoint.SecondElement, viewModel.EndJoint.FirstElement);

                var path = graph.ShortestPath(paths);

                var tracingDataList = new List<TracingData>();


                for (int i = path.Count - 1; i >= 0; --i)
                {
                    var tracingDataItem = new TracingData()
                    {
                        PartNumber = path[i].Data.Number,
                        PartTypeDescription = path[i].Data.PartTypeDescription,
                        Length = path[i].Data.Length,
                    };

                    if (i >= 1)
                    {
                        tracingDataItem.JointNumber = path[i].GetCommonJoint(path[i - 1]).Data.Number;
                    }

                    tracingDataList.Add(tracingDataItem);
                }

                viewModel.report.DataSource = tracingDataList;

            }
        }



        public bool CanExecute()
        {
            return
                viewModel.ReportType != null &&
                viewModel.StartJoint != null &&
                viewModel.EndJoint != null; ;
        }

        public bool IsExecutable { get; set; }
    }
}
