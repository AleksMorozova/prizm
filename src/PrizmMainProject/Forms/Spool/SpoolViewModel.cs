using Data.DAL.Construction;
using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
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
        private readonly ISpoolRepository repoSpool;
        private readonly IPipeRepository repoPipe;
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

        [Inject]
        public SpoolViewModel(IPipeRepository repoPipe, ISpoolRepository repoSpool, IUserNotify notify)
        {
            this.repoPipe = repoPipe;
            this.repoSpool = repoSpool;
            this.notify=notify;

            searchCommand = ViewModelSource.Create<SpoolSearchCommand>(
              () => new SpoolSearchCommand(this, repoPipe, notify));

            cutCommand = ViewModelSource.Create<CutSpoolCommand>(
             () => new CutSpoolCommand(this, repoPipe, repoSpool,notify));

            saveCommand = ViewModelSource.Create<SaveSpoolCommand>(
            () => new SaveSpoolCommand(this, repoSpool, notify));

            Spool = new Domain.Entity.Construction.Spool();
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

        // TODO: fixed if pipe number was wrong
        public string PipeNumber
        {
            get
            {
                return Pipe.Number;
            }
            set
            {
                if (value != Pipe.Number)
                {
                    Pipe.Number = value;
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

        // TODO: fixed if pipe number was wrong
        public int PipeLength
        {
            get
            {
                return Pipe.Length;
            }
            set
            {
                if (value != Pipe.Length)
                {
                    Pipe.Length = value;
                    Pipe.ChangePipeWeight(Pipe.WallThickness, Pipe.Diameter, Pipe.Length);
                    RaisePropertyChanged("PipeLength");
                }
            }
        }

        public int SpoolLength
        {
            get { return Spool.Length; }
            set
            {
                if (value != Spool.Length)
                {
                    Spool.Length = value;
                    Pipe.Length = Pipe.Length - Spool.Length;
                    Pipe.ChangePipeWeight(Pipe.WallThickness, Pipe.Diameter, Pipe.Length);
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

        public void Dispose()
        {
            repoPipe.Dispose();
            repoSpool.Dispose();
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
