namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    partial class WeldDateXtraReport
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.dateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.dateHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.weldReportByDateHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.jointNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartLengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartLengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.numberOfPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.dateTimePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dateXrLabel,
            this.secondPartNumberXrLabel,
            this.firstNumberXrLabel,
            this.jointNumberXrLabel,
            this.secondPartLengthXrLabel,
            this.firstPartLengthXrLabel});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("JointNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dateXrLabel
            // 
            this.dateXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Date")});
            this.dateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateXrLabel.Name = "dateXrLabel";
            this.dateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateXrLabel.SizeF = new System.Drawing.SizeF(96.45831F, 23F);
            // 
            // secondPartNumberXrLabel
            // 
            this.secondPartNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartNumber")});
            this.secondPartNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(307.9166F, 0F);
            this.secondPartNumberXrLabel.Name = "secondPartNumberXrLabel";
            this.secondPartNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartNumberXrLabel.SizeF = new System.Drawing.SizeF(114.0001F, 23F);
            // 
            // firstNumberXrLabel
            // 
            this.firstNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FipstPartNumber")});
            this.firstNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(201.6666F, 0F);
            this.firstNumberXrLabel.Name = "firstNumberXrLabel";
            this.firstNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstNumberXrLabel.SizeF = new System.Drawing.SizeF(106.25F, 23F);
            // 
            // jointNumberXrLabel
            // 
            this.jointNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "JointNumber")});
            this.jointNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(96.45827F, 0F);
            this.jointNumberXrLabel.Name = "jointNumberXrLabel";
            this.jointNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberXrLabel.SizeF = new System.Drawing.SizeF(105.2084F, 23F);
            // 
            // secondPartLengthXrLabel
            // 
            this.secondPartLengthXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartLength")});
            this.secondPartLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(531.2917F, 0F);
            this.secondPartLengthXrLabel.Name = "secondPartLengthXrLabel";
            this.secondPartLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartLengthXrLabel.SizeF = new System.Drawing.SizeF(118.7083F, 23F);
            // 
            // firstPartLengthXrLabel
            // 
            this.firstPartLengthXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FipstPartLength")});
            this.firstPartLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(421.9167F, 0F);
            this.firstPartLengthXrLabel.Name = "firstPartLengthXrLabel";
            this.firstPartLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartLengthXrLabel.SizeF = new System.Drawing.SizeF(109.375F, 23F);
            // 
            // dateHeader
            // 
            this.dateHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateHeader.SizeF = new System.Drawing.SizeF(96.45832F, 34.2083F);
            this.dateHeader.Text = "Дата сварки";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 45F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "Сформирован: {0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(307.9166F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(342.0834F, 17.79167F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // weldReportByDateHeader
            // 
            this.weldReportByDateHeader.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weldReportByDateHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.79167F);
            this.weldReportByDateHeader.Name = "weldReportByDateHeader";
            this.weldReportByDateHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.weldReportByDateHeader.SizeF = new System.Drawing.SizeF(650.0001F, 43.83334F);
            this.weldReportByDateHeader.StylePriority.UseFont = false;
            this.weldReportByDateHeader.StylePriority.UseTextAlignment = false;
            this.weldReportByDateHeader.Text = "Отчет по сварке (по дате)";
            this.weldReportByDateHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 36F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // jointNumberHeader
            // 
            this.jointNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(96.45824F, 0F);
            this.jointNumberHeader.Name = "jointNumberHeader";
            this.jointNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberHeader.SizeF = new System.Drawing.SizeF(105.2083F, 34.2083F);
            this.jointNumberHeader.Text = "Номер стыка";
            // 
            // firstPartNumberHeader
            // 
            this.firstPartNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(201.6665F, 0F);
            this.firstPartNumberHeader.Name = "firstPartNumberHeader";
            this.firstPartNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartNumberHeader.SizeF = new System.Drawing.SizeF(106.25F, 34.2083F);
            this.firstPartNumberHeader.Text = "Номер первой части";
            // 
            // secondPartNumberHeader
            // 
            this.secondPartNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(307.9166F, 0F);
            this.secondPartNumberHeader.Name = "secondPartNumberHeader";
            this.secondPartNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartNumberHeader.SizeF = new System.Drawing.SizeF(114.0001F, 34.2083F);
            this.secondPartNumberHeader.Text = "Номер второй части";
            // 
            // firstPartLengthHeader
            // 
            this.firstPartLengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(421.9167F, 0F);
            this.firstPartLengthHeader.Name = "firstPartLengthHeader";
            this.firstPartLengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartLengthHeader.SizeF = new System.Drawing.SizeF(109.375F, 34.2083F);
            this.firstPartLengthHeader.Text = "Длина первой части";
            // 
            // secondPartLengthHeader
            // 
            this.secondPartLengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(531.2916F, 0F);
            this.secondPartLengthHeader.Name = "secondPartLengthHeader";
            this.secondPartLengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartLengthHeader.SizeF = new System.Drawing.SizeF(118.7083F, 34.2083F);
            this.secondPartLengthHeader.Text = "Длина второй части";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.weldReportByDateHeader,
            this.reportDateTimeInfo});
            this.ReportHeader.HeightF = 61.62501F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.numberOfPageInfo,
            this.dateTimePageInfo});
            this.pageFooter.HeightF = 23.00002F;
            this.pageFooter.Name = "pageFooter";
            // 
            // numberOfPageInfo
            // 
            this.numberOfPageInfo.Format = "{0} / {1}";
            this.numberOfPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(307.9166F, 0F);
            this.numberOfPageInfo.Name = "numberOfPageInfo";
            this.numberOfPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberOfPageInfo.SizeF = new System.Drawing.SizeF(342.0834F, 23F);
            this.numberOfPageInfo.StylePriority.UseTextAlignment = false;
            this.numberOfPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // dateTimePageInfo
            // 
            this.dateTimePageInfo.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.dateTimePageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateTimePageInfo.Name = "dateTimePageInfo";
            this.dateTimePageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateTimePageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.dateTimePageInfo.SizeF = new System.Drawing.SizeF(307.9166F, 23F);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.WeldDateReports.WeldDateReportData);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.secondPartLengthHeader,
            this.firstPartLengthHeader,
            this.secondPartNumberHeader,
            this.firstPartNumberHeader,
            this.jointNumberHeader,
            this.dateHeader});
            this.PageHeader.HeightF = 34.375F;
            this.PageHeader.Name = "PageHeader";
            // 
            // WeldDateXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.pageFooter,
            this.PageHeader});
            this.DataSource = this.bindingSource;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 45, 36);
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel dateHeader;
        private DevExpress.XtraReports.UI.XRLabel jointNumberHeader;
        private DevExpress.XtraReports.UI.XRLabel dateXrLabel;
        private DevExpress.XtraReports.UI.XRLabel firstPartLengthXrLabel;
        private DevExpress.XtraReports.UI.XRLabel secondPartNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel firstNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel jointNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel secondPartLengthXrLabel;
        private DevExpress.XtraReports.UI.XRLabel firstPartNumberHeader;
        private DevExpress.XtraReports.UI.XRLabel secondPartNumberHeader;
        private DevExpress.XtraReports.UI.XRLabel firstPartLengthHeader;
        private DevExpress.XtraReports.UI.XRLabel secondPartLengthHeader;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraReports.UI.XRLabel weldReportByDateHeader;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo numberOfPageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo dateTimePageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    }
}
