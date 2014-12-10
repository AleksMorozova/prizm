using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construction = Domain.Entity.Construction;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IConstructionRepository repoConstruction;
        private readonly IUserNotify notify;
        private readonly SaveJointCommand saveJointCommand;
        private IModifiable modifiableView;
        public Guid JointId { get; set; }
        public construction.Joint Joint { get; set; }


        [Inject]
        public JointNewEditViewModel(IConstructionRepository repoConstruction, IUserNotify notify, Guid jointId)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = jointId;
            this.notify = notify;

            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify));


            if (jointId == Guid.Empty)
            {
                NewJoint();
            }
            else
            { 
            
            }
        }

        public void Dispose()
        {
            repoConstruction.Dispose();
            ModifiableView = null;
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

        public ICommand SaveJointCommand
        {
            get { return saveJointCommand; }
        }

        # region Joint
        public bool IsNotActive
        {
            get
            {
                return Joint.IsNotActive;
            }
            set
            {
                if (value != Joint.IsNotActive)
                {
                    Joint.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        public string Number
        {
            get { return Joint.Number; }
            set
            {
                if (value != Joint.Number)
                {
                    Joint.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }
        #endregion 

        private void NewJoint()
        {
            this.Joint = new construction.Joint();
            this.Joint.IsActive = true;
            this.Number = String.Empty;
        }
    }
}
