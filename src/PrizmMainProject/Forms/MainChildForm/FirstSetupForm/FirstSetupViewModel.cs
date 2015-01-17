using Prizm.Data.DAL;
using Prizm.Data.DAL.Security;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Security;
using Prizm.Domain.Entity.Setup;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupViewModel : ViewModelBase
    {
        private IList<InspectorCertificateType> inspectorCertificateTypes;
        private string[] inspectorCertificateTypesName
            = new[] { "НАКС (Welding Engineer)", "ВИК (VT)", "РК (RT)", "УК (UT)", "МК (MT)", "Покрытия (Coating)" };

        private IList<SeamType> seamTypes;
        private string[] seamTypesName
           = new[] { "Прямой", "Спиральный", "Без шва" };

        private IList<Category> fixedCategoryes;
        private string[] fixedCategoryesName
           = new[] { "Измерение длины" };

        private readonly IFirstSetupRepo firstSetupRepo;
        public Role SuperUser = new Role() { Name = Resources.Administrator, Description = Resources.Administrator };
        FirstSetupSaveCommand saveCommand;
        public bool IsSaved = false;

        [Inject]
        public FirstSetupViewModel(IFirstSetupRepo firstSetupRepo)
        {
            this.firstSetupRepo = firstSetupRepo;
            saveCommand = ViewModelSource.Create(() => new FirstSetupSaveCommand(this, firstSetupRepo));

            var defaultStation = (WorkstationType)Enum.Parse(typeof(WorkstationType), ConfigurationManager.AppSettings["WorkstationType"]);

            var defaultProjName = ConfigurationManager.AppSettings["ProjectName"];

            if (defaultStation == WorkstationType.Undef)
            {
                defaultStation = WorkstationType.Mill;
            }
            project.WorkstationType = defaultStation;
            project.Title = defaultProjName;
            project.DocumentSizeLimit = 1024;
           
            foreach (Permission permission in firstSetupRepo.PermissionRepo.GetAll())
            {
                SuperUser.Permissions.Add(permission);
            }
            admin.Roles = new List<Role>() { SuperUser };            
        }

        private Project project = new Project() { IsNative = true};
        private User admin = new User() { Undeletable = true };
        private PersonName name = new PersonName();

        public IList<InspectorCertificateType> InspectorCertificateTypes
        {
            get
            {
                if (inspectorCertificateTypes == null)
                {
                    inspectorCertificateTypes = new List<InspectorCertificateType>();
                    foreach (string str in inspectorCertificateTypesName)
                    {
                        inspectorCertificateTypes.Add(new InspectorCertificateType() { Name = str, IsActive = true });
                    }
                }
                return inspectorCertificateTypes;
            }
        }

        public IList<SeamType> SeamTypes
        {
            get
            {
                if (seamTypes == null)
                {
                    seamTypes = new List<SeamType>();
                    foreach (string str in seamTypesName)
                    {
                        seamTypes.Add(new SeamType() { Name = str, IsActive = true });
                    }
                }
                return seamTypes;
            }
        }

        public IList<Category> FixedCategoryes
        {
            get
            {
                if (fixedCategoryes == null)
                {
                    fixedCategoryes = new List<Category>();
                    foreach (string str in fixedCategoryesName)
                    {
                        fixedCategoryes.Add(new Category() { Name = str, IsActive = true , Fixed=true, ResultType="int"}); 
                    }
                }
                return fixedCategoryes;
            }
        }

        #region BindingFields

        //Project
        public string ProjectTitle
        {
            get { return project.Title; }
            set
            {
                if (value != project.Title)
                {
                    project.Title = value;
                    RaisePropertyChanged("ProjectTitle");
                }
            }
        }

        public string Type
        {
            get { return (new EnumWrapper<WorkstationType>() { Value = project.WorkstationType }).Text; }
        }

        public int Size
        {
            get { return project.DocumentSizeLimit; }
            set
            {
                if (value != project.DocumentSizeLimit)
                {
                    project.DocumentSizeLimit = value;
                    RaisePropertyChanged("Size");
                }
            }
        }

        public string MillName
        {
            get { return project.MillName; }
            set
            {
                if (value != project.MillName)
                {
                    project.MillName = value;
                    RaisePropertyChanged("MillName");
                }
            }
        }

        public string MillPipeNumberMask
        {
            get { return project.MillPipeNumberMask; }
            set
            {
                if (value != project.MillPipeNumberMask)
                {
                    project.MillPipeNumberMask = value;
                    project.MillPipeNumberMaskRegexp = Project.FormRegExp(project.MillPipeNumberMask);
                    RaisePropertyChanged("MillPipeNumberMask");
                }
            }
        }

        //Administrator
        public string Login
        {
            get { return admin.Login; }
            set
            {
                if (value != admin.Login)
                {
                    admin.Login = value;
                    RaisePropertyChanged("Login");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value != password)
                {
                    password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }

        public string LastName
        {
            get { return name.LastName; }
            set
            {
                if (value != name.LastName)
                {
                    name.LastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }

        public string FirstName
        {
            get { return name.FirstName; }
            set
            {
                if (value != name.FirstName)
                {
                    name.FirstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }

        public string MiddleName
        {
            get { return name.MiddleName; }
            set
            {
                if (value != name.MiddleName)
                {
                    name.MiddleName = value;
                    RaisePropertyChanged("MiddleName");
                }
            }
        }

        #endregion

        #region CommandFields

        public Project Project
        {
            get { return project; }
            set
            {
                if (value != project)
                {
                    project = value;
                }
            }
        }

        public User Admin
        {
            get { return admin; }
            set
            {
                if (value != admin)
                {
                    admin = value;
                }
            }
        }

        public PersonName Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                }
            }
        }
        #endregion

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            firstSetupRepo.Dispose();
        }

        #endregion
    }
}
