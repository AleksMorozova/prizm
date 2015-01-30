using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NHibernate;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class PartInspectionViewModel : ViewModelBase, IDisposable
    {
        SearchPartForInspectionCommand searchCommand;
        SaveInspectionTestResultsCommand saveInspectionTestResultsCommand;
        SaveAndClearTestResultsCommand saveAndClearTestResultsCommand;
        ISecurityContext ctx;
        ISession session;
        private readonly IPartInspectionRepository repos;
        private string searchNumber = string.Empty;
        private BindingList<Main.Forms.Parts.Search.Part> parts = new BindingList<Main.Forms.Parts.Search.Part>();
        private Main.Forms.Parts.Search.Part selectedElement;
        private Domain.Entity.Part convertedPart;
        private BindingList<InspectionTestResult> inspectionTestResults;
        public IList<Inspector> Inspectors { get; set; }
        private readonly IUserNotify notify;
        private IModifiable modifiableView;

        [Inject]
        public PartInspectionViewModel(ISession session, IPartInspectionRepository repos, IUserNotify notify, ISecurityContext ctx)
        {
            this.session = session;
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;
            this.Inspectors = repos.RepoInspector.GetAll();
            searchCommand = ViewModelSource.Create(() => new SearchPartForInspectionCommand(this, session, ctx));
            saveInspectionTestResultsCommand = ViewModelSource.Create(() => new SaveInspectionTestResultsCommand(repos.RepoInspectionTestResult, this, notify, ctx));
            saveAndClearTestResultsCommand = ViewModelSource.Create(() => new SaveAndClearTestResultsCommand(this));
            this.Inspectors = repos.RepoInspector.GetAll();
        }


        public string SearchNumber
        {
            get { return searchNumber; }
            set
            {
                if (value != searchNumber)
                {
                    searchNumber = value;
                    RaisePropertyChanged("SearchNumber");
                }
            }
        }

        public BindingList<Main.Forms.Parts.Search.Part> Parts
        {
            get { return parts; }
            set
            {
                if (parts != value)
                {
                    parts = value;
                    RaisePropertyChanged("Parts");
                }
            }
        }

        public string ElementNumber
        {
            get { return (selectedElement != null)? selectedElement.Number : string.Empty; }
        }

        public PartType ElementType
        {
            get { return (selectedElement != null) ? selectedElement.Type.Value : PartType.Undefined; }
        }

        public Main.Forms.Parts.Search.Part SelectedElement
        {
            get { return selectedElement; }
            set
            {
                if (selectedElement != value)
                {
                    selectedElement = value;
                    if (selectedElement != null)
                    {
                        modifiableView.IsEditMode = true;
                        switch (selectedElement.Type.Value)
                        {
                            case PartType.Pipe: convertedPart = (Domain.Entity.Part)repos.RepoPipe.Get(selectedElement.Id);
                                break;
                            case PartType.Spool: convertedPart = (Domain.Entity.Part)repos.RepoSpool.Get(selectedElement.Id);
                                break;
                            case PartType.Component: convertedPart = (Domain.Entity.Part)repos.RepoComponent.Get(selectedElement.Id);
                                break;
                            default: notify.ShowError(Resources.DLG_ERROR_HEADER, Resources.IDS_ERROR + Resources.ERROR_UnknownComponentType);
                                break;
                        }
                        var results = repos.RepoInspectionTestResult.GetByPartId(selectedElement.Id);
                        if (results != null )
                        {
                            InspectionTestResults = new BindingList<InspectionTestResult>(results);
                            convertedPart.InspectionTestResults = InspectionTestResults;
                        }
                    }
                    RaisePropertyChanged("SelectedElement");
                }
            }
        }

        public Domain.Entity.Part ConvertedPart
        {
            get { return convertedPart; }
        }

        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get { return inspectionTestResults; }
            set
            {
                if (inspectionTestResults != value)
                {
                    inspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        public void Dispose()
        {
            session.Dispose();
            repos.Dispose();
        }

        public Documents.IModifiable ModifiableView
        {
            get
            {
                return modifiableView;
            }
            set
            {
                modifiableView = value;
            }
        }

        #region Commands
        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public ICommand SaveInspectionTestResultsCommand
        {
            get { return saveInspectionTestResultsCommand; }
        }

        public ICommand SaveAndClearTestResultsCommand
        {
            get { return saveAndClearTestResultsCommand; }
        }
        #endregion

       /// <summary>
       /// Is used in SearchPartInspectionCommand to get MDIParent 
       /// </summary>
        public PartInspectionXtraForm CurrentForm { get; set; }
    }
}
