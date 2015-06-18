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
using Prizm.Data.DAL;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(JointNewEditViewModel));

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
        private readonly QuickSearchCommand quickSearchCommand;
        private IModifiable modifiableView;
        private IValidatable validatableView;
        private DataTable pieces;
        private BindingList<JointTestResult> jointTestResults;
        private BindingList<JointWeldResult> jointWeldResults;
        private JointStatus jointStatus;
        public List<string> localizedAllType = new List<string>();
        private PartData firstElement;
        private PartData secondElement;

        private SelectDiameterDialog selectDiameterDialog = null;
        private JointCutDialog jointCutDialog = null;

        private decimal partsCommonDiameter;

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
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this, notify));
            jointdeactivationCommand =
                ViewModelSource.Create(() => new JointDeactivationCommand(repoConstruction, this, notify, ctx));
            jointCutCommand =
                ViewModelSource.Create(() => new JointCutCommand(repoConstruction, this, notify));
            quickSearchCommand =
                ViewModelSource.Create(() => new QuickSearchCommand(this, repoConstruction.RepoJoint, notify));
            #endregion
            try
            {
                Inspectors = repoConstruction.RepoInspector.GetAll();
                if(this.Inspectors == null || this.Inspectors.Count <= 0)
                    log.Warn(string.Format("Joint (id:{0}) creation: List of Inspectors is NULL or empty", this.JointId));

                Welders = repoConstruction.RepoWelder.GetAll();
                if(this.Welders == null || this.Welders.Count <= 0)
                    log.Warn(string.Format("Joint (id:{0}) creation: List of Welders is NULL or empty", this.JointId));

                Pieces = adoRepo.GetPipelineElements();
                if(this.Pieces == null || this.Pieces.Rows.Count <= 0)
                    log.Warn(string.Format("Joint (id:{0}) creation: Data Table of Pieces is NULL or empty", this.JointId));

                extractOperationsCommand.Execute();

                if(id == Guid.Empty)
                {
                    NewJoint();
                }
                else
                {
                    this.Joint = repoConstruction.RepoJoint.Get(id);

                    RefreshJointData();
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        private void RefreshJointData()
        {
            try
            {
                if(Joint.FirstElement != null
                    && Joint.SecondElement != null
                    && Joint.Status != Domain.Entity.Construction.JointStatus.Withdrawn && Joint.IsActive)
                {
                    this.firstElement = GetPartDataFromList(Joint.FirstElement, GetPart(Joint.FirstElement));
                    this.secondElement = GetPartDataFromList(Joint.SecondElement, GetPart(Joint.SecondElement));

                    Joint.FirstElement = this.firstElement;
                    Joint.SecondElement = this.secondElement;
                }
                else if (!Joint.IsActive)
                {
                    GeneratePartDataForInactiveJoint();
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not has connected Parts or is Withdrawn.", Joint.Number));
                }

                var weldResults = this.repoConstruction.RepoJointWeldResult.GetByJoint(this.Joint);
                if(weldResults != null)
                {
                    jointWeldResults = new BindingList<JointWeldResult>(weldResults);
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not have Welding Results.", Joint.Number));
                }

                var testResults = this.repoConstruction.RepoJointTestResult.GetByJoint(this.Joint);
                if(testResults != null)
                {
                    jointTestResults = new BindingList<JointTestResult>(testResults);
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not have Test Results.", Joint.Number));
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public void Dispose()
        {
            repoConstruction.Dispose();
            ModifiableView = null;
            if(FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
                FilesFormViewModel = null;
            }
        }

        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if(inspectors == null)
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

        public ICommand QuickSearchCommand
        {
            get { return quickSearchCommand; }
        }
        #endregion

        public string SearchNumber { get; set; }

        # region Joint

        public bool JointIsActive
        {
            get { return Joint.IsActive; }
            set
            {
                if(value != Joint.IsActive)
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
                if(value != Joint.Number)
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
                    UpdateStatus();
                }
            }
        }

        public decimal GpsHeight
        {
            get { return Joint.GpsHeight; }
            set
            {
                if(value != Joint.GpsHeight)
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
                if(value != Joint.GpsLatitude)
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
                if(value != Joint.GpsLongitude)
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
                if(value != Joint.NumberKP)
                {
                    Joint.NumberKP = value;
                    RaisePropertyChanged("NumberKP");
                }
            }
        }

        public decimal DistanceFromKP
        {
            get { return Joint.DistanceFromKP; }
            set
            {
                if(value != Joint.DistanceFromKP)
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
                if(value != jointTestResults)
                {
                    jointTestResults = value;
                    RaisePropertyChanged("JointTestResults");
                    RaisePropertyChanged("JointConstructionStatus");
                }
            }
        }

        public BindingList<JointWeldResult> JointWeldResults
        {
            get { return jointWeldResults; }
            set
            {
                if(value != jointWeldResults)
                {
                    jointWeldResults = value;
                    RaisePropertyChanged("JointWeldResults");
                }
            }
        }

        public Guid FirstElementId
        {
            get { return (this.FirstElement == null) ? Guid.Empty : this.FirstElement.Id; }
            set
            {
                this.FirstElement = FindElementById(value);
                RaisePropertyChanged("FirstElement");
            }
        }

        public Guid SecondElementId
        {
            get { return (this.SecondElement == null) ? Guid.Empty : this.SecondElement.Id; }
            set
            {
                this.SecondElement = FindElementById(value);
                RaisePropertyChanged("SecondElement");
            }
        }

        public PartData FirstElement
        {
            get { return firstElement; }
            set
            {
                if(value != firstElement)
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
                if(value != secondElement)
                {
                    secondElement = value;
                    RaisePropertyChanged("SecondElement");
                }
            }
        }

        private PartData FindElementById(Guid id)
        {
            return PartDataList != null ? PartDataList.FirstOrDefault<PartData>(x => x.Id == id) : null;
        }

        public JointStatus JointConstructionStatus
        {
            get
            {
                jointStatus = Joint.Status;
                return jointStatus;
            }
            set
            {
                if(value != Joint.Status)
                {
                    jointStatus = value;
                    Joint.Status = value;
                    RaisePropertyChanged("JointConstructionStatus");
                    RaisePropertyChanged("IsNotWithdrawn");
                }
            }
        }

        public void UpdateStatus() 
        {
            bool isJointReadyTolowered = CheckStatus();

            if (!isJointReadyTolowered && Joint.Status != JointStatus.Withdrawn)
            {
                Joint.Status = JointStatus.Welded;
            }
            if (isJointReadyTolowered && LoweringDate != DateTime.MinValue && Joint.Status != JointStatus.Withdrawn)
            {
                Joint.Status = JointStatus.Lowered;
            }
            if (Joint.JointWeldResults
                .Where(_ => _.Date == JointWeldResults.Max(x => x.Date))
                .Any(x => x.Operation != null && x.Operation.Type == JointOperationType.Withdraw && x.IsCompleted))
            {
                Joint.Status = JointStatus.Withdrawn;
            }

            RaisePropertyChanged("JointConstructionStatus");
        }

        public List<string> orderTestResult()
        {
            List<string> testsResults = new List<string>();

            // order by operation name
            var query = Joint.JointTestResults.GroupBy(test => test.Operation.Name, (name, results) => new
            {
                Key = name, // operation name
                Date = results.Max(t => t.Date) // max date in group
            });

            foreach (var result in query)
            {
                var lastOperation =
                    from p in Joint.JointTestResults
                    where p.Date == result.Date && p.Operation.Name == result.Key
                    select p;

                if (lastOperation.Count() >= 2)
                {
                    int maxOrder = lastOperation.Max(o => o.Order);

                    var lastOperation2 =
                        from p in lastOperation
                        where p.Order == maxOrder
                        select p;

                    foreach (var t in lastOperation2)
                    {
                        testsResults.Add(t.Status.ToString());
                    }
                }
                else
                {
                    foreach (var t in lastOperation)
                    {
                        testsResults.Add(t.Status.ToString());
                    }
                }
            }

            return testsResults;
        }
       
        public bool CheckStatus()
        {
            bool resultValue = true;

            List<string> testsResults = orderTestResult();

                resultValue =
                    !(testsResults.Contains(JointTestResultStatus.Repair.ToString())
                    || testsResults.Contains(JointTestResultStatus.Withdraw.ToString()));

            return resultValue;
        }
        
        public bool IsNotWithdrawn
        {
            get { return JointConstructionStatus != JointStatus.Withdrawn; }
        }

        #region ===== Makeing The Connection =====
        /// <summary>
        /// This method joint FirstElement and SecondElement
        /// </summary>
        /// <returns>The method retuns ability of joint creation</returns>
        public bool MakeTheConnection()
        {
            partsCommonDiameter = GetCommonDiameter(firstElement, secondElement);

            if(partsCommonDiameter == -1 || FirstElement.Id == Guid.Empty || SecondElement.Id == Guid.Empty)
            {
                return false;
            }

            if(this.Joint.FirstElement.Number != null || this.Joint.SecondElement.Number != null)
            {
                this.JointDisconnection();
            }

            Joint.FirstElement = firstElement;
            Joint.SecondElement = secondElement;

            var jointElements = new List<Part> { GetPart(firstElement), GetPart(secondElement) };

            foreach(var part in jointElements)
            {
                if(part is construction.Component)
                {
                    construction.Component component = part as construction.Component;

                    component.ToExport = true;

                    foreach(var con in component.Connectors)
                    {
                        if(Math.Abs(con.Diameter - partsCommonDiameter) <= Prizm.Main.Common.Constants.DiameterDiffLimit && (con.Joint == null || con.Joint.Id == Guid.Empty))
                        {
                            con.Joint = Joint;
                            break;
                        }
                    }
                }
                else
                {
                    if(part is Pipe)
                    {
                        Pipe pipe = part as Pipe;
                        pipe.ToExport = true;
                    }
                    else
                    {
                        construction.Spool spool = part as construction.Spool;
                        spool.Pipe.ToExport = true;
                    }
                    if(part.ConstructionStatus == PartConstructionStatus.Pending)
                    {
                        switch(Joint.Status)
                        {
                            case JointStatus.Lowered:
                                part.ConstructionStatus = PartConstructionStatus.Lowered;
                                break;
                            case JointStatus.Welded:
                                part.ConstructionStatus = PartConstructionStatus.Welded;
                                break;
                            default:
                                part.ConstructionStatus = PartConstructionStatus.Pending;
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

            foreach(var part in jointElements)
            {
                if(part == null)
                    continue;

                if(part is construction.Component)
                {
                    var component = part as construction.Component;

                    component.ToExport = false;

                    foreach(var connector in component.Connectors)
                    {
                        if(connector.Joint != null)
                        {
                            if(connector.Joint.Id == this.Joint.Id &&
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
                    if(part is Pipe)
                    {
                        Pipe pipe = part as Pipe;
                        pipe.ToExport = false;
                    }
                    else
                    {
                        construction.Spool spool = part as construction.Spool;
                        spool.Pipe.ToExport = false;
                    }
                    if(part.IsAvailableToJoint == false)
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
            Part part = null;
            try
            {
                if(partData.PartType == PartType.Component)
                {
                    part = repoConstruction.RepoComponent.Get(partData.Id);
                }
                else if(partData.PartType == PartType.Pipe)
                {
                    part = repoConstruction.RepoPipe.Get(partData.Id);
                }
                else
                {
                    part = repoConstruction.RepoSpool.Get(partData.Id);
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
            if(part == null)
                log.Warn(string.Format("Part id:{0} is not found in the database", partData.Id));
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
        private decimal GetCommonDiameter(PartData firstElement, PartData secondElement)
        {
            decimal commonDiameter;

            var duplicates =
                firstElement.Connectors
                .Intersect(secondElement.Connectors, new ConnectorComparer())
                .ToList<construction.Connector>();

            if(duplicates.Count == 0)
            {
                commonDiameter = -1;
            }
            else if(duplicates.Count == 1)
            {
                commonDiameter = duplicates.First<construction.Connector>(x => true).Diameter;
            }
            else
            {
                this.SetSelectDiameterDialog(duplicates);

                if(selectDiameterDialog.ShowDialog() == DialogResult.OK)
                {
                    commonDiameter = selectDiameterDialog.Diameter;
                }
                else
                {
                    commonDiameter = -1;
                }
            }

            return commonDiameter;
        }

        private void SetSelectDiameterDialog(List<Connector> duplicates)
        {
            if(selectDiameterDialog == null)
            {
                selectDiameterDialog = new SelectDiameterDialog();
            }
            selectDiameterDialog.InitializeSelectDiameter(duplicates);
        }

        /// <summary>
        /// The specific Comparer for Intersect method of connectors List,
        /// which checks by the diameter value
        /// </summary>
        private class ConnectorComparer : IEqualityComparer<construction.Connector>
        {
            public bool Equals(construction.Connector x, construction.Connector y)
            {
                if(Object.ReferenceEquals(x, y))
                    return true;

                if(Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                    return false;

                return (Math.Abs(x.Diameter - y.Diameter) <= Prizm.Main.Common.Constants.DiameterDiffLimit &&
                        Math.Abs(x.WallThickness - y.WallThickness) <= Prizm.Main.Common.Constants.ThicknessDiffLimit);

            }

            public int GetHashCode(construction.Connector connector)
            {
                if(Object.ReferenceEquals(connector, null))
                    return 0;

                return 1;
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
                value.Columns.Add("typeTranslated", typeof(String));

                foreach(DataRow record in value.Rows)
                {
                    string typeResourceValue;

                    if(record.Field<string>("type") != "Component")
                    {
                        typeResourceValue = Resources.ResourceManager.GetString(record.Field<string>("type"));
                    }
                    else
                    {
                        typeResourceValue = record.Field<string>("componentTypeName");
                    }

                    record.SetField("typeTranslated", typeResourceValue);

                    pieces = value;
                }
            }
        }

        private BindingList<PartData> list = null;

        public BindingList<PartData> PartDataList
        {
            get
            {
                if(list == null && Pieces != null)
                {
                    Guid tempId = Guid.Empty;

                    list = new BindingList<PartData>();

                    PartData partData = new PartData();

                    foreach(DataRow row in Pieces.Rows)
                    {
                        if(tempId != row.Field<Guid>("id"))
                        {
                            partData = new PartData(row);

                            partData.SetPartConnectors(row);

                            list.Add(partData);

                            tempId = row.Field<Guid>("id");
                        }
                        else
                        {
                            partData.SetPartConnectors(row);
                        }
                    }
                }
                return list;
            }

            set { list = value; }
        }

        /// <summary>
        /// The method gets PartData from list if current element has isAvaliableToJoint = true 
        /// (if isAvaliableToJoint = false element will be added to list)
        /// </summary>
        /// <param name="partData">current PartData-element</param>
        /// <param name="part">corresponding Part-element</param>
        /// <returns>PartData-element from this.PartDataList</returns>
        private PartData GetPartDataFromList(PartData partData, Part part)
        {
            if(PartDataList == null) { PartDataList = new BindingList<PartData>(); }

            if(PartDataList.Where<PartData>(x => x.Id == partData.Id).Count<PartData>() == 0)
            {
                PartData p = new PartData(part, this.Joint.Id);

                if(partData.PartType == PartType.Pipe)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Pipe));
                }
                else if(partData.PartType == PartType.Spool)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Spool));
                }

                list.Add(p);
            }
            else
            {
                var connector = new Connector();

                if(part is construction.Component)
                {
                    if(Joint.IsActive)
                    {
                        connector.Diameter = ((construction.Component)part)
                            .Connectors
                            .First<Connector>(x => x.Joint != null && x.Joint.Id == this.Joint.Id)
                            .Diameter;
                        connector.WallThickness = ((construction.Component)part)
                           .Connectors
                           .First<Connector>(x => x.Joint != null && x.Joint.Id == this.Joint.Id)
                           .WallThickness;
                    }
                }
                else if(part is Pipe)
                {
                    connector.Diameter = ((Pipe)part).Diameter;
                    connector.WallThickness = ((Pipe)part).WallThickness;
                }
                else
                {
                    connector.Diameter = ((construction.Spool)part).Pipe.Diameter;
                    connector.WallThickness = ((construction.Spool)part).Pipe.WallThickness;
                }

                PartDataList.First<PartData>(x => x.Id == partData.Id).Connectors.Add(connector);

            }
            return PartDataList.First<PartData>(x => x.Id == partData.Id);
        }

        public void RemovePartDataFromList(PartData partData)
        {
            if(list.Any<PartData>(x => x.Id == partData.Id))
            {
                var part = this.GetPart(partData);

                if((part is Pipe || part is construction.Spool)
                            && !part.IsAvailableToJoint
                    ||
                    part is construction.Component
                            && !((construction.Component)part).Connectors
                                    .Any<Connector>(x => x.Joint == null || x.Joint.Id == Guid.Empty))
                {
                    list.Remove(list.First<PartData>(x => x.Id == partData.Id));
                }
                else
                {
                    partData.Connectors
                        .Remove(partData.Connectors.First<Connector>
                        (x => Math.Abs(x.Diameter - partsCommonDiameter) <= Prizm.Main.Common.Constants.DiameterDiffLimit));
                }
            }
        }

        public void NewJoint()
        {
            try
            {
                this.Joint = new construction.Joint();
                Joint.FirstElement = new PartData();
                Joint.SecondElement = new PartData();
                this.Joint.IsActive = true;
                this.Joint.Status = JointStatus.Welded;
                this.JointTestResults = new BindingList<JointTestResult>();
                if(this.FilesFormViewModel != null)
                {
                    this.FilesFormViewModel.Files = null;
                }
                //required operation
                if(repoConstruction.RepoJointOperation.GetRequiredWeld() != null)
                {
                    JointWeldResult requredWeldResult = new JointWeldResult()
                    {
                        IsActive = true,
                        Operation = repoConstruction.RepoJointOperation.GetRequiredWeld(),
                        // first weld operation should be always completed
                        IsCompleted = true,
                        Joint = this.Joint
                    };
                    jointWeldResults = new BindingList<JointWeldResult>() { requredWeldResult };
                    this.Joint.JointWeldResults.Add(requredWeldResult);
                }
                else
                {
                    this.JointWeldResults = new BindingList<JointWeldResult>();
                }
                this.Number = String.Empty;
                this.LoweringDate = DateTime.MinValue;
                this.Joint.ToExport = false;
                this.NumberKP = int.MinValue;
                this.FirstElement = null;
                this.SecondElement = null;
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public void RefreshJointComponents()
        {
            try
            {
                this.list = null;
                this.Pieces = adoRepo.GetPipelineElements();
            if (!Joint.IsNew() && Joint.Status != JointStatus.Withdrawn)
                {
                    if (Joint.IsActive)
                    {
                        this.firstElement = GetPartDataFromList(Joint.FirstElement, GetPart(Joint.FirstElement));
                        this.secondElement = GetPartDataFromList(Joint.SecondElement, GetPart(Joint.SecondElement));
                    }
                    else
                    {
                        GeneratePartDataForInactiveJoint();
                    }
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public void JointCut()
        {
            var jointElements = new List<Part> { GetPart(this.Joint.FirstElement), GetPart(this.Joint.SecondElement) };

            if(jointElements.Where<Part>(x => x == null).Count<Part>() == 0)
            {
                this.SetJointCutDialog(jointElements.First(), jointElements.Last());

                if(jointCutDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Part part in jointElements)
                    {
                        part.IsWithdrawn = true;
                    }
                    this.JointCutCommand.Execute();
                }
            }
        }

        private void SetJointCutDialog(Part part1, Part part2)
        {
            if(jointCutDialog == null)
            {
                jointCutDialog = new JointCutDialog();
            }
            jointCutDialog.InitializeJointCut(part1, part2);
        }

        public void ChangeJoint(construction.Joint joint)
        {
            try
            {
                this.Joint = repoConstruction.RepoJoint.Get(joint.Id);
                RefreshJointData();
                RaisePropertyChanged("Joint");
                ModifiableView.IsModified = false;
                ModifiableView.IsEditMode = this.Joint.IsActive;
            }
            catch(RepositoryException ex)
            {
                log.Warn("JointNewEditViewModel " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        /// <summary>
        /// TODO : Think about refactoring
        ///Solves issue with rewelded components: when joint is deactivated and components from deactivated joint are used in another 
        ///joint - references are lost and common part data loading approach cannot be used. Properties are reset to display valid 
        ///data in first and second connected elements edits on form
        /// </summary>
        private void GeneratePartDataForInactiveJoint()
        {
            Part P1 = GetPart(Joint.FirstElement);
            Part P2 = GetPart(Joint.SecondElement);
            if (Joint.FirstElement == null)
            {
                Joint.FirstElement = new PartData();
            }
            Joint.FirstElement.Number = P1.Number;
            if (Joint.SecondElement == null)
            {
                Joint.SecondElement = new PartData();
            }
            Joint.SecondElement.Number = P2.Number;
            if (PartDataList == null) { PartDataList = new BindingList<PartData>(); }
            this.FirstElement = Joint.FirstElement;
            this.SecondElement = Joint.SecondElement;
            PartDataList.Add(Joint.FirstElement);
            PartDataList.Add(Joint.SecondElement);
        }

    }
}
