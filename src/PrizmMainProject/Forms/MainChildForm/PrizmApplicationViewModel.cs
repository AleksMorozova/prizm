using Data.DAL;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Domain.Entity;

using Domain.Entity.Setup;
using PrizmMain.Common;
using PrizmMain.Forms.MainChildForm.FirstSetupForm;

namespace PrizmMain.Forms.MainChildForm
{
    public class PrizmApplicationViewModel : ViewModelBase, IDisposable
    {
        private EnumWrapper<WorkstationType> workstationName;
        readonly IProjectRepository repo;
        public Project ProjectSettings;

        [Inject]
        public PrizmApplicationViewModel(IProjectRepository repo)
        {
            this.repo = repo;
        }

        public void GetOrCreateProject()
        {
            //if (repo.GetSingle() == null)
            if(true)
            {
                using(var setupDialog = (FirstSetupXtraForm)Program.Kernel.Get(typeof(FirstSetupXtraForm)))
                {
                    do
                    {
                        setupDialog.ShowDialog();
                    } while(setupDialog.DialogResult != System.Windows.Forms.DialogResult.OK);
                }
            }
            //    ProjectSettings = new Project()
            //    {
            //        Client = string.Empty,
            //        MillName = string.Empty,
            //        WorkstationType = Domain.Entity.Setup.WorkstationType.Mill,
            //        MillPipeNumberMask = string.Empty,
            //        IsActive = true
            //    };
            //    repo.BeginTransaction();
            //    repo.Save(ProjectSettings);
            //    repo.Commit();
            //    repo.Evict(ProjectSettings);
            //}
            //ProjectSettings = repo.GetSingle();
        }


        public EnumWrapper<WorkstationType> WorkstationType
        {
            get
            {
                return
                   workstationName ??
                    new EnumWrapper<WorkstationType>() { Value = ProjectSettings.WorkstationType };
            }
            set
            {
                workstationName = value;
            }
        }


        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
