using System;
using System.Linq;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using Prizm.Main.Commands;
using System.ComponentModel;
using Prizm.Domain.Entity.Mill;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using Prizm.Main.Properties;
using System.Windows.Forms;
using Prizm.Data.DAL;
using Prizm.Main.Documents;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    public class ReleaseNoteViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ReleaseNoteViewModel));

        public class PlainPipe
        {
            private SimplePipe pipe;

            public static implicit operator SimplePipe(PlainPipe p)
            {
                return p.pipe;
            }

            public PlainPipe(SimplePipe p)
            {
                pipe = p;
            }
            public virtual Guid Id
            {
                get { return pipe.Id; }
            }

            public virtual string PipeNumber
            {
                get { return pipe.Number; }
                set { pipe.Number = value; }
            }

            public virtual string PipeType
            {
                get { return pipe.Type.Type; }
                set { pipe.Type.Type = value; }
            }

            public virtual PipeMillStatus PipeStatus
            {
                get { return pipe.Status; }
                set { pipe.Status = value; }
            }

            public virtual string RailcarNumber
            {
                get { return pipe.Railcar.Number; }
                set { pipe.Railcar.Number = value; }
            }
            public virtual string RailcarCertificate
            {
                get { return pipe.Railcar.Certificate; }
                set { pipe.Railcar.Certificate = value; }
            }
            public virtual string RailcarDestination
            {
                get { return pipe.Railcar.Destination; }
                set { pipe.Railcar.Destination = value; }
            }
        }

        public class PlainPipeBindingList : BindingList<PlainPipe>
        {
            /// <summary>
            /// special removal method for plain pipes, if there is only reference to pipe
            /// </summary>
            /// <param name="p">pipe to remove</param>
            /// <returns>status if pipe was removed from plain pipes list</returns>
            public bool Remove(SimplePipe p)
            {
                bool removed = false;
                for (int index = 0; index < this.Count; index++)
                {
                    if(p == (SimplePipe)this[index])
                    {
                        this.RemoveAt(index);
                        removed = true; 
                        break;
                    }
                }
                return removed;
            }
        }

        public PlainPipeBindingList ReleaseNotePipes { get; set; }

        private SimpleRailcar railcar = new SimpleRailcar();
        private readonly IReleaseNoteRepositories repos;
        private readonly IUserNotify notify;
        private readonly SaveReleaseNoteCommand saveCommand;
        private readonly ShipReleaseNoteCommand shipCommand;
        private readonly UnshipReleaseNoteCommand unshipCommand;
        private readonly ISecurityContext ctx;
        private List<SimplePipe> pipesToAdd = null;
        IModifiable modifiableView = null;
        public IValidatable validatableView { get; set; }
        public ExternalFilesViewModel FilesFormViewModel { get; set; }
        public bool IsNew { get { return this.Railcar.IsNew(); } }

        [Inject]
        public ReleaseNoteViewModel(IReleaseNoteRepositories repos, Guid id, IUserNotify notify, ISecurityContext ctx)
        {
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;

            saveCommand = ViewModelSource.Create(() => new SaveReleaseNoteCommand(this, repos, notify,ctx));
            shipCommand = ViewModelSource.Create(() => new ShipReleaseNoteCommand(this, repos, notify, ctx));
            unshipCommand = ViewModelSource.Create(() => new UnshipReleaseNoteCommand(this, repos, notify, ctx));

            ReleaseNotePipes = new PlainPipeBindingList();
            if (id == Guid.Empty)
            {
                NewRailcar();
            }
            else
            {
                ReleaseNote = repos.SimpleNoteRepo.Get(id);
                if (ReleaseNote == null)
                {
                    log.Error(string.Format("Release Note (id:{0}) does not exist.", id));
                    // TODO: user message? close document?
                }
                else
                {
                    IList<SimplePipe> pipes = repos.SimpleNoteRepo.GetReleasedNotePipe(id);
                    foreach (var p in pipes)
                    {
                        ReleaseNotePipes.Add(new PlainPipe(p));
                    }
                }
            }
           
        }

        public List<SimplePipe> AllPipesToAdd
        {
            get
            {
                if (pipesToAdd == null)
                {
                    GetStoredPipes();
                }
                return pipesToAdd;
            }
        }

        public SimpleNote ReleaseNote { get; set; }

        #region Release Note

        public bool Shipped
        {
            get { return ReleaseNote.Shipped; }
            set
            {
                if (value != ReleaseNote.Shipped)
                {
                    ReleaseNote.Shipped = value;
                    RaisePropertyChanged("Shipped");
                    modifiableView.IsEditMode = !value;
                }
            }
        }

        public string Number
        {
            get { return ReleaseNote.Number; }
            set
            {
                if (value != ReleaseNote.Number)
                {
                    ReleaseNote.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return ReleaseNote.Date;
            }
            set
            {
                if (value != ReleaseNote.Date)
                {
                    ReleaseNote.Date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        public IList<SimpleRailcar> Railcars
        {
            get { return ReleaseNote.Railcars; }
            set
            {
                if (value != ReleaseNote.Railcars)
                {
                    int index = ReleaseNote.Railcars.IndexOf(railcar);
                    if (index > 0)
                    {
                        ReleaseNote.Railcars[index] = railcar;
                    }
                    else
                    {
                        ReleaseNote.Railcars.Add(railcar);
                    }

                    ReleaseNote.Railcars = value;
                    RaisePropertyChanged("Railcars");
                }
            }
        }

        # endregion

        #region Railcar Note

        public SimpleRailcar Railcar
        {
            get { return railcar; }
            set
            {
                if (value != railcar)
                {
                    railcar = value;
                    RaisePropertyChanged("Railcar");
                    RaisePropertyChanged("Certificate");
                    RaisePropertyChanged("Destination");
                }
            }
        }
        public string RailcarNumber
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Number;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Number)
                {
                    railcar.Number = value;
                    RaisePropertyChanged("RailcarNumber");
                }
            }
        }
        public string Destination
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Destination;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Destination)
                {
                    railcar.Destination = value;
                    RaisePropertyChanged("Destination");
                }
            }
        }
        public string Certificate
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Certificate;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Certificate)
                {
                    railcar.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        # endregion Railcar Note

        #region Commands
        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand ShipCommand
        {
            get { return shipCommand; }
        }

        public ICommand UnshipCommand
        {
            get { return unshipCommand; }
        } 
        #endregion

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
                FilesFormViewModel = null;
            }
        }

        public void AddPipe(Guid id)
        {
            if (modifiableView != null && modifiableView.IsEditMode)
            {
                if (string.IsNullOrWhiteSpace(RailcarNumber))
                {
                    notify.ShowError(
                        Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_MissingRailcar),
                        Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));

                    log.Error(String.Format("Attempt to add pipe to release note {0},{1} without railcar.",
                        ReleaseNote.Id, ReleaseNote.Number));
                }
                else
                {
                    var pipeToAdd = pipesToAdd.Find(_ => _.Id.Equals(id));
                    if (pipeToAdd != null)
                    {
                        if (pipeToAdd.Railcar != null)
                        {
                            notify.ShowError(
                                Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar)
                                    + " " + pipeToAdd.Railcar.Number,
                                Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));

                            log.Error(String.Format("Attempt to add pipe {0},{1} to release note {2},{3} while already in railcar {4},{5}.",
                                pipeToAdd.Id, pipeToAdd.Number, ReleaseNote.Id, ReleaseNote.Number, pipeToAdd.Railcar.Id, pipeToAdd.Railcar.Number));
                        }
                        else
                        {
                            if (this.Railcar.Pipes.Any(x => x.Type != pipeToAdd.Type))
                            {
                                log.Warn(string.Format("Attempt to add pipes of different mill size types to one railcar (railcar # {0})", this.Railcar.Number));

                                notify.ShowError(Program.LanguageManager.GetString(
                                    StringResources.ReleaseNoteNewEdit_DifferentTypeSizeInRailcar),
                                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                            }
                            else
                            {
                                pipeToAdd.Railcar = this.Railcar;
                                pipeToAdd.Status = PipeMillStatus.ReadyToShip;
                                Railcar.Pipes.Add(pipeToAdd);
                                ReleaseNotePipes.Add(new PlainPipe(pipeToAdd));
                                AllPipesToAdd.Remove(pipeToAdd);

                                log.Info(String.Format("Pipe {0},{1} added to Release note {2},{3} and railcar {4},{5}",
                                    pipeToAdd.Id, pipeToAdd.Number, ReleaseNote.Id, ReleaseNote.Number, pipeToAdd.Railcar.Id, pipeToAdd.Railcar.Number));
                            }
                        }
                    }
                    else
                    {
                        log.Error(String.Format("Attempt to add pipe {0} to release note {1},{2} but pipe is not in list of available pipes.",
                                id, ReleaseNote.Id, ReleaseNote.Number));
                        // TODO: user message?
                    }
                }
            }
            else
            {
                log.Warn("Attempt to add pipe to ReleaseNote in Read mode!");
                // TODO: user message?
            }
        }

        public void RemovePipe(PlainPipe pipe)
        {
            if (Railcar.IsShipped)
            {
                notify.ShowError(
                    Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_UnshipFirst),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));

                log.Warn("Attempt to remove pipe in already shipped release note!");
            }
            else
            {
                try
                {
                    AllPipesToAdd.Add(pipe);
                    ReleaseNotePipes.Remove(pipe);
                    Railcar.Pipes.Remove(pipe);
                    var tmpRailcar = ((SimplePipe)pipe).Railcar;
                    ((SimplePipe)pipe).Railcar = null;
                    ((SimplePipe)pipe).Status = PipeMillStatus.Stocked;
                    repos.SimpleNoteRepo.SaveOrUpdatePipe(pipe);

                    log.Info(String.Format("Pipe {0},{1} removed from Release note {2},{3} and railcar {4},{5}",
                        pipe.Id, pipe.PipeNumber, ReleaseNote.Id, ReleaseNote.Number, tmpRailcar.Id, tmpRailcar.Number));
                }
                catch (RepositoryException ex)
                {
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);

                    log.Error(String.Format("Failure removing pipe {0},{1} from release note {2},{3}",
                        pipe.Id, pipe.PipeNumber, ReleaseNote.Id, ReleaseNote.Number));
                }
            }
        }

        public void NewRailcar()
        {
            if (ReleaseNote == null)
            {
                ReleaseNote = new SimpleNote { Shipped = false, IsActive = true };
            }
            if (this.FilesFormViewModel != null)
            {
                this.FilesFormViewModel.Files = null;
            }
            Number = string.Empty;
            Railcars = new List<SimpleRailcar>();
        }

        /// <summary>
        /// Stored pipes are pipes which are ready to ship
        /// </summary>
        public void GetStoredPipes()
        {
            try
            {
                if (pipesToAdd == null)
                {
                    pipesToAdd = new List<SimplePipe>();
                }
                else
                {
                    pipesToAdd.Clear();
                }
                if (modifiableView.IsEditMode)
                {
                    var storedPipes = repos.SimpleNoteRepo.GetStoredPipes();
                    if (storedPipes != null)
                    {
                        pipesToAdd.AddRange(storedPipes);
                        pipesToAdd.Sort(new Comparison<SimplePipe>((p1, p2) => { return string.Compare(p1.Number, p2.Number, true); }));
                    }
                    else
                    {
                        log.Warn("NULL was returned when retrieving stored pipes ready to ship");
                    }
                }
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
                log.Error(string.Format("Unable to retrieve stored pipes: {0} {1}", ex.InnerException.Message, ex.Message));
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
    }
}