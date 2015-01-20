
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Setup;
using Prizm.Domain.Entity.Setup;
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

        private readonly IMillReportsRepository repo;
        private readonly IMillPipeSizeTypeRepository repoPipeType;

        private string pipeNumber;
        private Object previewSource;
        private IList<PipeReportData> pipeReportDataList;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<PipeMillSizeType> checkedPipeTypes = new List<PipeMillSizeType>();


        [Inject]
        public PipeConstractionReportViewModel(
            IMillReportsRepository repo, 
            IMillPipeSizeTypeRepository repoPipeType,
            IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            this.repoPipeType = repoPipeType;

            createCommand = ViewModelSource
                .Create<CreatePipeReportCommand>(() => new CreatePipeReportCommand(this, repo, notify));

            previewCommand = ViewModelSource
                .Create<PreviewPipeReportCommand>(() => new PreviewPipeReportCommand(this, repo, notify));

            pipeTypes = repoPipeType.GetAll();

            foreach (var pt in pipeTypes)
            {
                checkedPipeTypes.Add(pt);
            }
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

        public IList<PipeMillSizeType> PipeTypes
        {
            get { return pipeTypes; }
            set
            {
                if (value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }

        public IList<PipeMillSizeType> CheckedPipeTypes
        {
            get { return checkedPipeTypes; }
            set
            {
                if (value != checkedPipeTypes)
                {
                    checkedPipeTypes = value;
                    RaisePropertyChanged("CheckedPipeTypes");
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

        public void Dispose() { }

    }
}
