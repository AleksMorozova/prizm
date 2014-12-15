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
            this.ProjectSettings = repo.GetSingle();
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
