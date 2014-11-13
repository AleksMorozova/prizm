using Data.DAL.Mill;
using DevExpress.Office.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepository heatRepo;
        private readonly IPlateManufacturerRepository plateManufacturerRepo;

        //private readonly SaveRailcarCommand saveCommand;

        public HeatViewModel()
        {

        }

        public void Dispose()
        {
            heatRepo.Dispose();
            plateManufacturerRepo.Dispose();
        }
    }
}
