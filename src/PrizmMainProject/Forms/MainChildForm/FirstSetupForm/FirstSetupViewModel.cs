using Domain.Entity.Setup;
using PrizmMain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupViewModel
    {
        public FirstSetupViewModel()
        {
            var mill = new EnumWrapper<WorkstationType> { Value = WorkstationType.Mill };
            var inspection = new EnumWrapper<WorkstationType> { Value = WorkstationType.Inspection };
            var construction = new EnumWrapper<WorkstationType> { Value = WorkstationType.Construction };
            var master = new EnumWrapper<WorkstationType> { Value = WorkstationType.Master };
            Types.Add(mill);
            Types.Add(inspection);
            Types.Add(construction);
            Types.Add(master);
        }

        public BindingList<EnumWrapper<WorkstationType>> Types = new BindingList<EnumWrapper<WorkstationType>>();
        

    }
}
