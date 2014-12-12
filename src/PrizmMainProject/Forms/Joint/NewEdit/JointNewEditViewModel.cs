using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Construction;
using Domain.Entity.Setup;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Documents;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construction = Domain.Entity.Construction;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IConstructionRepository repoConstruction;
        private readonly Data.DAL.IMillReportsRepository adoRepo;
        private readonly IUserNotify notify;
        private readonly SaveJointCommand saveJointCommand;
        private readonly ExtractOperationsCommand extractOperationsCommand;
        private IModifiable modifiableView;
        public Guid JointId { get; set; }
        public construction.Joint Joint { get; set; }
        private DataTable pieces;
        public BindingList<JointOperation> Operations;


        [Inject]
        public JointNewEditViewModel(IConstructionRepository repoConstruction, IUserNotify notify, Guid jointId, Data.DAL.IMillReportsRepository adoRepo)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = jointId;
            this.notify = notify;
            this.adoRepo = adoRepo;

            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify));
            extractOperationsCommand =
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this));

            Pieces = adoRepo.GetPipelineElements();
            extractOperationsCommand.Execute();
            if (jointId == Guid.Empty)
            {
                NewJoint();
            }
            else
            {
                this.Joint = repoConstruction.RepoJoint.Get(jointId);
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

        #region Commands
        public ICommand SaveJointCommand
        {
            get { return saveJointCommand; }
        }

        public ICommand ExtractOperationsCommand
        {
            get { return extractOperationsCommand; }
        }
        #endregion

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

        public DateTime LoweringDate
        {
            get
            {
                if (Joint.LoweringDate.HasValue)
                {
                    return Joint.LoweringDate.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set 
            {
                if (value != Joint.LoweringDate)
                {
                    Joint.LoweringDate = value;
                    RaisePropertyChanged("LoweringDate");
                }
            }
        }

        public float GpsHeight
        {
            get { return Joint.GpsHeight; }
            set
            {
                if (value != Joint.GpsHeight)
                {
                    Joint.GpsHeight = value;
                    RaisePropertyChanged("GpsHeight");
                }
            }
        }

        public double GpsLatitude
        {
            get { return Joint.GpsLatitude; }
            set
            {
                if (value != Joint.GpsLatitude)
                {
                    Joint.GpsLatitude = value;
                    RaisePropertyChanged("GpsLatitude");
                }
            }
        }

        public double GpsLongitude
        {
            get { return Joint.GpsLongitude; }
            set
            {
                if (value != Joint.GpsLongitude)
                {
                    Joint.GpsLongitude = value;
                    RaisePropertyChanged("GpsLongitude");
                }
            }
        }

        public int NumberKP
        {
            get { return Joint.NumberKP; }
            set
            {
                if (value != Joint.NumberKP)
                {
                    Joint.NumberKP = value;
                    RaisePropertyChanged("NumberKP");
                }
            }
        }

        public float DistanceFromKP
        {
            get { return Joint.DistanceFromKP; }
            set
            {
                if (value != Joint.DistanceFromKP)
                {
                    Joint.DistanceFromKP = value;
                    RaisePropertyChanged("DistanceFromKP");
                }
            }
        }
        #endregion 

        public DataTable Pieces
        {
            get 
            { 
                return pieces;
            }
            set 
            {
                if (value != pieces)
                {
                    foreach (DataRow record in value.Rows)
                    {
                        string typeResourceValue = Resources.ResourceManager.GetString(record.Field<string>("type"));
                        record.SetField("type", typeResourceValue);
                        pieces = value;
                        RaisePropertyChanged("Pieces");
                    }
                }
            }
        }

        private void NewJoint()
        {
            this.Joint = new construction.Joint();
            this.Joint.IsActive = true;
            this.Joint.Status = JointStatus.Welded;
            this.Number = String.Empty;
            this.LoweringDate = DateTime.MinValue;
        }
    }
}
