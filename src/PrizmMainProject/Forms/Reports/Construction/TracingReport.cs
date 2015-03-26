using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class TracingReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public TracingReport()
        {
            InitializeComponent();
            Program.LanguageManager.ChangeLanguage(this as ILocalizable);
        }

        public int PipelineJointCount
        {
            get { return Convert.ToInt32(pipelineJointCountXrLabel.Text); }
            set { pipelineJointCountXrLabel.Text = value.ToString(); }
        }

        public int PipelinePipeCount
        {
            get { return Convert.ToInt32(pipelinePipeCountXrLabel.Text); }
            set { pipelinePipeCountXrLabel.Text = value.ToString(); }
        }

        public int PipelineSpoolCount
        {
            get { return Convert.ToInt32(pipelineSpoolCountXrLabel.Text); }
            set { pipelineSpoolCountXrLabel.Text = value.ToString(); }
        }

        public int PipelineComponentCount
        {
            get { return Convert.ToInt32(pipelineComponentCount.Text); }
            set { pipelineComponentCount.Text = value.ToString(); }
        }

        public int PipelineLength
        {
            get { return Convert.ToInt32(pipelineLengthXrLabel.Text); }
            set { pipelineLengthXrLabel.Text = value.ToString(); }
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
                new LocalizedItem(tracingPageHeaderXrLabel, StringResources.TracingReport_TracingPageHeaderXrLabel.Id),
                new LocalizedItem(jointNumberHeder, StringResources.TracingReport_JointNumberHeder.Id),
                new LocalizedItem(xrLabel12, StringResources.TracingReport_WeldingDate.Id),
                new LocalizedItem(partNumberHeader, StringResources.TracingReport_FirstPartNumberHeader.Id),
                new LocalizedItem(partTypeHeder, StringResources.TracingReport_FirstPartTypeHeder.Id),
                new LocalizedItem(lengthHeder, StringResources.TracingReport_FirstPartLengthHeder.Id),
                new LocalizedItem(xrLabel9, StringResources.TracingReport_SecondPartNumberHeader.Id),
                new LocalizedItem(xrLabel10, StringResources.TracingReport_SecondPartTypeHeder.Id),
                new LocalizedItem(xrLabel11, StringResources.TracingReport_SecondPartLengthHeder.Id),
                new LocalizedItem(pipelineJointCountHeader, StringResources.TracingReport_PipelineJointCountHeader.Id),
                new LocalizedItem(pipelinePipeCountHeader, StringResources.TracingReport_PipelinePipeCountHeader.Id),
                new LocalizedItem(pipelineSpoolCountHeader, StringResources.TracingReport_PipelineSpoolCountHeader.Id),
                new LocalizedItem(pipelineComponentHeader, StringResources.TracingReport_PipelineComponentHeader.Id),
                new LocalizedItem(pipelineLengthHeader, StringResources.TracingReport_PipelineLengthHeader.Id),
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
