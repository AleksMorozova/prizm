using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NHibernate;
using Ninject;
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
    public class PartInspectionViewModel : ViewModelBase, IDisposable
    {
        SearchPartForInspectionCommand searchCommand;
        ISession session;
        private readonly IInspectionTestResultRepository repo;
        private string searchNumber = string.Empty;
        private BindingList<Part> parts = new BindingList<Part>();
        private Part selectedElement;
        private BindingList<InspectionTestResult> inspectionTestResults;

        [Inject]
        public PartInspectionViewModel(ISession session, IInspectionTestResultRepository repo)
        {
            this.session = session;
            this.repo = repo;
            searchCommand = ViewModelSource.Create(() => new SearchPartForInspectionCommand(this, session));
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
    
        public BindingList<Part> Parts
        {
            get { return parts; }
            set
            {
                if (value != parts)
                {
                    parts = value;
                    RaisePropertyChanged("Parts");
                }
            }
        }

        public Part SelectedElement
        {
            get { return selectedElement; }
            set
            {
                if (value != selectedElement)
                {
                    selectedElement = value;

                    var results = repo.GetByPartId(selectedElement.Id);
                    if (results != null)
                    {
                        InspectionTestResults = new BindingList<InspectionTestResult>(results);
                    }
                    RaisePropertyChanged("SelectedElement");
                }
            }
        }

        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get { return inspectionTestResults; }
            set
            {
                if (value != inspectionTestResults)
                {
                    inspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        public void Dispose()
        {
            session.Dispose();
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }
    }
}
