using Data.DAL.Construction;
using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity;
using Domain.Entity.Construction;
using Domain.Entity.Mill;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Documents;
using PrizmMain.Forms.PipeMill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Spool
{
    public class SpoolViewModel : ViewModelBase, IDisposable
    {
        private readonly ISpoolRepositories repos;
        readonly ICommand searchCommand;
        readonly ICommand cutCommand;
        readonly ICommand saveCommand;
        public string pipeNumber;
        public string spoolNumber;
        public int pipeLength;
        public int spoolLength;
        readonly IUserNotify notify;
        private IModifiable modifiableView;
        public Domain.Entity.Construction.Spool Spool { get; set; }
        public BindingList<Pipe> allPipes { get; set; }

        [Inject]
        public SpoolViewModel(ISpoolRepositories repos, IUserNotify notify)
        {
            this.repos = repos;

            this.notify=notify;
            this.Inspectors = repos.RepoInspector.GetAll();

            searchCommand = ViewModelSource.Create<EditPipeForCutCommand>(
              () => new EditPipeForCutCommand(this, repos, notify));

            cutCommand = ViewModelSource.Create<CutSpoolCommand>(
             () => new CutSpoolCommand(this, repos, notify));

            saveCommand = ViewModelSource.Create<SaveSpoolCommand>(
            () => new SaveSpoolCommand(this, repos, notify));

            allPipes = new BindingList<Pipe>();

            foreach (Pipe p in repos.SpoolRepo.GetAvailablePipes()) 
            {
                allPipes.Add(p);
            }
            Spool = new Domain.Entity.Construction.Spool();
            Spool.InspectionTestResults = new BindingList<InspectionTestResult>();
            Spool.Pipe = new Pipe();
            Pipe = new Pipe();
            
        }

        public string SpoolNumber
        {
            get { return Spool.Number; }
            set
            {
                if (value != Spool.Number)
                {
                    Spool.Number = value;
                    RaisePropertyChanged("SpoolNumber");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return Spool.PipeNumber;
            }
            set
            {
                if (value != Spool.PipeNumber)
                {
                    Spool.PipeNumber = value;

                    StringBuilder number = new StringBuilder();
                    int spoolNumber = repos.SpoolRepo.GetAllSpoolFromPipe(Spool.PipeNumber).Count + 1;
                    number.Append(Spool.PipeNumber + "/" + spoolNumber.ToString());
                    Spool.Number = number.ToString();

                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public Pipe SpoolPipe
        {
            get { return Spool.Pipe;}
            set
            {
                if (value != Spool.Pipe)
                {
                    Spool.Pipe = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public int PipeLength
        {
            get
            {
                return Spool.Pipe.Length;
            }
            set
            {
                if (value != Spool.Pipe.Length)
                {
                    Spool.Pipe.Length = value;                    
                    RaisePropertyChanged("PipeLength");
                }
            }
        }

        //public float PipeWeight
        //{
        //    get
        //    {
        //        return Pipe.Weight;
        //    }
        //    set
        //    {
        //        if (value != Pipe.Weight)
        //        {
        //            Pipe.Weight = value;
        //            RaisePropertyChanged("PipeWeight");
        //        }
        //    }
        //}

        public int SpoolLength
        {
            get { return Spool.Length; }
            set
            {
                if (value != Spool.Length)
                {
                    Spool.Length = value;
                    Pipe.Length = Pipe.Length - Spool.Length;
                    Pipe.RecalculateWeight();
                    RaisePropertyChanged("SpoolLength");
                }
            }
        }

        public Pipe Pipe
        {
            get { return Spool.Pipe; }
            set
            {
                if (value != Spool.Pipe)
                {
                    Spool.Pipe = value;
                    RaisePropertyChanged("SpoolLength");
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

        public bool IsNotActive
        {
            get { return Spool.IsNotActive; }
            set
            {
                if (value != Spool.IsNotActive)
                {
                    Spool.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        public IList<Inspector> Inspectors { get; set; }
        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get
            {
                return
                    (Spool.InspectionTestResults is BindingList<InspectionTestResult>
                    ? (BindingList<InspectionTestResult>)Spool.InspectionTestResults
                    : new BindingList<InspectionTestResult>(Spool.InspectionTestResults));
            }
            set
            {
                if (value != Spool.InspectionTestResults)
                {
                    Spool.InspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        /// <summary>
        /// Customize displaying inspectors name in grid cell : show only last name
        /// </summary>
        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
        }

        #region ---- Commands ----
        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public ICommand CutCommand
        {
            get { return cutCommand; }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }
        #endregion
    }
}
