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

namespace Prizm.Main.Forms.Reports.Construction
{
    public class TracingCommand: ICommand
    {
        private readonly IMillReportsRepository repo;
        private readonly ConstructionReportViewModel viewModel;
        private readonly IUserNotify notify;



        public TracingCommand(
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
            
            var graph = new PipelineGraph();

            foreach (var partData in viewModel.PartDataList)
            {
                graph.AddPipelineVertex(partData);
            }

            foreach (var joint in viewModel.Joints)
            {
                graph.AddJointEdge(joint);
            }

            var path = graph.Pathfinder(
                viewModel.StartJoint.FirstElement,
                viewModel.EndJoint.SecondElement);

            var tracingDataList = new List<TracingData>();

            // - 2 ?
            for (int i = 0;  i < path[0].Count - 2; ++i)
            {
                tracingDataList.Add(new TracingData()
                    {
                        PartNumber = path[0][i].Data.Number,
                        PartTypeDescription = path[0][i].Data.PartTypeDescription,
                        Length = path[0][i].Data.Length,
                        JointNumber = path[0][i].GetCommonJoint(path[0][i + 1]).Data.Number
                    });
            }




        }

        public bool CanExecute() { return true; }

        public bool IsExecutable { get; set; }
    }
}
