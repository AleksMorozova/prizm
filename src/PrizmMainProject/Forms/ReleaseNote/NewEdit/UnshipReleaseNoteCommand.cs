using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    public class UnshipReleaseNoteCommand : ICommand
    {
        private readonly IReleaseNoteRepositories repos;
        private readonly ReleaseNoteViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public UnshipReleaseNoteCommand(ReleaseNoteViewModel viewModel, IReleaseNoteRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.Shipped)
            {
                notify.ShowError(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_NotShipped),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
            }
            else
            {
                foreach(SimpleRailcar r in viewModel.Railcars) 
                {
                    r.IsShipped = false;
                    foreach(var pipe in r.Pipes)
                    {
                    pipe.Status = PipeMillStatus.ReadyToShip;
                    pipe.ToExport = false;
                    }
                }
               
                viewModel.Shipped = false;
                notify.ShowSuccess(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_Unshipped),
                    Program.LanguageManager.GetString(StringResources.Alert_InfoHeader));

                viewModel.SaveCommand.Execute();
            }
            RefreshVisualStateEvent();
        }
        public bool CanExecute()
        {
            return (viewModel.Shipped && ctx.HasAccess(global::Domain.Entity.Security.Privileges.UnshipAtMill));
        }
    }
}
