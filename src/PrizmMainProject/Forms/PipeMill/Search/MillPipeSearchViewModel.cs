using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Search
{
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using Ninject;
    using PrizmMain.Commands;
    using System;
    using System.Windows.Forms;
    using Pipe = Domain.Entity.Mill.Pipe;

    using Data.DAL.Mill;
    using Domain.Entity.Mill;
    using PrizmMain.Common;


    public class MillPipeSearchViewModel : ViewModelBase, IDisposable
    {

        readonly ICommand searchCommand;
        readonly IPipeRepository repo;
        private IList<Pipe> pipes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        private string pipeNumber;
        private string pipeSize;
        private EnumWrapper<PipeMillStatus> pipeMillStatus;

        [Inject]
        public MillPipeSearchViewModel(IPipeRepository repo)
        {
            this.repo = repo;
            searchCommand = ViewModelSource.Create<MillPipeSearchCommand>(
                () => new MillPipeSearchCommand(this, repo));
            LoadPipeMillStatuses();

        }
        public IList<Pipe> Pipes
        {
            get
            {
                return pipes;
            }
            set
            {
                if (value != pipes)
                {
                    pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return pipeNumber;
            }
            set
            {
                if (value != pipeNumber)
                {
                    pipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }


        public string PipeSize
        {
            get
            {
                return pipeSize;
            }
            set
            {
                if (value != pipeSize)
                {
                    pipeSize = value;
                    RaisePropertyChanged("PipeSize");
                }
            }
        }

        public EnumWrapper<PipeMillStatus> PipeMillStatus
        {
            get
            {
                return pipeMillStatus;
            }
            set
            {
                if (value != pipeMillStatus)
                {
                    pipeMillStatus = value;
                    RaisePropertyChanged("PipeMillStatus");
                }
            }
        }


        public IList<EnumWrapper<PipeMillStatus>> StatusTypes
        {
            get { return statusTypes; }
            set
            {
                if (value != statusTypes)
                {
                    statusTypes = value;
                    RaisePropertyChanged("StatusTypes");
                }
            }
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }
        private void LoadPipeMillStatuses()
        {
            StatusTypes = new List<EnumWrapper<PipeMillStatus>>();

            foreach (string statusTypeName in Enum.GetNames(typeof(PipeMillStatus)))
            {
                if (statusTypeName != Enum.GetName(typeof(PipeMillStatus), Domain.Entity.Mill.PipeMillStatus.Undefined))
                {
                    StatusTypes.Add(new EnumWrapper<PipeMillStatus>() { Name = statusTypeName });
                }
            }
        }

    }
}
