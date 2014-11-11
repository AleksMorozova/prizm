﻿using System;
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


    public class MillPipeSearchViewModel : ViewModelBase, IDisposable
    {

        readonly ICommand searchCommand;
        readonly IPipeRepository repo;
        private IList<Pipe> pipes;

        [Inject]
        public MillPipeSearchViewModel(IPipeRepository repo)
        {
            this.repo = repo;
            searchCommand = ViewModelSource.Create<MillPipeSearchCommand>(
                () => new MillPipeSearchCommand(this, repo));

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




        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }


        public void Dispose()
        {
            repo.Dispose();
        }


    }
}
