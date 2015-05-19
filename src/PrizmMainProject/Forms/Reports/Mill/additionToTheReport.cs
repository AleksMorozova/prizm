using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class AdditionToTheReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        private IList<Pipe> pipes;
        public AdditionToTheReport()
        {
            InitializeComponent();
            Program.LanguageManager.ChangeLanguage(this as ILocalizable);
            pipes = this.DataSource as List<Pipe>;
        }

        public decimal PipesLength
        {
            get { return Convert.ToInt32(pipesLength.Text); }
            set { pipesLength.Text = value.ToString(); }
        }

        public decimal PipesCount
        {
            get { return Convert.ToInt32(totalCount.Text); }
            set { totalCount.Text = value.ToString(); }
        }

        public decimal PipesWeight
        {
            get { return Convert.ToInt32(pipesWeight.Text); }
            set { pipesWeight.Text = value.ToString(); }
        }

        public bool FootersVisibility
        {
            get { return pageFooterBand.Visible; }
            set { pageFooterBand.Visible = value; }
        }


        #region --- Localization ---

        protected List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(additionToTheReportHeaderLabel, StringResources.AdditionToTheReport_AdditionToTheReportHeaderLabel.Id),            
                new LocalizedItem(numberLabel, StringResources.AdditionToTheReport_NumberLabel.Id),
                new LocalizedItem(heatNumberLabel, StringResources.AdditionToTheReport_HeatNumberLabel.Id),
                new LocalizedItem(weightLabel, StringResources.AdditionToTheReport_WeightLabel.Id),
                new LocalizedItem(lengthLabel, StringResources.AdditionToTheReport_LengthLabel.Id),
                new LocalizedItem(productionDateLabel, StringResources.AdditionToTheReport_ProductionDateLabel.Id),
                new LocalizedItem(totalCountLabel, StringResources.AdditionToTheReport_TotalCountLabel.Id),
                new LocalizedItem(pipesLengthLabel, StringResources.AdditionToTheReport_PipesLengthLabel.Id),
                new LocalizedItem(pipesWeightLabel, StringResources.AdditionToTheReport_PipesWeightLabel.Id),
            };
        }


        private List<LocalizedItem> localizedItems = null;
        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = CreateLocalizedItems();
            }
            return localizedItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion // --- Localization ---
    }
}
