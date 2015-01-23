using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraCharts.Native;
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
using System.Windows.Forms;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Common;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IConstructionRepository repoConstruction;
        private readonly Prizm.Data.DAL.IMillReportsRepository adoRepo;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;
        private readonly SaveJointCommand saveJointCommand;
        private readonly NewSaveJointCommand newSaveJointCommand;
        private readonly ExtractOperationsCommand extractOperationsCommand;
        private readonly JointDeactivationCommand jointdeactivationCommand;
        private readonly JointCutCommand jointCutCommand;
        private readonly SaveOrUpdateJointCommand saveOrUpdateJointCommand;
        private IModifiable modifiableView;
        private IValidatable validatableView;
        private DataTable pieces;
        private BindingList<JointTestResult> jointTestResults;
        private BindingList<JointWeldResult> jointWeldResults;

        private PartData firstElement;
        private PartData secondElement;

        public construction.Joint Joint { get; set; }
        public Guid JointId { get; set; }
        public BindingList<JointOperation> ControlOperations;
        public BindingList<JointOperation> RepairOperations;
        public IList<Inspector> Inspectors { get; set; }
        public IList<Welder> Welders { get; set; }
        public ExternalFilesViewModel FilesFormViewModel { get; set; }


        public bool IsNew { get { return this.Joint.IsNew(); } }

        [Inject]
        public JointNewEditViewModel(
            IConstructionRepository repoConstruction, 
            IUserNotify notify, 
            Guid id, 
            Prizm.Data.DAL.IMillReportsRepository adoRepo,
            ISecurityContext ctx)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = id;
            this.notify = notify;
            this.adoRepo = adoRepo;
            this.ctx = ctx;

            #region Commands
            saveOrUpdateJointCommand =
                ViewModelSource.Create(() => new SaveOrUpdateJointCommand(repoConstruction, this, notify, ctx));
            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify, ctx));
            newSaveJointCommand =
              ViewModelSource.Create(() => new NewSaveJointCommand(repoConstruction, this, notify, ctx));
            extractOperationsCommand =
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this));
            jointdeactivationCommand = 
                ViewModelSource.Create(() => new JointDeactivationCommand(repoConstruction, this, notify, ctx));
            jointCutCommand =
                ViewModelSource.Create(() => new JointCutCommand(repoConstruction, this, notify));
            #endregion

            Inspectors = repoConstruction.RepoInspector.GetAll();
            Welders = repoConstruction.RepoWelder.GetAll();
            Pieces = adoRepo.GetPipelineElements();
            extractOperationsCommand.Execute();

            if(id == Guid.Empty)
            {
                NewJoint();
            }
            else
            {
                this.Joint = repoConstruction.RepoJoint.Get(id);

                if (Joint.FirstElement != null)
                {
                    FirstElement = GetPartDataFromList(Joint.FirstElement, GetPart(Joint.FirstElement));
                }
                if (Joint.SecondElement != null)
                {
                    SecondElement = GetPartDataFromList(Joint.SecondElement, GetPart(Joint.SecondElement));
                }

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
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return string.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        internal string FormatWelderList(IList<Welder> welders)
        {
            if(welders == null)
                return string.Empty;

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

        public IValidatable ValidatableView
        {
            get { return validatableView; }
            set { validatableView = value; }
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

        public ICommand JointCutCommand
        {
            get { return jointCutCommand; }
        }

        public ICommand SaveOrUpdateJointCommand
        {
            get { return saveOrUpdateJointCommand; }
        }
        #endregion

        # region Joint

        public bool JointIsActive
        {
            get { return Joint.IsActive; }
            set
            {
                if (value != Joint.IsActive)
                {
                    Joint.IsActive = value;
                    RaisePropertyChanged("JointIsActive");
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
                    RaisePropertyChanged("JointConstructionStatus");
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
            get { return firstElement; }
            set
            {
                if (value != firstElement)
                {
                    firstElement = value;
                    RaisePropertyChanged("FirstElement");
                }
            }
        }

        public PartData SecondElement
        {
            get { return secondElement; }
            set
            {
                if (value != secondElement)
                {
                    secondElement = value;
                    RaisePropertyChanged("SecondElement");
                }
            }
        }

        private PartData FindElementById(Guid id)
        {
            return (from PartData p in PartDataList where p.Id == id select p).FirstOrDefault();
        }

        public EnumWrapper<JointStatus> JointConstructionStatus
        {
            get 
            {
                Joint.Status = JointStatus.Welded;
                if (LoweringDate != DateTime.MinValue)
                {
                    Joint.Status = JointStatus.Lowered;
                }
                if (Joint.JointWeldResults.Where(_ => _.Date == JointWeldResults.Max(x => x.Date)).Any(x => x.Operation.Type == JointOperationType.Withdraw))
                {
                    Joint.Status = JointStatus.Withdrawn;
                }
                if (Joint.IsActive == false)
                {
                    Joint.Status = JointStatus.Deactivated;
                }
                return new EnumWrapper<JointStatus>() { Value = Joint.Status}; 
            }
            set 
            {
                if (value.Value != Joint.Status)
                {
                    JointConstructionStatus = value;
                    Joint.Status = value.Value;
                    RaisePropertyChanged("JointConstructionStatus");
                }
            }
        }

        #region ===== Makeing The Connection =====
        /// <summary>
        /// This method joint FirstElement and SecondElement
        /// </summary>
        /// <returns>The method retuns ability of joint creation</returns>
        public bool MakeTheConnection()
        {
            Joint.FirstElement = firstElement;
            Joint.SecondElement = secondElement;

            var jointElements = new List<Part> { GetPart(firstElement), GetPart(secondElement) };

            int commonDiameter = GetCommonDiameter(firstElement, secondElement);

            if (FirstElement.Id == Guid.Empty ||
                SecondElement.Id == Guid.Empty ||
                commonDiameter == -1)
            {
                return false;
            }

            foreach (var part in jointElements)
            {
                if (part is construction.Component)
                {
                    construction.Component component = part as construction.Component;

                    foreach (var con in component.Connectors)
                    {
                        if (con.Diameter == commonDiameter &&
                            (con.Joint == null || con.Joint.Id == Guid.Empty))
                        {
                            con.Joint = Joint;
                            break;
                        }
                    }
                }
                else
                {
                    if (part.ConstructionStatus == PartConstructionStatus.Pending)
                    {
                        switch (Joint.Status)
                        {
                            case JointStatus.Lowered: part.ConstructionStatus = PartConstructionStatus.Lowered;
                                break;
                            case JointStatus.Welded: part.ConstructionStatus = PartConstructionStatus.Welded;
                                break;
                            default: part.ConstructionStatus = PartConstructionStatus.Pending;
                                break;
                        }
                    }
                    else
                    {
                        part.IsAvailableToJoint = false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// This method Sets connectors of the Part elements correspond PartData FirstElement 
        /// and SecondElement in "is available to joint" state. 
        /// </summary>
        public void JointDisconnection()
        {
            var jointElements = new List<Part> { GetPart(this.Joint.FirstElement), GetPart(this.Joint.SecondElement) };

            foreach (var part in jointElements)
            {
                if (part == null) continue;

                if (part is construction.Component)
                {
                    var component = part as construction.Component;

                    foreach (var connector in component.Connectors)
                    {
                        if (connector.Joint != null)
                        {
                            if (connector.Joint.Id == this.Joint.Id &&
                                connector.Joint.Id != Guid.Empty ||
                                connector.Joint == this.Joint)
                            {
                                connector.Joint = null;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (part.IsAvailableToJoint == false)
                    {
                        part.IsAvailableToJoint = true;
                    }
                    else
                    {
                        part.ConstructionStatus = PartConstructionStatus.Pending;
                    }
                }
            }
        }

        /// <summary>
        /// This method returns the element Part by the specified element 
        /// PartData according to its type: Spool, Pipe or Component
        /// </summary>
        /// <param name="partData"></param>
        /// <returns>corespond element Part</returns>
        private Part GetPart(PartData partData)
        {
            Part part;

            if (partData.PartType == PartType.Component)
            {
                part = repoConstruction.RepoComponent.Get(partData.Id);
            }
            else if (partData.PartType == PartType.Pipe)
            {
                part = repoConstruction.RepoPipe.Get(partData.Id);
            }
            else
            {
                part = repoConstruction.RepoSpool.Get(partData.Id);
            }

            return part;
        }

        /// <summary>
        /// The method returns a value coinciding the diameter of joined elements. 
        /// In the case of multiple coinciding diameters the joined diameter selects by user. 
        /// If there is no coinciding the method returns -1.
        /// </summary>
        /// <param name="firstElement">the first connectable element</param>
        /// <param name="secondElement">the second connectable element</param>
        /// <returns></returns>
        private int GetCommonDiameter(PartData firstElement, PartData secondElement)
        {
            int commonDiameter;

            var duplicates =
                firstElement.Connectors
                .Intersect(secondElement.Connectors, new ConnectorComparer())
                .ToList<construction.Connector>();

            if (duplicates.Count == 0)
            {
                commonDiameter = - 1;
            }
            else if (duplicates.Count == 1)
            {
                commonDiameter = duplicates.First<construction.Connector>(x => true).Diameter;
            }
            else
            {
                var choiceDiameter = new SelectDiameterDialog(duplicates);

                if (choiceDiameter.ShowDialog() == DialogResult.OK)
                {
                    commonDiameter = choiceDiameter.Diameter;
                }
                else
                {
                    commonDiameter = - 1;
                }
            }

            return commonDiameter;
        }

        /// <summary>
        /// The specific Comparer for Intersect method of connectors List,
        /// which checks by the diameter value
        /// </summary>
        private class ConnectorComparer : IEqualityComparer<construction.Connector>
        {
            public bool Equals(construction.Connector x, construction.Connector y)
            {
                if (Object.ReferenceEquals(x, y))
                    return true;

                if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                    return false;

                return x.Diameter == y.Diameter;
            }

            public int GetHashCode(construction.Connector connector)
            {
                if (Object.ReferenceEquals(connector, null))
                    return 0;

                return connector.Diameter.GetHashCode();
            }

        }

        #endregion ===============================


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

        private BindingList<PartData> list = null;

        public BindingList<PartData> PartDataList
        {
            get
            {
                if (Pieces != null)
                {
                    Guid tempId = Guid.Empty;
                    string tempNumber = string.Empty;

                    list = new BindingList<PartData>();

                    PartData partData = new PartData();

                    foreach (DataRow row in Pieces.Rows)
                    {
                        if (tempId != row.Field<Guid>("id")
                            && tempNumber != row.Field<string>("number"))
                        {
                            partData = new PartData(row);

                            partData.SetPartConnectors(row);

                            list.Add(partData);

                            tempId = row.Field<Guid>("id");
                            tempNumber = row.Field<string>("number");
                        }
                        else
                        {
                            partData.SetPartConnectors(row);
                        }
                    }
                    // crutch for displaying data of connected elements
                    if (Joint.FirstElement.Number != null && list.Where<PartData>(x => x.Id == Joint.FirstElement.Id).Count<PartData>() == 0)
                        list.Add(Joint.FirstElement);
                    if (Joint.SecondElement.Number != null && list.Where<PartData>(x => x.Id == Joint.SecondElement.Id).Count<PartData>() == 0)
                        list.Add(Joint.SecondElement);
                }
                return list;
            }

            set { list = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partData"></param>
        /// <param name="part"></param>
        /// <returns></returns>
        private PartData GetPartDataFromList(PartData partData, Part part)
        {
            PartData p;

            if (PartDataList == null)
            {
                PartDataList = new BindingList<PartData>();
            }

            if (PartDataList.Where<PartData>(x => x.Id == partData.Id).Count<PartData>() == 0)
            {
                p = new PartData(part, this.Joint.Id);

                if (partData.PartType == PartType.Pipe)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Pipe));
                }
                else if (partData.PartType == PartType.Spool)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Spool));
                }
            }
            else
            {
                var connector = new Connector();

                if (part is construction.Component)
                {
                    if (Joint.IsActive)
                    {
                        connector.Diameter = ((construction.Component)part)
                            .Connectors
                            .First<Connector>(x => x.Joint != null && x.Joint.Id == this.Joint.Id)
                            .Diameter;
                    }
                }
                else if (part is Pipe)
                {
                    connector.Diameter = ((Pipe)part).Diameter;
                }
                else
                {
                    connector.Diameter = ((construction.Spool)part).Pipe.Diameter;
                }

                p = PartDataList.First<PartData>(x => x.Id == partData.Id);

                p.Connectors.Add(connector);
            }

            return p;
        }

        public void NewJoint()
        {
            this.Joint = new construction.Joint();
            Joint.FirstElement = new PartData();
            Joint.SecondElement = new PartData();
            this.Joint.IsActive = true;
            this.Joint.Status = JointStatus.Welded;
            this.JointTestResults = new BindingList<JointTestResult>();
            JointWeldResult requredWeldResult = new JointWeldResult()
            { 
                IsActive = true,
                Operation = repoConstruction.RepoJointOperation.GetRequiredWeld(Resources.RequiredWeldJointOperation), 
                Joint = this.Joint
            };
            jointWeldResults = new BindingList<JointWeldResult>() {requredWeldResult};
            this.Joint.JointWeldResults.Add(requredWeldResult);
            this.Number = String.Empty;
            this.LoweringDate = DateTime.MinValue;
            this.Joint.ToExport = false;
        }

        public void RefreshJointComponents()
        {
            Pieces = adoRepo.GetPipelineElements();
        }

        public void JointCut()
        {
            var jointElements = new List<Part> { GetPart(this.Joint.FirstElement), GetPart(this.Joint.SecondElement) };

            if (jointElements.Where<Part>(x => x == null).Count<Part>() == 0)
            {
                var jointCutDialog = new JointCutDialog(jointElements[0], jointElements[1]);

                if (jointCutDialog.ShowDialog() == DialogResult.OK)
                {
                    this.JointCutCommand.Execute();
                }
            }
        }

    }
}
