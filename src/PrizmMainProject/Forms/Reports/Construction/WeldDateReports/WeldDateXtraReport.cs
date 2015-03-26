using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public partial class WeldDateXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public WeldDateXtraReport()
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
                new LocalizedItem(weldReportByDateHeader, StringResources.WeldDateXtraReport_WeldReportByDateHeader.Id),
                new LocalizedItem(dateHeader, StringResources.WeldDateXtraReport_DateHeader.Id),
                new LocalizedItem(jointNumberHeader, StringResources.WeldDateXtraReport_JointNumberHeader.Id),
                new LocalizedItem(firstPartNumberHeader, StringResources.WeldDateXtraReport_FirstPartNumberHeader.Id),
                new LocalizedItem(secondPartNumberHeader, StringResources.WeldDateXtraReport_SecondPartNumberHeader.Id),
                new LocalizedItem(firstPartLengthHeader, StringResources.WeldDateXtraReport_FirstPartLengthHeader.Id),
                new LocalizedItem(secondPartLengthHeader, StringResources.WeldDateXtraReport_SecondPartLengthHeader.Id),
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
