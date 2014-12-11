using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Construction;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Component.NewEdit
{
    public class ComponentNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IComponentRepositories repos;
        private readonly IUserNotify notify;

        private BindingList<ComponentType> componentTypes;

        private SaveComponentCommand saveCommand;
        private NewSaveComponentCommand newSaveCommand;
        private ComponentDeactivationCommand deactivationCommand;
        private IModifiable modifiableView;

        [Inject]
        public ComponentNewEditViewModel(
            IComponentRepositories repos,
            Guid componentId,
            IUserNotify notify)
        {
            this.repos = repos;
            this.notify = notify;
           
            this.componentTypes = new BindingList<ComponentType>(repos.ComponentTypeRepo.GetAll());

            saveCommand = ViewModelSource
                .Create(() => new SaveComponentCommand(this, repos, notify));

            newSaveCommand = ViewModelSource
                .Create(() => new NewSaveComponentCommand(this, repos, notify));

            deactivationCommand = ViewModelSource
                .Create(() => new ComponentDeactivationCommand(this, repos, notify));

            if (componentId == Guid.Empty)
            {
                NewComponent();
            }
            else
            {
                this.Component = repos.ComponentRepo.Get(componentId);
            }
        }

        public bool CanDeactivateComponent { get; set; }

        public BindingList<ComponentType> ComponentTypes
        {
            get
            {
                return
                    componentTypes ??
                    new BindingList<ComponentType>();
            }
            set
            {
                if (value != componentTypes)
                {
                    componentTypes = value;
                    RaisePropertyChanged("ComponentTypes");
                }
            }
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

        public Domain.Entity.Construction.Component Component { get; set; }

        public string Certificate
        {
            get 
            { 
                return 
                    Component.Certificate ??
                    string.Empty; 
            }
            set
            {
                if (value != Component.Certificate)
                {
                    Component.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        public ComponentType Type
        {
            get 
            { 
                return 
                    Component.Type ??
                    null; 
            }
            set
            {
                if (value != Component.Type)
                {
                    Component.Type = value;
                    Connectors.Clear();
                    for (int i = 0; i < value.ConnectorsCount; ++i )
                    {
                        Connectors.Add(new Connector());
                    }
                    RaisePropertyChanged("Type");
                }
            }
        }

        public string Number
        {
            get 
            { 
                return 
                    Component.Number ??
                    string.Empty; 
            }
            set
            {
                if (value != Component.Number)
                {
                    Component.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public IList<Connector> Connectors
        {
            get 
            { 
                return 
                    Component.Connectors ??
                    new List<Connector>(); 
            }
            set
            {
                if (value != Component.Connectors)
                {
                    Component.Connectors = value;
                    RaisePropertyChanged("Connectors");
                }
            }
        }

        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get
            {
                return
                    (Component.InspectionTestResults is BindingList<InspectionTestResult>
                    ? (BindingList<InspectionTestResult>) Component.InspectionTestResults
                    : new BindingList<InspectionTestResult>(Component.InspectionTestResults));
            }
            set
            {
                if (value != Component.InspectionTestResults)
                {
                    Component.InspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        public bool IsNotActive
        {
            get { return Component.IsNotActive; }
            set
            {
                if (value != Component.IsNotActive)
                {
                    Component.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand NewSaveCommand
        {
            get { return newSaveCommand; }
        }

        public ICommand DeactivationCommand
        {
            get { return deactivationCommand; }
        }

        public void NewComponent()
        {
            this.Component = new Domain.Entity.Construction.Component();

            this.Component.InspectionStatus = PieceInspectionStatus.Pending;
            this.Component.ConstructionStatus = PieceConstructionStatus.Pending;
            this.Component.IsActive = true;
            this.Number = string.Empty;
            this.Certificate = string.Empty;
            this.Type = null;

            this.CanDeactivateComponent = false;

        }

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
        }
    }
}
