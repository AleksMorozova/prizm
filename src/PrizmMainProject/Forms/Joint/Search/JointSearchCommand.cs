using Data.DAL.Construction;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.Search
{
    public class JointSearchCommand : ICommand
    {
        IJointRepository repo;
        JointSearchViewModel viewModel;

        [Inject]
        public JointSearchCommand(JointSearchViewModel vm,IJointRepository repo)
        {
            viewModel = vm;
            this.repo = repo;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var list = repo.GetAll();
            viewModel.Joints.Clear();
            foreach(var item in list)
            {
                viewModel.Joints.Add(item);
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }

        #endregion
    }
}
