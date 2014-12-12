using Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using NHibernate;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Forms.Common;
using PrizmMain.Forms.InspectionParts.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Construction
{
    public class ConstructionReportViewModel : ViewModelBase
    {
        private readonly IMillReportsRepository repo;
        private readonly IUserNotify notify;
        readonly CreateReportCommand createCommand;
        readonly PreviewReportCommand previewCommand;
        public int startPK;
        public int endPK;
        public object previewSource;
        public XtraReport report;

        [Inject]
        public ConstructionReportViewModel(IMillReportsRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            createCommand = ViewModelSource.Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));
            previewCommand = ViewModelSource.Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));
        }
        private BindingList<Part> parts = new BindingList<Part>();
        public BindingList<Part> Parts
        {
            get { return parts; }
            set
            {
                if (value != parts)
                {
                    parts = value;
                    RaisePropertyChanged("Parts");
                }
            }
        }

        private BindingList<PartType> types = new BindingList<PartType>();
        public BindingList<PartType> Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                    RaisePropertyChanged("Types");
                }
            }
        }
        public int StartPK
        {
            get
            {
                return startPK;
            }
            set
            {
                if (value != startPK)
                {
                    startPK = value;
                    RaisePropertyChanged("StartPK");
                }
            }
        }

        public int EndPK
        {
            get
            {
                return endPK;
            }
            set
            {
                if (value != endPK)
                {
                    endPK = value;
                    RaisePropertyChanged("EndPK");
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
    }
}
