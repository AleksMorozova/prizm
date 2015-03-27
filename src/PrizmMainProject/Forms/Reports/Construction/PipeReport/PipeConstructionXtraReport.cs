using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public partial class PipeConstructionXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public PipeConstructionXtraReport()
        {
            InitializeComponent();

            Program.LanguageManager.ChangeLanguage(this as ILocalizable);
        }

        public bool FootersVisibility
        {
            get { return pageFooter.Visible; }
            set { pageFooter.Visible = value; }
        }


        #region --- Localization ---

        protected List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(pipeConstructionReportHeader, StringResources.PipeConstructionXtraReport_PipeConstructionReportHeader.Id),
                new LocalizedItem(pipeNumberHeader, StringResources.PipeConstructionXtraReport_PipeNumberHeader.Id),
                new LocalizedItem(diameterHeader, StringResources.PipeConstructionXtraReport_DiameterHeader.Id),
                new LocalizedItem(lengthHeader, StringResources.PipeConstructionXtraReport_LengthHeader.Id),
                new LocalizedItem(thicknessHeader, StringResources.PipeConstructionXtraReport_ThicknessHeader.Id),
                new LocalizedItem(seamTypeHeader, StringResources.PipeConstructionXtraReport_SeamTypeHeader.Id),
                new LocalizedItem(gradeHeader, StringResources.PipeConstructionXtraReport_GradeHeader.Id),
                new LocalizedItem(firstJointHeader, StringResources.PipeConstructionXtraReport_FirstJointHeader.Id),
                new LocalizedItem(secondJointHeader, StringResources.PipeConstructionXtraReport_SecondJointHeader.Id),
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
