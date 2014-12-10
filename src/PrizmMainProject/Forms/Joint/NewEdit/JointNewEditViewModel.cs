using DevExpress.Mvvm;
using Ninject;
using PrizmMain.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IConstructionRepository repoConstruction;
        private readonly IUserNotify notify;
        private IModifiable modifiableView;


        [Inject]
        public JointNewEditViewModel(IConstructionRepository repoConstruction, IUserNotify notify)
        {
            this.repoConstruction = repoConstruction;
            this.notify = notify;
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
    }
}
