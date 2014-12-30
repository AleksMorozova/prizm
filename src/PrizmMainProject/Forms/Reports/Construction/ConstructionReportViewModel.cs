using Prizm.Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Common;
using Prizm.Main.Forms.Parts.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Construction;

using construct = Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class ConstructionReportViewModel : ViewModelBase
    {
        private readonly IJointRepository repoJoint;
        private readonly IMillReportsRepository repo;
        private readonly IUserNotify notify;

        private readonly CreateReportCommand createCommand;
        private readonly PreviewReportCommand previewCommand;
        private readonly TracingCommand tracingCommand;

        public int startPK;
        public int endPK;

        public object previewSource;
        public BindingList <PartType> selectedTypes;
        public XtraReport report;
        public BindingList<int> AllKP { get; set; }

        public IList<construct.Joint> Joints { get; set; }

        [Inject]
        public ConstructionReportViewModel(
            IMillReportsRepository repo, 
            IJointRepository repoJoint, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;

            this.Joints = repoJoint.GetAll();

            createCommand = ViewModelSource
                .Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));

            previewCommand = ViewModelSource
                .Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));

            tracingCommand = ViewModelSource
                .Create<TracingCommand>(() => new TracingCommand(this, repo, notify));



            tracingCommand.Execute();


        }



        public void LoadData()
        {
            AllKP = repo.GetAllKP();
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
