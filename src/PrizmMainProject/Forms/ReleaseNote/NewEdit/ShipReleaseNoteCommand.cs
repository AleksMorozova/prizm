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
using Prizm.Main.Languages;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    public class ShipReleaseNoteCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ShipReleaseNoteCommand));

        private readonly IReleaseNoteRepositories repos;
        private readonly ReleaseNoteViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public ShipReleaseNoteCommand(ReleaseNoteViewModel viewModel, IReleaseNoteRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            bool noPipe = false;
            bool difTypeSize = false;

            var distinctSizeDict = new Dictionary<Railcar, IEnumerable<Prizm.Domain.Entity.Setup.PipeMillSizeType>>();

            foreach(Prizm.Domain.Entity.Mill.Railcar r in viewModel.ReleaseNote.Railcars)
            {
                if(r.Pipes.Count == 0)
                {
                    noPipe = true;
                }
            }

            if(noPipe)
            {
                notify.ShowError(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_PipesAbsent),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                return;
            }

            foreach(Prizm.Domain.Entity.Mill.Railcar r in viewModel.ReleaseNote.Railcars)
            {
                var distinctTypes = r.Pipes.Select(p => p.Type).Distinct();

                if(distinctTypes.Count() > 1)
                {
                    difTypeSize = true;
                    distinctSizeDict.Add(r, distinctTypes);
                }
            }

            if(difTypeSize)
            {
                StringBuilder messageBuilder = new StringBuilder();

                messageBuilder.AppendLine(Program.LanguageManager.GetString(
                    StringResources.ReleaseNoteNewEdit_DifferentTypeSizeInRailcar));

                string distintTypesMessage = Program.LanguageManager.GetString(
                        StringResources.ReleaseNoteNewEdit_DifferentTypeSizeInRailcarExtended);
                foreach (var item in distinctSizeDict)
                {
                    messageBuilder.AppendLine(
                        String.Format("{0} {1}:", distintTypesMessage, item.Key.Number));

                    foreach (var pipes in item.Value)
                        messageBuilder.AppendLine(String.Format("\t{0}", pipes.Type));
                }

                notify.ShowError(messageBuilder.ToString(),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
            }


            if(!noPipe && !difTypeSize)
            {
                foreach(Prizm.Domain.Entity.Mill.Railcar r in viewModel.Railcars)
                {
                    r.IsShipped = true;
                    foreach(var pipe in r.Pipes)
                    {
                        pipe.Status = PipeMillStatus.Shipped;

                        pipe.ToExport = true;
                    }
                }
                viewModel.Shipped = true;
                notify.ShowSuccess(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_Shipped) + " #" + viewModel.ReleaseNote.Number,
                    Program.LanguageManager.GetString(StringResources.Alert_InfoHeader));

                log.Info(string.Format("Shipment is successful. Release Note #{0}, id:{1}.",
                    viewModel.ReleaseNote.Number,
                    viewModel.ReleaseNote.Id));

                viewModel.SaveCommand.Execute();
            }

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return !viewModel.Shipped
                && !string.IsNullOrWhiteSpace(viewModel.Number) 
                && viewModel.ReleaseNotePipes.Count > 0
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);
        }
    }
}
