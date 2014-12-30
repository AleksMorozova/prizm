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

        private DataTable data;

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
            this.data = repo.GetPipelineElements(SQLQueryString.GetWeldedParts);


            var partDataList = FormWeldedParts(data);



            var graph = new PipelineGraph();

            foreach(var partData in partDataList)
            {
                graph.AddPipelineVertex(partData);
            }

            foreach (var joint in viewModel.Joints)
            {
                graph.AddJointEdge(joint);
            }

            var path = graph.Pathfinder(partDataList[0], partDataList[partDataList.Count - 1]);

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
