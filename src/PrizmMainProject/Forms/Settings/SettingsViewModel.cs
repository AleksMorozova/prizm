using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using Prizm.Main.Documents;
using Prizm.Domain.Entity.Security;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Security;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Settings
{
    public class SettingsViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SettingsViewModel));
        private PipeMillSizeType currentPipeMillSizeType;
        public BindingList<PipeMillSizeType> PipeMillSizeType { get; set; }
        public Project CurrentProjectSettings { get; set; }
        public BindingList<WelderViewType> Welders { get; set; }
        public BindingList<InspectorViewType> Inspectors { get; set; }
        public BindingList<EnumWrapper<PipeTestControlType>> ControlType { get; set; }
        public BindingList<EnumWrapper<PipeTestResultType>> ResultType { get; set; }
        public BindingList<Role> Roles { get; set; }
        public BindingList<Permission> Permissions { get; set; }
        public BindingList<User> Users { get; set; }
        public BindingList<InspectorCertificateType> CertificateTypes { get; set; }
        public BindingList<SeamType> SeamTypes { get; set; }
        public BindingList<JointOperation> JointOperations { get; set; }
        public IList<EnumWrapper<JointOperationType>> JointOperationTypes;
        public IValidatable validatableView { get; set; }

        readonly SaveSettingsCommand saveCommand;
        readonly ExtractCategoriesCommand extractCategoriesCommand;

        readonly ISettingsRepositories repos;
        readonly IUserNotify notify;
        private BindingList<PlateManufacturer> plateManufacturers;
        private IModifiable modifiable;
        private readonly ISecurityContext ctx;


        [Inject]
        public SettingsViewModel(ISettingsRepositories repos, IUserNotify notify, ISecurityContext ctx)
        {
            NewPipeMillSizeType();
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;

            saveCommand = ViewModelSource
                .Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repos, notify, ctx));

            extractCategoriesCommand = ViewModelSource
                .Create<ExtractCategoriesCommand>(() => new ExtractCategoriesCommand(this, repos, notify));

            this.ExtractCategoriesCommand.Execute();
            CategoryTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
            PipeTests.ListChanged += (s, e) => ModifiableView.IsModified = true;

        }

        public void LoadData()
        {
            try
            {
                GetAllCertificateTypes();
                GetAllSeamTypes();
                GetAllPipeMillSizeType();
                GetAllWelders();
                GetAllInspectors();
                GetAllPermissions();
                GetAllRoles();
                GetAllUsers();
                GetProjectSettings();
                GetAllManufacturers();
                GetAllJointOperations();
                LoadJointOperationTypes();
                GetAllComponentryTypes();
                ControlType = new BindingList<EnumWrapper<PipeTestControlType>>();
                ResultType = new BindingList<EnumWrapper<PipeTestResultType>>();

                foreach(string controlTypeName in Enum.GetNames(typeof(PipeTestControlType)))
                {
                    if(controlTypeName != Enum.GetName(typeof(PipeTestControlType), PipeTestControlType.Undefined))
                        ControlType.Add(new EnumWrapper<PipeTestControlType>()
                        {
                            Value = (PipeTestControlType)Enum.Parse(typeof(PipeTestControlType), controlTypeName)
                        }
                        );
                }

                foreach(string resultTypeName in Enum.GetNames(typeof(PipeTestResultType)))
                {
                    if(resultTypeName != Enum.GetName(typeof(PipeTestResultType), PipeTestResultType.Undefined))
                        ResultType.Add(new EnumWrapper<PipeTestResultType>()
                        {
                            Value = (PipeTestResultType)Enum.Parse(typeof(PipeTestResultType), resultTypeName)
                        }
                        );
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        private void GetAllUsers()
        {
            if(Users == null)
                Users = new BindingList<User>();

            IList<User> users = repos.UserRepo.GetAll();
            foreach(var u in users)
            {
                Users.Add(u);
            }
        }

        private void GetAllPermissions()
        {
            if(Permissions == null)
                Permissions = new BindingList<Permission>();

            IList<Permission> perms = repos.PermissionRepo.GetAll();
            foreach(var p in perms)
            {
                string id = "SecurityPrivilege_" + p.Name;
                StringResource? res = Program.LanguageManager.FindById(typeof(StringResources), id);
                if(res != null)
                {
                    p.NameTranslation = Program.LanguageManager.GetString((StringResource)res);
                }
                else
                {
                    var ex = new ApplicationException("No resource description defined for " + id);
                    log.Error(ex.Message);
                    throw ex;
                }
                Permissions.Add(p);
            }
        }

        private void GetAllRoles()
        {
            if(Roles == null)
                Roles = new BindingList<Role>();

            IList<Role> roles = repos.RoleRepo.GetAll();
            foreach(var r in roles)
            {
                Roles.Add(r);
            }
        }

        private BindingList<PipeTest> pipeTests = new BindingList<PipeTest>();
        public BindingList<PipeTest> PipeTests
        {
            get
            {
                return pipeTests;
            }
            set
            {
                if(value != pipeTests)
                {
                    pipeTests = value;
                    RaisePropertyChanged("pipeTests");
                }
            }
        }

        public BindingList<Category> CategoryTypes { get; set; }

        public BindingList<ComponentType> ComponentryTypes { get; set; }

        #region Current Project Settings

        public string Client
        {
            get
            {
                return CurrentProjectSettings.Client;
            }
            set
            {
                if(value != CurrentProjectSettings.Client)
                {
                    CurrentProjectSettings.Client = value;
                    RaisePropertyChanged("Client");
                }
            }
        }

        public string MillName
        {
            get
            {
                return CurrentProjectSettings.MillName;
            }
            set
            {
                if(value != CurrentProjectSettings.MillName)
                {
                    CurrentProjectSettings.MillName = value;
                    RaisePropertyChanged("MillName");
                }
            }
        }

        public int DocumentSizeLimit
        {
            get
            {
                return CurrentProjectSettings.DocumentSizeLimit;
            }
            set
            {
                if(value != CurrentProjectSettings.DocumentSizeLimit)
                {
                    CurrentProjectSettings.DocumentSizeLimit = value;
                    RaisePropertyChanged("DocumentSizeLimit");
                }
            }
        }

        public string MillPipeNumberMask
        {
            get
            {
                return CurrentProjectSettings.MillPipeNumberMask;
            }
            set
            {
                if(value != CurrentProjectSettings.MillPipeNumberMask)
                {
                    CurrentProjectSettings.MillPipeNumberMask = value;
                    CurrentProjectSettings.MillPipeNumberMaskRegexp = Project.FormRegExp(CurrentProjectSettings.MillPipeNumberMask);
                    RaisePropertiesChanged("MillPipeNumberMask");
                }
            }

        }

        public string ProjectTitle
        {
            get { return CurrentProjectSettings.Title; }
            set
            {
                if(CurrentProjectSettings.Title != value)
                {
                    CurrentProjectSettings.Title = value;
                    RaisePropertiesChanged("ProjectTitle");
                }
            }
        }

        #endregion

        #region Plate Manufacturers
        public BindingList<PlateManufacturer> PlateManufacturers
        {
            get
            {
                return plateManufacturers;
            }
            set
            {
                if(value != plateManufacturers)
                {
                    plateManufacturers = value;
                    RaisePropertyChanged("PlateManufacturers");
                }
            }
        }
        #endregion

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand ExtractCategoriesCommand
        {
            get { return extractCategoriesCommand; }
        }

        private void GetAllPipeMillSizeType()
        {
            var allSizeType = repos.PipeSizeTypeRepo.GetAll().ToList();
            if(allSizeType == null || allSizeType.Count <= 0)
                log.Warn("Setup settings: List of Size Type is NULL or empty");

            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
            PipeMillSizeType.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllJointOperations()
        {
            var foundOperations = repos.JointRepo.GetAll().ToList();
            if(foundOperations == null || foundOperations.Count <= 0)
                log.Warn("Setup settings:List of found Operations is NULL or empty");

            JointOperations = new BindingList<JointOperation>(foundOperations);
            JointOperations.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllWelders()
        {
            if(Welders == null)
                Welders = new BindingList<WelderViewType>();

            var foundWelders = repos.WelderRepo.GetAll();
            if(foundWelders != null)
            {
                foreach(Welder w in foundWelders)
                {
                    Welders.Add(new WelderViewType(w));
                }
            }
            else
            {
                log.Warn(" Setup settings: List of found Welders is NULL.");
            }

            Welders.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllCertificateTypes()
        {
            if(CertificateTypes == null)
                CertificateTypes = new BindingList<InspectorCertificateType>();

            var foundCertificateTypes = repos.CertificateTypeRepo.GetAll();
            if(foundCertificateTypes != null)
            {
                foreach(var t in foundCertificateTypes)
                {
                    CertificateTypes.Add(t);
                }
            }
            else
            {
                log.Warn("Setup settings:List of Certificate Types is NULL.");
            }

            CertificateTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllSeamTypes()
        {
            if(SeamTypes == null)
                SeamTypes = new BindingList<SeamType>();

            var foundSeamTypes = repos.SeamTypeRepo.GetAll();
            if(foundSeamTypes != null)
            {
                foreach(var s in foundSeamTypes)
                {
                    SeamTypes.Add(s);
                }
            }
            else
            {
                log.Warn("Setup settings: List of Seam Types is NULL.");
            }

            SeamTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllInspectors()
        {
            if(Inspectors == null)
                Inspectors = new BindingList<InspectorViewType>();

            var foundInspectors = repos.InspectorRepo.GetAll();
            if(foundInspectors != null)
            {
                foreach(Inspector i in foundInspectors)
                {
                    Inspectors.Add(new InspectorViewType(i));
                }
            }
            else
            {
                log.Warn("Setup settings: List of Inspectors is NULL.");
            }

            foreach(var insp in this.Inspectors)
            {
                // Due to incomplete the collection type matching returned at reading from the database and properties binding  
                // the following solution have been proposed. Perhaps this problem can be solved by entities mapping.
                if(insp.Certificates.Count == 0)
                {
                    insp.Certificates = new List<InspectorCertificate>();
                }
            }

            Inspectors.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        public void NewPipeMillSizeType()
        {
            if(PipeMillSizeType == null)
            {
                PipeMillSizeType = new BindingList<PipeMillSizeType>();
            }
        }

        private void GetProjectSettings()
        {

            CurrentProjectSettings = repos.ProjectRepo.GetSingle();
        }

        private void GetAllManufacturers()
        {
            var foundPlateManufacturers = repos.PlateManufacturerRepo.GetAll().ToList();

            if(foundPlateManufacturers == null || foundPlateManufacturers.Count <= 0)
                log.Warn("Setup settings: List of Plate Manufacturers is NULL or empty");

            PlateManufacturers = new BindingList<PlateManufacturer>(foundPlateManufacturers);
            PlateManufacturers.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllComponentryTypes()
        {
            if(ComponentryTypes == null)
                ComponentryTypes = new BindingList<ComponentType>();

            var foundComponentryTypes = repos.ComponentTypeRepo.GetAll();
            if(foundComponentryTypes != null)
            {
                foreach(ComponentType t in foundComponentryTypes)
                {
                    ComponentryTypes.Add(t);
                }
            }
            else
            {
                log.Warn("Setup settings: List of Componentry Types is NULL.");
            }
            ComponentryTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        public void AddNewManufacturer(string newManufacturerName)
        {
            var existingItem = from p in plateManufacturers where p.Name == newManufacturerName select p;
            if(!existingItem.Any())
            {
                PlateManufacturer newManufacturer = new PlateManufacturer { IsActive = true, Name = newManufacturerName, IsNative = true, Project = CurrentProjectSettings };
                plateManufacturers.Add(newManufacturer);
            }
        }

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
        }

        internal void UpdatePipeTests(object sizeType)
        {
            PipeMillSizeType type = sizeType as PipeMillSizeType;
            PipeTests.Clear();
            if(type.PipeTests == null)
                return;
            foreach(PipeTest t in type.PipeTests)
            {
                PipeTests.Add(t);
            }
        }

        public IModifiable ModifiableView
        {
            get
            {
                return modifiable;
            }
            set
            {
                modifiable = value;
            }
        }

        public bool RoleHasPermission(Role role, Permission perm)
        {
            return (from p in role.Permissions where p.Id == perm.Id select p).Count() > 0;
        }

        public void RemovePermissionFromRole(Role role, Permission p)
        {
            var rolePerm = role.Permissions.Where(_ => _.Id == p.Id).FirstOrDefault();
            if(rolePerm != null)
            {
                role.Permissions.Remove(rolePerm);
                ModifiableView.IsModified = true;
            }

        }

        public void AddPermissionToRole(Role role, Permission p)
        {
            var rolePerm = role.Permissions.Where(_ => _.Id == p.Id).FirstOrDefault();
            if(rolePerm == null)
            {
                role.Permissions.Add(p);
                ModifiableView.IsModified = true;
            }
        }

        public void AddRoleToUser(Role role, User user)
        {
            var userRole = user.Roles.Where(_ => _.Id == role.Id).FirstOrDefault();
            if(userRole == null)
            {
                user.Roles.Add(role);
                ModifiableView.IsModified = true;
            }
        }

        public void RemoveRoleFromUser(Role role, User user)
        {
            var userRole = user.Roles.Where(_ => _.Id == role.Id).FirstOrDefault();
            if(userRole != null)
            {
                user.Roles.Remove(userRole);
                ModifiableView.IsModified = true;
            }
        }

        internal bool UserHasRole(User user, Role role)
        {
            return (from r in user.Roles where r.Id == role.Id select r).Count() > 0;
        }

        private void LoadJointOperationTypes()
        {
            JointOperationTypes = new List<EnumWrapper<JointOperationType>>();

            foreach(var item in EnumWrapper<JointOperationType>.EnumerateItems(skip0: true))
            {
                JointOperationTypes.Add(new EnumWrapper<JointOperationType>((JointOperationType)item.Item1)); // TODO: binding list vs localization - ?
            }
        }

        public PipeMillSizeType CurrentPipeMillSizeType
        {
            get
            {
                return currentPipeMillSizeType;
            }
            set
            {
                if(value != currentPipeMillSizeType)
                {
                    currentPipeMillSizeType = value;
                    RaisePropertyChanged("CurrentPipeMillSizeType");
                    RaisePropertyChanged("Length");
                    RaisePropertyChanged("Diameter");
                    RaisePropertyChanged("Thickness");
                    RaisePropertyChanged("SeamType");
                }
            }
        }

        public int Length
        {
            get
            {
                if(CurrentPipeMillSizeType != null) { return CurrentPipeMillSizeType.Length; } else { return 0; }

            }
            set
            {
                if(value != CurrentPipeMillSizeType.Length)
                {
                    CurrentPipeMillSizeType.Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }

        public float Diameter
        {
            get
            {
                if(CurrentPipeMillSizeType != null) { return CurrentPipeMillSizeType.Diameter; } else { return 0; }
            }
            set
            {
                if(value != CurrentPipeMillSizeType.Diameter)
                {
                    CurrentPipeMillSizeType.Diameter = value;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public float Thickness
        {
            get
            {
                if(CurrentPipeMillSizeType != null)
                {
                    return CurrentPipeMillSizeType.Thickness;
                }
                else { return 0; }
            }
            set
            {
                if(value != CurrentPipeMillSizeType.Thickness)
                {
                    CurrentPipeMillSizeType.Thickness = value;
                    RaisePropertyChanged("Thickness");
                }
            }
        }

        public SeamType SeamType
        {
            get
            {
                if(CurrentPipeMillSizeType != null)
                {
                    if(CurrentPipeMillSizeType != null || CurrentPipeMillSizeType.SeamType != null)
                    {
                        return CurrentPipeMillSizeType.SeamType;
                    }
                    else
                    {
                        return new SeamType() { IsNative = true, Project = CurrentProjectSettings };
                    }
                }
                else { return new SeamType() { IsNative = true, Project = CurrentProjectSettings }; }
            }
            set
            {
                if(value != CurrentPipeMillSizeType.SeamType)
                {
                    CurrentPipeMillSizeType.SeamType = value;
                    RaisePropertyChanged("SeamType");
                }
            }
        }

        public bool IsMaster
        {
            get { return (Program.ThisWorkstationType == WorkstationType.Master) ? true : false; }
        }

        public bool IsMill
        {
            get { return (Program.ThisWorkstationType == WorkstationType.Mill) ? true : false; }
        }

        public bool IsConstruction
        {
            get { return (Program.ThisWorkstationType == WorkstationType.Construction) ? true : false; }
        }
    }
}
