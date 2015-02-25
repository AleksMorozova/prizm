using Prizm.Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Incoming
{
    public class InspectionReportsViewModel : ViewModelBase, IDisposable
    {
        readonly IMillReportsRepository repo;
        private readonly IUserNotify notify;
        public DateTime startDate;
        public DateTime endDate;
        readonly CreateReportCommand createCommand;
        readonly PreviewReportCommand previewCommand;
        public object previewSource;

        [Inject]
        public InspectionReportsViewModel(IMillReportsRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            createCommand = ViewModelSource.Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));
            previewCommand = ViewModelSource.Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));
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

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (value != startDate)
                {
                    startDate = value;
                    RaisePropertyChanged("StartDate");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value != endDate)
                {
                    endDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public ICommand CreateCommand
        {
            get
            {
                return createCommand;
            }
        }

        public ICommand PreviewCommand
        {
            get { return previewCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }

}
