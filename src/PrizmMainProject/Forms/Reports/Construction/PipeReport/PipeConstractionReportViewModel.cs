
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public class PipeConstractionReportViewModel: ViewModelBase
    {
        private readonly IUserNotify notify;

        private readonly CreatePipeReportCommand createCommand;
        private readonly PreviewPipeReportCommand previewCommand;
        private readonly PipeReportCommand reportCommand;

        private readonly IMillReportsRepository repo;

        private string diameter;
        private string wallThickness;
        private string pipeNumber;
        private Object previewSource;
        private IList<PipeReportData> pipeReportDataList;


        [Inject]
        public PipeConstractionReportViewModel(
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;

            createCommand = ViewModelSource
                .Create<CreatePipeReportCommand>(() => new CreatePipeReportCommand(this, repo, notify));

            previewCommand = ViewModelSource
                .Create<PreviewPipeReportCommand>(() => new PreviewPipeReportCommand(this, repo, notify));

            reportCommand = ViewModelSource
                .Create<PipeReportCommand>(() => new PipeReportCommand(this, repo, notify));

        }


        public XtraReport Report { get; set; }

        public DataTable Data { get; set; }

        public string PipeNumber
        {
            get
            {
                return pipeNumber;
            }
            set
            {
                if (value != pipeNumber)
                {
                    pipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public object PreviewSource
        {
            get
            {
                return previewSource;
            }
            set
            {
                if (value != previewSource)
                {
                    previewSource = value;
                    RaisePropertyChanged("PreviewSource");
                }
            }
        }

        public string Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (value != Diameter)
                {
                    diameter = value;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public string WallThickness
        {
            get
            {
                return wallThickness;
            }
            set
            {
                if (value != WallThickness)
                {
                    wallThickness = value;
                    RaisePropertyChanged("WallThickness");
                }
            }
        }

        public IList<PipeReportData> PipeReportDataList
        {
            get
            {
                if (Data != null)
                {
                    pipeReportDataList = new List<PipeReportData>();

                    PipeReportData pipeReportData = new PipeReportData();

                    foreach (DataRow row in Data.Rows)
                    {
                        pipeReportData = new PipeReportData(row);
                        pipeReportDataList.Add(pipeReportData);
                    }
                }
                return pipeReportDataList;
            }

            set { pipeReportDataList = value; }
        }



        public ICommand CreatePipeReportCommand
        {
            get { return createCommand; }
        }
        public ICommand PreviewPipeReportCommand
        {
            get { return previewCommand; }
        }
        public ICommand PipeReportCommand
        {
            get { return reportCommand; }
        }

        public void Dispose() { }

    }
}
