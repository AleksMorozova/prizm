using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construction = Prizm.Domain.Entity.Construction;
using Prizm.Main.Forms.ExternalFile;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IConstructionRepository repoConstruction;
        private readonly Prizm.Data.DAL.IMillReportsRepository adoRepo;
        private readonly IUserNotify notify;
        private readonly SaveJointCommand saveJointCommand;
        private readonly NewSaveJointCommand newSaveJointCommand;
        private readonly ExtractOperationsCommand extractOperationsCommand;
        private readonly JointDeactivationCommand jointdeactivationCommand;
        private IModifiable modifiableView;
        private DataTable pieces;
        private BindingList<JointTestResult> jointTestResults;
        private BindingList<JointWeldResult> jointWeldResults;
        public construction.Joint Joint { get; set; }
        public Guid JointId { get; set; }
        public BindingList<JointOperation> ControlOperations;
        public BindingList<JointOperation> RepairOperations;
        public IList<Inspector> Inspectors { get; set; }
        public IList<Welder> Welders { get; set; }
        public ExternalFilesXtraForm FilesForm { get; set; }

        [Inject]
        public JointNewEditViewModel(IConstructionRepository repoConstruction, IUserNotify notify, Guid jointId, Prizm.Data.DAL.IMillReportsRepository adoRepo)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = jointId;
            this.notify = notify;
            this.adoRepo = adoRepo;

            #region Commands
            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify));
            newSaveJointCommand =
              ViewModelSource.Create(() => new NewSaveJointCommand(repoConstruction, this, notify));
            extractOperationsCommand =
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this));
            jointdeactivationCommand = 
                ViewModelSource.Create(() => new JointDeactivationCommand(repoConstruction, this, notify));
            #endregion

            Inspectors = repoConstruction.RepoInspector.GetAll();
            Welders = repoConstruction.RepoWelder.GetAll();
            Pieces = adoRepo.GetPipelineElements();
            extractOperationsCommand.Execute();
            if (jointId == Guid.Empty)
            {
                NewJoint();
            }
            else
            {
                this.Joint = repoConstruction.RepoJoint.Get(jointId);
                var weldResults = repoConstruction.RepoJointWeldResult.GetByJoint(this.Joint);
                if (weldResults != null)
                {
                    jointWeldResults = new BindingList<JointWeldResult>(weldResults);
                }
                var testResults = repoConstruction.RepoJointTestResult.GetByJoint(this.Joint);
                if (testResults != null)
                {
                    jointTestResults = new BindingList<JointTestResult>(testResults);
                }
            }
        }

        public void Dispose()
        {
            repoConstruction.Dispose();
            ModifiableView = null;
        }

        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        internal string FormatWelderList(IList<Welder> welders)
        {
            if (welders == null)
                return String.Empty;

            return String.Join(",", (from welder in welders select welder.Name.LastName).ToArray<string>());
        }

        public Documents.IModifiable ModifiableView
        {
            get
            {
                return modifiableView;
            }
            set
            {
                modifiableView = value;
            }
        }

        #region Commands
        public ICommand SaveJointCommand
        {
            get { return saveJointCommand; }
        }

        public ICommand ExtractOperationsCommand
        {
            get { return extractOperationsCommand; }
        }

        public ICommand NewSaveJointCommand
        {
            get { return newSaveJointCommand; }
        }

        public ICommand JointDeactivationCommand
        {
            get { return jointdeactivationCommand; }
        }
        #endregion

        # region Joint
        public bool IsNotActive
        {
            get
            {
                return Joint.IsNotActive;
            }
            set
            {
                if (value != Joint.IsNotActive)
                {
                    Joint.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        public string Number
        {
            get { return Joint.Number; }
            set
            {
                if (value != Joint.Number)
                {
                    Joint.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public DateTime LoweringDate
        {
            get
            {
                if (Joint.LoweringDate.HasValue)
                {
                    return Joint.LoweringDate.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (value != Joint.LoweringDate)
                {
                    Joint.LoweringDate = value;
                    RaisePropertyChanged("LoweringDate");
                }
            }
        }

        public float GpsHeight
        {
            get { return Joint.GpsHeight; }
            set
            {
                if (value != Joint.GpsHeight)
                {
                    Joint.GpsHeight = value;
                    RaisePropertyChanged("GpsHeight");
                }
            }
        }

        public double GpsLatitude
        {
            get { return Joint.GpsLatitude; }
            set
            {
                if (value != Joint.GpsLatitude)
                {
                    Joint.GpsLatitude = value;
                    RaisePropertyChanged("GpsLatitude");
                }
            }
        }

        public double GpsLongitude
        {
            get { return Joint.GpsLongitude; }
            set
            {
                if (value != Joint.GpsLongitude)
                {
                    Joint.GpsLongitude = value;
                    RaisePropertyChanged("GpsLongitude");
                }
            }
        }

        public int NumberKP
        {
            get { return Joint.NumberKP; }
            set
            {
                if (value != Joint.NumberKP)
                {
                    Joint.NumberKP = value;
                    RaisePropertyChanged("NumberKP");
                }
            }
        }

        public float DistanceFromKP
        {
            get { return Joint.DistanceFromKP; }
            set
            {
                if (value != Joint.DistanceFromKP)
                {
                    Joint.DistanceFromKP = value;
                    RaisePropertyChanged("DistanceFromKP");
                }
            }
        }

        public BindingList<JointTestResult> JointTestResults
        {
            get { return jointTestResults; }
            set
            {
                if (value != jointTestResults)
                {
                    jointTestResults = value;
                    RaisePropertyChanged("JointTestResults");
                }
            }
        }

        public BindingList<JointWeldResult> JointWeldResults
        {
            get { return jointWeldResults; }
            set
            {
                if (value != jointWeldResults)
                {
                    jointWeldResults = value;
                    RaisePropertyChanged("JointWeldResults");
                }
            }
        }

        public Guid FirstElementId
        {
            get
            {                
                return (Joint.FirstElement == null) ? Guid.Empty : Joint.FirstElement.Id;
            }
            set
            {
                Joint.FirstElement = FindElementById(value);
                RaisePropertyChanged("FirstElement");
            }
        }

        private PartData FindElementById(Guid id)
        {
            return (from PartData p in PartDataList where p.Id == id select p).FirstOrDefault();
        }

        public Guid SecondElementId
        {
            get
            {
                return (Joint.SecondElement == null) ? Guid.Empty : Joint.SecondElement.Id;
            }
            set
            {
                Joint.SecondElement = FindElementById(value);
                RaisePropertyChanged("SecondElement");
            }
        }

        public PartData FirstElement
        {
            get { return Joint.FirstElement; }
            set
            {
                if (value != Joint.FirstElement)
                {
                    Joint.FirstElement = value;
                    RaisePropertyChanged("FirstElement");
                }
            }
        }

        public PartData SecondElement
        {
            get { return Joint.SecondElement; }
            set
            {
                if (value != Joint.SecondElement)
                {
                    Joint.SecondElement = value;
                    RaisePropertyChanged("SecondElement");
                }
            }
        }

        #endregion

        public DataTable Pieces
        {
            get
            {
                return pieces;
            }
            set
            {
                if (value != pieces)
                {
                    value.Columns.Add("typeTranslated", typeof(String));
                    foreach (DataRow record in value.Rows)
                    {
                        string typeResourceValue;

                        if (record.Field<string>("type") != "Component")
                        {
                            typeResourceValue = Resources.ResourceManager.GetString(record.Field<string>("type"));
                        }
                        else
                        {
                            typeResourceValue = record.Field<string>("componentTypeName");
                        }

                        record.SetField("typeTranslated", typeResourceValue);
                        pieces = value;
                        RaisePropertyChanged("Pieces");
                    }
                }
            }
        }

        BindingList<PartData> list = null;

        public BindingList<PartData> PartDataList
        {
            get
            {
                if (list == null)
                {
                    list = new BindingList<PartData>();

                    foreach (DataRow row in Pieces.Rows)
                    {
                        PartData p = new PartData()
                        {
                            Id = row.Field<Guid>("id"),
                            Number = row.Field<string>("number"),
                            PartType = (PartType)Enum.Parse(typeof(PartType), row.Field<string>("type")),
                            Length = row.Field<int>("length"),
                            PartTypeDescription = row.Field<string>("typeTranslated"),
                            WallThickness = row.Field<int>("wallThickness"),
                            Diameter = row.Field<int>("diameter")
                        };
                        list.Add(p);
                    }
                }
                return list;
            }
        }

        public void NewJoint()
        {
            this.Joint = new construction.Joint();
            Joint.FirstElement = new PartData();
            Joint.SecondElement = new PartData();
            this.Joint.IsActive = true;
            this.Joint.Status = JointStatus.Welded;
            this.JointTestResults = new BindingList<JointTestResult>();
            this.JointWeldResults = new BindingList<JointWeldResult>();
            this.Number = String.Empty;
            this.LoweringDate = DateTime.MinValue;

        }
    }
}
