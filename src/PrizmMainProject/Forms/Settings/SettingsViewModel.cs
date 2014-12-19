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

namespace Prizm.Main.Forms.Settings
{
    public class SettingsViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        public IList<PipeMillSizeType> PipeMillSizeType { get; set; }
        public Project CurrentProjectSettings { get; set; }
        public BindingList<WelderViewType> Welders { get; set; }
        public BindingList<InspectorViewType> Inspectors { get; set; }
        public BindingList<PipeTestControlTypeWrapper> ControlType { get; set; }
        public BindingList<PipeTestResultTypeWrapper> ResultType { get; set; }
        public BindingList<Role> Roles { get; set; }
        public BindingList<Permission> Permissions { get; set; }
        public BindingList<User> Users { get; set; }
        public BindingList<InspectorCertificateType> CertificateTypes { get; set; }
        public IList<JointOperation> JointOperations { get; set; }
        public IList<EnumWrapper<JointOperationType>> JointOperationTypes;

        readonly SaveSettingsCommand saveCommand;
        readonly ExtractCategoriesCommand extractCategoriesCommand;

        readonly ISettingsRepositories repos;
        readonly IUserNotify notify;
        private IList<PlateManufacturer> plateManufacturers;
        private IModifiable modifiable;


        [Inject]
        public SettingsViewModel(ISettingsRepositories repos, IUserNotify notify)
        {
            NewPipeMillSizeType();  
            this.repos = repos;
            this.notify = notify;

            saveCommand = ViewModelSource
                .Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repos, notify));

            extractCategoriesCommand = ViewModelSource
                .Create<ExtractCategoriesCommand>(() => new ExtractCategoriesCommand(this, repos, notify));

            this.ExtractCategoriesCommand.Execute();
        }

        public void LoadData()
        {
           GetAllCertificateTypes();
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
           ControlType = new BindingList<PipeTestControlTypeWrapper>();
           ResultType = new BindingList<PipeTestResultTypeWrapper>();

           foreach (string controlTypeName in Enum.GetNames(typeof(PipeTestControlType)))
           {
               if (controlTypeName != Enum.GetName(typeof(PipeTestControlType), PipeTestControlType.Undef))
               ControlType.Add(new PipeTestControlTypeWrapper()
               {
                   Value = (PipeTestControlType)Enum.Parse(typeof(PipeTestControlType), controlTypeName),
                   Text = Resources.ResourceManager.GetString("InspectionControlType_" + controlTypeName)
               }
               );
           }

           foreach (string resultTypeName in Enum.GetNames(typeof(PipeTestResultType)))
           {
               if (resultTypeName != Enum.GetName(typeof(PipeTestResultType), PipeTestResultType.Undef))
               ResultType.Add(new PipeTestResultTypeWrapper()
               {
                   Value = (PipeTestResultType)Enum.Parse(typeof(PipeTestResultType), resultTypeName),
                   Text = Resources.ResourceManager.GetString("InspectionResultType_" + resultTypeName)
               }
               );
           }
        }

        private void GetAllUsers()
        {
           if (Users == null)
              Users = new BindingList<User>();

           IList<User> users = repos.UserRepo.GetAll();
           foreach (var u in users)
           {
              Users.Add(u);
           }
        }

        private void GetAllPermissions()
        {
           if (Permissions == null)
              Permissions = new BindingList<Permission>();

           IList<Permission> perms = repos.PermissionRepo.GetAll();
           foreach (var p in perms)
           {
              Permissions.Add(p);
           }
        }

        private void GetAllRoles()
        {
           if (Roles == null)
              Roles = new BindingList<Role>();

           IList<Role> roles = repos.RoleRepo.GetAll();
           foreach (var r in roles)
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
                if (value != pipeTests)
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
                if (value != CurrentProjectSettings.Client)
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
                if (value != CurrentProjectSettings.MillName)
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
                if (value != CurrentProjectSettings.DocumentSizeLimit)
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
                if (value != CurrentProjectSettings.MillPipeNumberMask)
                {
                    CurrentProjectSettings.MillPipeNumberMask = value;
                    StringBuilder mask = new StringBuilder();
                    foreach (char ch in CurrentProjectSettings.MillPipeNumberMask)
                    {
                        string convertedToRegex = "";
                        switch (ch)
                        { 
                            case '#': convertedToRegex = @"\d";break;
                            case '@': convertedToRegex = @"\p{Lu}"; break;
                            case '%': convertedToRegex = @"(\d|\p{Lu})"; break;
                            case '&': convertedToRegex = @"\w"; break;
                            default: convertedToRegex = ch.ToString(); break;

                        }
                        mask.Append(convertedToRegex);
                    }
                    CurrentProjectSettings.MillPipeNumberMaskRegexp = mask.ToString();
                    RaisePropertiesChanged("MillPipeNumberMask");
                }
            }

        }

        #endregion

        #region Plate Manufacturers
        public IList<PlateManufacturer> PlateManufacturers
        {
            get 
            {
                return plateManufacturers;
            }
            set 
            {
                if (value != plateManufacturers)
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
            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
        }

        void GetAllJointOperations()
        {
            var foundOperations = repos.JointRepo.GetAll().ToList();
            JointOperations = new BindingList<JointOperation>(foundOperations);
        }

        void GetAllWelders()
        {
           if (Welders == null)
              Welders = new BindingList<WelderViewType>();

           var foundWelders = repos.WelderRepo.GetAll();
           if (foundWelders != null)
           {
              foreach (Welder w in foundWelders)
              {
                 Welders.Add(new WelderViewType(w));
              }
           }

           Welders.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }


        void GetAllCertificateTypes()
        {
            if (CertificateTypes == null)
                CertificateTypes = new BindingList<InspectorCertificateType>();

            var foundCertificateTypes = repos.CertificateTypeRepo.GetAll();
            if (foundCertificateTypes != null)
            {
                foreach (var t in foundCertificateTypes)
                {
                    CertificateTypes.Add(t);
                }
            }

            CertificateTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllInspectors()
        {
           if (Inspectors == null)
              Inspectors = new BindingList<InspectorViewType>();

           var foundInspectors = repos.InspectorRepo.GetAll();
           if (foundInspectors != null)
           {
              foreach (Inspector i in foundInspectors)
              {
                 Inspectors.Add(new InspectorViewType(i));
              }
           }

           Inspectors.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        public void NewPipeMillSizeType()
        {
            if (PipeMillSizeType == null)
            {
                PipeMillSizeType = new List<PipeMillSizeType>();
            }
        }

        private void GetProjectSettings()
        {

            CurrentProjectSettings = repos.ProjectRepo.GetSingle();
        }

        private void GetAllManufacturers()
        {
           var  foundPlateManufacturers = repos.PlateManufacturerRepo.GetAll().ToList();
           PlateManufacturers = new BindingList<PlateManufacturer>(foundPlateManufacturers);
        }

        void GetAllComponentryTypes()
        {
            if (ComponentryTypes == null)
                ComponentryTypes = new BindingList<ComponentType>();

            var foundComponentryTypes = repos.ComponentTypeRepo.GetAll();
            if (foundComponentryTypes != null)
            {
                foreach (ComponentType t in foundComponentryTypes)
                {
                    ComponentryTypes.Add(t);
                }
            }
            ComponentryTypes.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        public void AddNewManufacturer(string newManufacturerName)
        {
           var existingItem = from p in plateManufacturers where p.Name == newManufacturerName select p;
            if (!existingItem.Any())
            {
                PlateManufacturer newManufacturer = new PlateManufacturer { IsActive = true, Name = newManufacturerName };
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
            if (type.PipeTests == null)
                return;
            foreach (PipeTest t in type.PipeTests)
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
           if (rolePerm != null)
           {
              role.Permissions.Remove(rolePerm);
              ModifiableView.IsModified = true;
           }

        }

        public void AddPermissionToRole(Role role, Permission p)
        {
           var rolePerm = role.Permissions.Where(_ => _.Id == p.Id).FirstOrDefault();
           if (rolePerm == null)
           {
              role.Permissions.Add(p);
              ModifiableView.IsModified = true;
           }
        }

        public void AddRoleToUser(Role role, User user)
        {
           var userRole = user.Roles.Where(_ => _.Id == role.Id).FirstOrDefault();
           if (userRole == null)
           {
              user.Roles.Add(role);
              ModifiableView.IsModified = true;
           }
        }

        public void RemoveRoleFromUser(Role role, User user)
        {
           var userRole = user.Roles.Where(_ => _.Id == role.Id).FirstOrDefault();
           if (userRole != null)
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

            foreach (string jointOperationTypeName in Enum.GetNames(typeof(JointOperationType)))
            {
                if (jointOperationTypeName != Enum.GetName(typeof(JointOperationType), JointOperationType.Undefined))
                {
                    JointOperationTypes.Add(new EnumWrapper<JointOperationType>() { Name = jointOperationTypeName });
                }
            }
        }
    }
}
