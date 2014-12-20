using System;
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

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class RailcarViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IRailcarRepositories repos;
        private readonly IUserNotify notify;
        private readonly SaveRailcarCommand saveCommand;
        private readonly ShipRailcarCommand shipCommand;
        private readonly UnshipRailcarCommand unshipCommand;
        private List<Pipe> allPipes;
        IModifiable modifiableView;
        public ExternalFilesViewModel FilesFormViewModel { get; set; }

        [Inject]
        public RailcarViewModel(IRailcarRepositories repos, string railcarNumber, IUserNotify notify)
        {
            this.repos = repos;
            this.notify = notify;

            GetStoredPipes();

            saveCommand = ViewModelSource.Create(() => new SaveRailcarCommand(this, repos, notify));
            shipCommand = ViewModelSource.Create(() => new ShipRailcarCommand(this, repos, notify));
            unshipCommand = ViewModelSource.Create(() => new UnshipRailcarCommand(this, repos, notify));

            if (string.IsNullOrWhiteSpace(railcarNumber))
            {
                NewRailcar();
            }
            else
            {
                Railcar = repos.RailcarRepo.GetByNumber(railcarNumber);
                if (!Railcar.ShippingDate.HasValue)
                {
                    Railcar.ShippingDate = DateTime.MinValue;
                }
            }
            
        }

        

        public List<Pipe> AllPipes
        {
            get { return allPipes; }
        }

        public Prizm.Domain.Entity.Mill.Railcar Railcar { get; set; }

        public string Number
        {
            get { return Railcar.Number; }
            set
            {
                if (value != Railcar.Number)
                {
                    Railcar.Number = value;
                    RaisePropertyChanged("Number");
                    ShipCommand.IsExecutable ^= true;
                    UnshipCommand.IsExecutable ^= true;
                    SaveCommand.IsExecutable ^= true;
                }
            }
        }

        public string Destination
        {
            get { return Railcar.Destination; }
            set
            {
                if (value != Railcar.Destination)
                {
                    Railcar.Destination = value;
                    RaisePropertyChanged("Destination");
                }
            }
        }

        public string Certificate
        {
            get { return Railcar.Certificate; }
            set
            {
                if (value != Railcar.Certificate)
                {
                    Railcar.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        public DateTime ShippingDate
        {
            get 
            {
                if (Railcar.ShippingDate.HasValue)
                {
                    return Railcar.ShippingDate.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            
            }
            set
            {
                if (value != Railcar.ShippingDate)
                {
                    Railcar.ShippingDate = value;
                    RaisePropertyChanged("ShippingDate");
                }
            }
        }

        public bool IsShipped
        {
            get { return Railcar.IsShipped; }
            set
            {
                if (value != Railcar.IsShipped)
                {
                    Railcar.IsShipped = value;
                    RaisePropertyChanged("IsShipped");
                    modifiableView.IsEditMode = !value;
                }
            }
        }

        public IList<Pipe> Pipes
        {
            get { return Railcar.Pipes; }
            set 
            {
                if (value != Railcar.Pipes)
                {
                    Railcar.Pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

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
            }
        }

        public void AddPipe(Guid id)
        {
            foreach (var pipe in Pipes)
	        {
                if (pipe.Id == id)
	            {
		        return;
	            }
	        }
            GetStoredPipes();

            var pipeToAdd = allPipes.Find(_ => _.Id.Equals(id));

            if (!(pipeToAdd.Railcar == null))
            {
                notify.ShowError(Resources.DLG_RAILCAR_PIPE_IN_OTHER_CAR_ERROR + pipeToAdd.Railcar.Number,
                    Resources.DLG_ERROR_HEADER);
            }
            else
            {
                Pipes.Add(pipeToAdd);
            }

            
        }

        public void RemovePipe(string number)
        {
            if (Railcar.IsShipped)
            {
                notify.ShowError(Resources.DLG_RAILCAR_UNSHIP_FIRST, Resources.DLG_ERROR_HEADER);
                return;
            }

            foreach (var pipe in Pipes)
            {
                if (pipe.Number == number)
                {
                    try
                    {
                        Pipes.Remove(pipe);
                        pipe.Railcar = null;
                        repos.PipeRepo.Merge(pipe);
                        break;
                    }
                    catch (RepositoryException ex)
                    {
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
            }
        }

        public void NewRailcar()
        {
            if (Railcar == null)
            {
                Railcar = new Prizm.Domain.Entity.Mill.Railcar {IsShipped = false, IsActive = true};
            }
            Number = string.Empty;
            Destination = string.Empty;
            ShippingDate = DateTime.MinValue;
            Certificate = string.Empty;

            Pipes = new List<Pipe>();
        }

        public void GetStoredPipes()
        {
            try
            {
                var tmp = new List<Pipe>(repos.PipeRepo.GetStored());
                allPipes = tmp;
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
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