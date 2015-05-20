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
using System.Data;
using Prizm.Main.Properties;
using Prizm.Data.DAL.ADO;
using Prizm.Main.Common;
using NHibernate.Transform;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class ConstructionReportViewModel : ViewModelBase, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ConstructionReportViewModel));

        private readonly IJointRepository repoJoint;
        private readonly IMillReportsRepository repo;
        private readonly IUserNotify notify;

        private readonly CreateReportCommand createCommand;
        private readonly PreviewReportCommand previewCommand;
        private readonly ReportCommand reportCommand;

        private JointProjection startJoint;
        private JointProjection endJoint;
        private ReportType reportType;

        public int PipelineJointCount { get; set; }
        public int PipelinePipeCount { get; set; }
        public int PipelineSpoolCount { get; set; }
        public int PipelineComponentCount { get; set; }
        public int PipelineLength { get; set; }

        public int startPK;
        public int endPK;

        public bool checking = true;

        public object previewSource;
        public BindingList <PartType> selectedTypes;
        public Object ReportDataSource { get; set; }
        public BindingList<int> AllKP { get; set; }

        public IList<JointProjection> JointsProjections { get; set; }
        public List<string> localizedPartType = new List<string>();
        [Inject]
        public ConstructionReportViewModel(
            IMillReportsRepository repo, 
            IJointRepository repoJoint, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            this.repoJoint = repoJoint;

            this.JointsProjections = repoJoint
                .GetJointsProjections()
                .SetResultTransformer(Transformers.AliasToBean<JointProjection>())
                .List<JointProjection>();

            if (this.JointsProjections == null || this.JointsProjections.Count <= 0)
                log.Warn( "Report at Construction: List of Joints is NULL or empty." );

            createCommand = ViewModelSource
                .Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));

            previewCommand = ViewModelSource
                .Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));

            reportCommand = ViewModelSource
                .Create<ReportCommand>(() => new ReportCommand(this, repo, repoJoint, notify));

        }

        private bool isFooterVisible;
        public bool IsFooterVisible
        {
            get { return isFooterVisible; }
            set
            {
                if (value != isFooterVisible)
                {
                    isFooterVisible = value;
                    RaisePropertyChanged("IsFooterVisible");
                }
            }
        }

        public void LoadData()
        {
            this.AllKP = new BindingList<int>();
            foreach(var kp in JointsProjections.Select<JointProjection, int>(x => x.NumberKP))
            {
                if (!AllKP.Contains(kp) && kp!=int.MinValue)
                {
                    AllKP.Add(kp);
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

        public JointProjection StartJoint
        {
            get
            {
                return startJoint;
            }
            set
            {
                if (value != startJoint)
                {
                    startJoint = value;
                    RaisePropertyChanged("StartJoint");
                }
            }
        }

        public JointProjection EndJoint
        {
            get
            {
                return endJoint;
            }
            set
            {
                if (value != endJoint)
                {
                    endJoint = value;
                    RaisePropertyChanged("EndJoint");
                }
            }
        }

        public ReportType ReportType
        {
            get { return reportType; }
            set
            {
                if (value != reportType)
                {
                    reportType = value;
                    RaisePropertyChanged("ReportType");
                }
            }
        }

        public int ReportTypeIndex
        {
            get { return (int)reportType; }
            set
            {
                if (value != (int)reportType)
                {
                    reportType = (ReportType)value;
                    RaisePropertyChanged("ReportTypeIndex");
                }
            }
        }

        public TracingModeEnum TracingMode { get; set; }

        public ICommand CreateCommand
        {
            get
            {
                return createCommand;
            }
        }

        public ICommand PreviewCommand
        {
            get 
            { 
                return previewCommand; 
            }
        }

        public ICommand ReportCommand
        {
            get
            {
                return reportCommand;
            }
        }

        public void Dispose()
        {
            repo.Dispose();
            repoJoint.Dispose();
        }
    }
}
