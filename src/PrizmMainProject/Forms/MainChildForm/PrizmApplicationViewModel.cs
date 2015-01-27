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
using System.Globalization;
using Prizm.Main.Properties;
using System.Resources;

using DevExpress.XtraBars;

namespace Prizm.Main.Forms.MainChildForm
{
    public class PrizmApplicationViewModel : ViewModelBase, IDisposable
    {
        private EnumWrapper<WorkstationType> workstationName;
        private readonly IUserNotify notify;
        private readonly IProjectRepository repo;

        public Project ProjectSettings;

        [Inject]
        public PrizmApplicationViewModel(IProjectRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.ProjectSettings = repo.GetSingle();
            this.notify = notify;
        }

        public EnumWrapper<WorkstationType> WorkstationType
        {
            get
            {
                return
                   workstationName ??
                    new EnumWrapper<WorkstationType>(ProjectSettings.WorkstationType);
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
