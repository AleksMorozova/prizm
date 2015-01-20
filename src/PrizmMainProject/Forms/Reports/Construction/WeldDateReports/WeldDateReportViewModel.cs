using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public class WeldDateReportViewModel: ViewModelBase
    {
        private readonly IUserNotify notify;

        private readonly CreateRepoCommand createCommand;
        private readonly PreviewRepoCommand previewCommand;

        private readonly IMillReportsRepository repo;

        private DateTime? weldDateFrom;
        private DateTime? weldDateTo;

        private Object previewSource;
        private IList<WeldDateReportData> weldDateReportDataList;

        [Inject]
        public WeldDateReportViewModel(
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;

            createCommand = ViewModelSource
                .Create<CreateRepoCommand>(() => new CreateRepoCommand(this, repo, notify));

            previewCommand = ViewModelSource
                .Create<PreviewRepoCommand>(() => new PreviewRepoCommand(this, repo, notify));
        }


        public DataTable Data { get; set; }

        public DateTime? WeldDateFrom
        {
            get
            {
                return weldDateFrom;
            }
            set
            {
                if (value != weldDateFrom)
                {
                    weldDateFrom = value;
                    RaisePropertyChanged("WeldDateFrom");
                }
            }
        }

        public DateTime? WeldDateTo
        {
            get
            {
                return weldDateTo;
            }
            set
            {
                if (value != weldDateTo)
                {
                    weldDateTo = value;
                    RaisePropertyChanged("WeldDateTo");
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

        public IList<WeldDateReportData> WeldDateReportDataList
        {
            get
            {
                if (Data != null)
                {
                    weldDateReportDataList = new List<WeldDateReportData>();

                    WeldDateReportData weldReportData = new WeldDateReportData();

                    foreach (DataRow row in Data.Rows)
                    {
                        weldReportData = new WeldDateReportData(row);
                        weldDateReportDataList.Add(weldReportData);
                    }
                }
                return weldDateReportDataList;
            }

            set { weldDateReportDataList = value; }
        }

        public ICommand CreateRepoCommand
        {
            get { return createCommand; }
        }
        public ICommand PreviewRepoCommand
        {
            get { return previewCommand; }
        }

        public void Dispose() { }

    
    }
}
