using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class MillPipeSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
            pipeMillStatus.Text = "в производстве";
            pipeNumber.Text = "589541";
            pipeSize.Text = "1219х17,5; 20,6; 27,0мм";

            BindingList<PipesDummy> pipeList = new BindingList<PipesDummy>();
            pipeList.Add(new PipesDummy { PipeNumber = 1342352, Size = "1219х17,5; 20,6; 27,0мм", Status = "на складе", HeatNumber = "3517256", WeldingDate = "11.09.2014", InternalCoatingDate = "04.11.2014", ExternalCoatingDate="18.10.2014" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634626, Size = "1219х17,5; 20,6; 27,0мм", Status = "на складе", HeatNumber = "3517256", WeldingDate = "10.09.2014", InternalCoatingDate = "04.11.2014", ExternalCoatingDate = "18.10.2014" });
            pipeList.Add(new PipesDummy { PipeNumber = 2141532, Size = "1219х17,5; 20,6; 27,0мм", Status = "на складе", HeatNumber = "3517256", WeldingDate = "10.09.2014", InternalCoatingDate = "04.11.2014", ExternalCoatingDate = "18.10.2014" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634624, Size = "1219х17,5; 20,6; 27,0мм", Status = "на складе", HeatNumber = "3517256", WeldingDate = "11.09.2014", InternalCoatingDate = "04.11.2014", ExternalCoatingDate = "18.10.2014" });

            pipesSearchResult.DataSource = pipeList;


        }
    }
}