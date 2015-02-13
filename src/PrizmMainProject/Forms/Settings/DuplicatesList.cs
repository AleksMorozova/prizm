using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings
{
    public class DuplicatesList
    {
        public List<string> Duplicates {get;set;}
        public Func<GridView , List<string>> Method;

    }
}
