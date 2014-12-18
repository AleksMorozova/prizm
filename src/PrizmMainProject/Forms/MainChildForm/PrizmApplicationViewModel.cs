using Prizm.Data.DAL;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Prizm.Domain.Entity;

using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;

namespace Prizm.Main.Forms.MainChildForm
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
