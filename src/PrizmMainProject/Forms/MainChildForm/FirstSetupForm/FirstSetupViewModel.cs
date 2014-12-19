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

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupViewModel : ViewModelBase, IDisposable
    {
        FirstSetupSaveCommand saveCommand;
        public bool IsSaved = false;

        [Inject]
        public FirstSetupViewModel()
        {
            saveCommand = ViewModelSource.Create(() => new FirstSetupSaveCommand(this));

            var mill = new EnumWrapper<WorkstationType> { Value = WorkstationType.Mill };
            var construction = new EnumWrapper<WorkstationType> { Value = WorkstationType.Construction };
            var master = new EnumWrapper<WorkstationType> { Value = WorkstationType.Master };
            Types.Add(mill);
            Types.Add(construction);
            Types.Add(master);

            var defaultStation = (WorkstationType)Enum.Parse(typeof(WorkstationType), ConfigurationManager.AppSettings["WorkstationType"]);
            var defaultProjName = ConfigurationManager.AppSettings["ProjectName"];

            if(defaultStation == WorkstationType.Undef)
            {
                defaultStation = WorkstationType.Mill;
            }
            project.WorkstationType = defaultStation;
            project.Title = defaultProjName;
            project.DocumentSizeLimit = 1024;
        }

        public BindingList<EnumWrapper<WorkstationType>> Types = new BindingList<EnumWrapper<WorkstationType>>();

        private Project project = new Project();
        private User admin = new User() { Undeletable = true };
        private PersonName name = new PersonName();

        #region BindingFields

        //Project
        public string ProjectTitle
        {
            get { return project.Title; }
            set
            {
                if(value != project.Title)
                {
                    project.Title = value;
                    RaisePropertyChanged("ProjectTitle");
                }
            }
        }

        public WorkstationType Type
        {
            get { return project.WorkstationType; }
            set
            {
                if(value != project.WorkstationType)
                {
                    project.WorkstationType = value;
                    RaisePropertyChanged("Type");
                }
            }
        }

        public int Size
        {
            get { return project.DocumentSizeLimit; }
            set
            {
                if(value != project.DocumentSizeLimit)
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
                if(value != project.MillName)
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
                if(value != project.MillPipeNumberMask)
                {
                    project.MillPipeNumberMask = value;
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
                if(value != admin.Login)
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
                if(value != password)
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
                if(value != name.LastName)
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
                if(value != name.FirstName)
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
                if(value != name.MiddleName)
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
                if(value != project)
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
                if(value != admin)
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
                if(value != name)
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
        }

        #endregion
    }
}
