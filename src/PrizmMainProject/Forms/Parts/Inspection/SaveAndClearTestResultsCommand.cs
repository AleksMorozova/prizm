using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Parts.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class SaveAndClearTestResultsCommand: ICommand 
    {
        private readonly PartInspectionViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveAndClearTestResultsCommand(PartInspectionViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.SaveInspectionTestResultsCommand.Execute();
            viewModel.InspectionTestResults = null;
            viewModel.SelectedElement = null;
            viewModel.ModifiableView.IsEditMode = false;
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return viewModel.SaveInspectionTestResultsCommand.CanExecute();
        }
    }
}
