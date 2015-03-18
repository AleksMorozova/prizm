namespace Prizm.Main.Forms.Reports.Construction
{
    partial class TracingReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.weldingDateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartTypeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondLenghtXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstLenghtXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartTypeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TracingPageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.tracingPageHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.TracingGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.lengthHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.partTypeHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.partNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.pipelineComponentCount = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineComponentHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineJointCountXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelinePipeCountXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineSpoolCountXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineLengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineSpoolCountHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelinePipeCountHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineJointCountHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.tracingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.tracingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.weldingDateXrLabel,
            this.secondPartTypeXrLabel,
            this.secondPartNumberXrLabel,
            this.secondLenghtXrLabel,
            this.jointNumberXrLabel,
            this.firstLenghtXrLabel,
            this.firstPartNumberXrLabel,
            this.firstPartTypeXrLabel});
            this.Detail.HeightF = 26.125F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // weldingDateXrLabel
            // 
            this.weldingDateXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "WeldingDate")});
            this.weldingDateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(97.47025F, 0F);
            this.weldingDateXrLabel.Name = "weldingDateXrLabel";
            this.weldingDateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.weldingDateXrLabel.SizeF = new System.Drawing.SizeF(97.47027F, 26.125F);
            // 
            // secondPartTypeXrLabel
            // 
            this.secondPartTypeXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartTypeDescription")});
            this.secondPartTypeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(584.8215F, 0F);
            this.secondPartTypeXrLabel.Name = "secondPartTypeXrLabel";
            this.secondPartTypeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartTypeXrLabel.SizeF = new System.Drawing.SizeF(97.47034F, 26.125F);
            // 
            // secondPartNumberXrLabel
            // 
            this.secondPartNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartNumber")});
            this.secondPartNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(487.3513F, 0F);
            this.secondPartNumberXrLabel.Name = "secondPartNumberXrLabel";
            this.secondPartNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartNumberXrLabel.SizeF = new System.Drawing.SizeF(97.47018F, 26.125F);
            // 
            // secondLenghtXrLabel
            // 
            this.secondLenghtXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartLength")});
            this.secondLenghtXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(682.2918F, 0F);
            this.secondLenghtXrLabel.Name = "secondLenghtXrLabel";
            this.secondLenghtXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondLenghtXrLabel.SizeF = new System.Drawing.SizeF(67.70833F, 26.125F);
            // 
            // jointNumberXrLabel
            // 
            this.jointNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "JointNumber")});
            this.jointNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.jointNumberXrLabel.Name = "jointNumberXrLabel";
            this.jointNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberXrLabel.SizeF = new System.Drawing.SizeF(97.0238F, 26.125F);
            // 
            // firstLenghtXrLabel
            // 
            this.firstLenghtXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstPartLength")});
            this.firstLenghtXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(389.881F, 0F);
            this.firstLenghtXrLabel.Name = "firstLenghtXrLabel";
            this.firstLenghtXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstLenghtXrLabel.SizeF = new System.Drawing.SizeF(97.47028F, 26.125F);
            // 
            // firstPartNumberXrLabel
            // 
            this.firstPartNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstPartNumber")});
            this.firstPartNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(194.9405F, 0F);
            this.firstPartNumberXrLabel.Name = "firstPartNumberXrLabel";
            this.firstPartNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartNumberXrLabel.SizeF = new System.Drawing.SizeF(97.47029F, 26.125F);
            // 
            // firstPartTypeXrLabel
            // 
            this.firstPartTypeXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstPartTypeDescription")});
            this.firstPartTypeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(292.4108F, 0F);
            this.firstPartTypeXrLabel.Name = "firstPartTypeXrLabel";
            this.firstPartTypeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartTypeXrLabel.SizeF = new System.Drawing.SizeF(97.47021F, 26.125F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 36.8749F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TracingPageHeader
            // 
            this.TracingPageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tracingPageHeaderXrLabel,
            this.reportDateTimeInfo});
            this.TracingPageHeader.HeightF = 69.79167F;
            this.TracingPageHeader.Name = "TracingPageHeader";
            // 
            // tracingPageHeaderXrLabel
            // 
            this.tracingPageHeaderXrLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tracingPageHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 19.79167F);
            this.tracingPageHeaderXrLabel.Name = "tracingPageHeaderXrLabel";
            this.tracingPageHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tracingPageHeaderXrLabel.SizeF = new System.Drawing.SizeF(750.0001F, 50F);
            this.tracingPageHeaderXrLabel.StylePriority.UseFont = false;
            this.tracingPageHeaderXrLabel.StylePriority.UseTextAlignment = false;
            this.tracingPageHeaderXrLabel.Text = "Трассировка трубопровода";
            this.tracingPageHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "Сформирован: {0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(502.5298F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(246.845F, 19.79167F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TracingGroupHeader
            // 
            this.TracingGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.jointNumberHeder,
            this.lengthHeder,
            this.partTypeHeder,
            this.partNumberHeader});
            this.TracingGroupHeader.HeightF = 35.41667F;
            this.TracingGroupHeader.Name = "TracingGroupHeader";
            // 
            // xrLabel12
            // 
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(97.0238F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(97.0238F, 34.45833F);
            this.xrLabel12.Text = "Дата сварки";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(485.119F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(97.02383F, 34.45833F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Номер элемента 2";
            // 
            // xrLabel10
            // 
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(582.1428F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(97.02386F, 34.45833F);
            this.xrLabel10.Text = "Тип элемента 2";
            // 
            // xrLabel11
            // 
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(679.1666F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(70.20836F, 34.45833F);
            this.xrLabel11.Text = "Длина, мм";
            // 
            // jointNumberHeder
            // 
            this.jointNumberHeder.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.jointNumberHeder.Name = "jointNumberHeder";
            this.jointNumberHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberHeder.SizeF = new System.Drawing.SizeF(97.0238F, 34.45833F);
            this.jointNumberHeder.Text = "Номер стыка";
            // 
            // lengthHeder
            // 
            this.lengthHeder.LocationFloat = new DevExpress.Utils.PointFloat(388.0952F, 0F);
            this.lengthHeder.Name = "lengthHeder";
            this.lengthHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lengthHeder.SizeF = new System.Drawing.SizeF(97.02377F, 34.45833F);
            this.lengthHeder.Text = "Длина, мм";
            // 
            // partTypeHeder
            // 
            this.partTypeHeder.LocationFloat = new DevExpress.Utils.PointFloat(291.0714F, 0F);
            this.partTypeHeder.Name = "partTypeHeder";
            this.partTypeHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partTypeHeder.SizeF = new System.Drawing.SizeF(97.02377F, 34.45833F);
            this.partTypeHeder.Text = "Тип элемента 1";
            // 
            // partNumberHeader
            // 
            this.partNumberHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.partNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(194.0476F, 0F);
            this.partNumberHeader.Name = "partNumberHeader";
            this.partNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partNumberHeader.SizeF = new System.Drawing.SizeF(97.0238F, 34.45833F);
            this.partNumberHeader.StylePriority.UseFont = false;
            this.partNumberHeader.Text = "Номер элемента 1";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pipelineComponentCount,
            this.pipelineComponentHeader,
            this.pipelineJointCountXrLabel,
            this.pipelinePipeCountXrLabel,
            this.pipelineSpoolCountXrLabel,
            this.pipelineLengthXrLabel,
            this.pipelineLengthHeader,
            this.pipelineSpoolCountHeader,
            this.pipelinePipeCountHeader,
            this.pipelineJointCountHeader});
            this.ReportFooter.HeightF = 56.70836F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // pipelineComponentCount
            // 
            this.pipelineComponentCount.LocationFloat = new DevExpress.Utils.PointFloat(292.4109F, 33.70836F);
            this.pipelineComponentCount.Name = "pipelineComponentCount";
            this.pipelineComponentCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineComponentCount.SizeF = new System.Drawing.SizeF(97.47015F, 23F);
            // 
            // pipelineComponentHeader
            // 
            this.pipelineComponentHeader.LocationFloat = new DevExpress.Utils.PointFloat(292.4109F, 0F);
            this.pipelineComponentHeader.Name = "pipelineComponentHeader";
            this.pipelineComponentHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineComponentHeader.SizeF = new System.Drawing.SizeF(97.47018F, 33.70835F);
            this.pipelineComponentHeader.Text = "Количество компонентов";
            // 
            // pipelineJointCountXrLabel
            // 
            this.pipelineJointCountXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 33.70835F);
            this.pipelineJointCountXrLabel.Name = "pipelineJointCountXrLabel";
            this.pipelineJointCountXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineJointCountXrLabel.SizeF = new System.Drawing.SizeF(97.0238F, 23.00001F);
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            this.pipelineJointCountXrLabel.Summary = xrSummary1;
            // 
            // pipelinePipeCountXrLabel
            // 
            this.pipelinePipeCountXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(97.0238F, 33.70835F);
            this.pipelinePipeCountXrLabel.Name = "pipelinePipeCountXrLabel";
            this.pipelinePipeCountXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelinePipeCountXrLabel.SizeF = new System.Drawing.SizeF(97.91672F, 23.00001F);
            // 
            // pipelineSpoolCountXrLabel
            // 
            this.pipelineSpoolCountXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(194.9405F, 33.70835F);
            this.pipelineSpoolCountXrLabel.Name = "pipelineSpoolCountXrLabel";
            this.pipelineSpoolCountXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineSpoolCountXrLabel.SizeF = new System.Drawing.SizeF(97.47029F, 23F);
            // 
            // pipelineLengthXrLabel
            // 
            this.pipelineLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(389.881F, 33.70835F);
            this.pipelineLengthXrLabel.Name = "pipelineLengthXrLabel";
            this.pipelineLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineLengthXrLabel.SizeF = new System.Drawing.SizeF(97.47028F, 23F);
            // 
            // pipelineLengthHeader
            // 
            this.pipelineLengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(389.881F, 0F);
            this.pipelineLengthHeader.Name = "pipelineLengthHeader";
            this.pipelineLengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineLengthHeader.SizeF = new System.Drawing.SizeF(97.47028F, 33.70835F);
            this.pipelineLengthHeader.Text = "Общая длина, мм";
            // 
            // pipelineSpoolCountHeader
            // 
            this.pipelineSpoolCountHeader.LocationFloat = new DevExpress.Utils.PointFloat(194.9405F, 0F);
            this.pipelineSpoolCountHeader.Name = "pipelineSpoolCountHeader";
            this.pipelineSpoolCountHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineSpoolCountHeader.SizeF = new System.Drawing.SizeF(97.47032F, 33.70835F);
            this.pipelineSpoolCountHeader.Text = "Количество катушек";
            // 
            // pipelinePipeCountHeader
            // 
            this.pipelinePipeCountHeader.LocationFloat = new DevExpress.Utils.PointFloat(97.0238F, 0F);
            this.pipelinePipeCountHeader.Name = "pipelinePipeCountHeader";
            this.pipelinePipeCountHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelinePipeCountHeader.SizeF = new System.Drawing.SizeF(97.91673F, 33.70835F);
            this.pipelinePipeCountHeader.Text = "Количество труб";
            // 
            // pipelineJointCountHeader
            // 
            this.pipelineJointCountHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipelineJointCountHeader.Name = "pipelineJointCountHeader";
            this.pipelineJointCountHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelineJointCountHeader.SizeF = new System.Drawing.SizeF(97.0238F, 33.70835F);
            this.pipelineJointCountHeader.Text = "Количество стыков";
            // 
            // calculatedField1
            // 
            this.calculatedField1.Name = "calculatedField1";
            // 
            // tracingBindingSource
            // 
            this.tracingBindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.TracingData);
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.pageFooter.HeightF = 26.04167F;
            this.pageFooter.Name = "pageFooter";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(348.3332F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(401.0417F, 23F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(348.3332F, 23F);
            // 
            // TracingReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.TracingPageHeader,
            this.TracingGroupHeader,
            this.ReportFooter,
            this.pageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1});
            this.DataSource = this.tracingBindingSource;
            this.Margins = new System.Drawing.Printing.Margins(54, 46, 50, 37);
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.tracingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource tracingBindingSource;
        private DevExpress.XtraReports.UI.XRLabel firstPartNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel firstPartTypeXrLabel;
        private DevExpress.XtraReports.UI.XRLabel jointNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel firstLenghtXrLabel;
        private DevExpress.XtraReports.UI.PageHeaderBand TracingPageHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand TracingGroupHeader;
        private DevExpress.XtraReports.UI.XRLabel tracingPageHeaderXrLabel;
        private DevExpress.XtraReports.UI.XRLabel jointNumberHeder;
        private DevExpress.XtraReports.UI.XRLabel lengthHeder;
        private DevExpress.XtraReports.UI.XRLabel partTypeHeder;
        private DevExpress.XtraReports.UI.XRLabel partNumberHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel weldingDateXrLabel;
        private DevExpress.XtraReports.UI.XRLabel secondPartTypeXrLabel;
        private DevExpress.XtraReports.UI.XRLabel secondPartNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel secondLenghtXrLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel pipelineJointCountXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelinePipeCountXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelineSpoolCountXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelineLengthXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelineLengthHeader;
        private DevExpress.XtraReports.UI.XRLabel pipelineSpoolCountHeader;
        private DevExpress.XtraReports.UI.XRLabel pipelinePipeCountHeader;
        private DevExpress.XtraReports.UI.XRLabel pipelineJointCountHeader;
        private DevExpress.XtraReports.UI.XRLabel pipelineComponentCount;
        private DevExpress.XtraReports.UI.XRLabel pipelineComponentHeader;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
    }
}
