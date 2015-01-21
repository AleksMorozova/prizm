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
            this.firstPartLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.firstNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.dateHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.weldReportByDateHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.jointNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstPartLengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.secondPartLengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dateXrLabel,
            this.firstPartLengthXrLabel,
            this.secondPartNumberXrLabel,
            this.firstNumberXrLabel,
            this.jointNumberXrLabel,
            this.secondPartLengthXrLabel});
            this.Detail.HeightF = 33.33333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dateXrLabel
            // 
            this.dateXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Date")});
            this.dateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 0F);
            this.dateXrLabel.Name = "dateXrLabel";
            this.dateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateXrLabel.SizeF = new System.Drawing.SizeF(86.45834F, 23F);
            // 
            // firstPartLengthXrLabel
            // 
            this.firstPartLengthXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FipstPartLength")});
            this.firstPartLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(444.8334F, 0.333341F);
            this.firstPartLengthXrLabel.Name = "firstPartLengthXrLabel";
            this.firstPartLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartLengthXrLabel.SizeF = new System.Drawing.SizeF(86.45837F, 23F);
            // 
            // secondPartNumberXrLabel
            // 
            this.secondPartNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartNumber")});
            this.secondPartNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(336.1251F, 0.333341F);
            this.secondPartNumberXrLabel.Name = "secondPartNumberXrLabel";
            this.secondPartNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartNumberXrLabel.SizeF = new System.Drawing.SizeF(86.45825F, 23F);
            // 
            // firstNumberXrLabel
            // 
            this.firstNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FipstPartNumber")});
            this.firstNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(227.4167F, 0F);
            this.firstNumberXrLabel.Name = "firstNumberXrLabel";
            this.firstNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstNumberXrLabel.SizeF = new System.Drawing.SizeF(86.45833F, 23F);
            // 
            // jointNumberXrLabel
            // 
            this.jointNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "JointNumber")});
            this.jointNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(118.7083F, 0F);
            this.jointNumberXrLabel.Name = "jointNumberXrLabel";
            this.jointNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberXrLabel.SizeF = new System.Drawing.SizeF(86.45837F, 23F);
            // 
            // secondPartLengthXrLabel
            // 
            this.secondPartLengthXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondPartLength")});
            this.secondPartLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(553.5417F, 0F);
            this.secondPartLengthXrLabel.Name = "secondPartLengthXrLabel";
            this.secondPartLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartLengthXrLabel.SizeF = new System.Drawing.SizeF(86.45831F, 23F);
            // 
            // dateHeader
            // 
            this.dateHeader.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 12.58335F);
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateHeader.SizeF = new System.Drawing.SizeF(86.45833F, 34.2083F);
            this.dateHeader.Text = "Дата сварки";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.weldReportByDateHeader});
            this.TopMargin.HeightF = 75F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // weldReportByDateHeader
            // 
            this.weldReportByDateHeader.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weldReportByDateHeader.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 21.16666F);
            this.weldReportByDateHeader.Name = "weldReportByDateHeader";
            this.weldReportByDateHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.weldReportByDateHeader.SizeF = new System.Drawing.SizeF(630F, 43.83334F);
            this.weldReportByDateHeader.StylePriority.UseFont = false;
            this.weldReportByDateHeader.Text = "Отчет по сварке (по дате)";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 72.91666F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // jointNumberHeader
            // 
            this.jointNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(118.7083F, 12.58335F);
            this.jointNumberHeader.Name = "jointNumberHeader";
            this.jointNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberHeader.SizeF = new System.Drawing.SizeF(86.45834F, 34.2083F);
            this.jointNumberHeader.Text = "Номер стыка";
            // 
            // firstPartNumberHeader
            // 
            this.firstPartNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(227.4167F, 12.58335F);
            this.firstPartNumberHeader.Name = "firstPartNumberHeader";
            this.firstPartNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartNumberHeader.SizeF = new System.Drawing.SizeF(86.45833F, 34.2083F);
            this.firstPartNumberHeader.Text = "Номер первой части";
            // 
            // secondPartNumberHeader
            // 
            this.secondPartNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(336.125F, 12.58335F);
            this.secondPartNumberHeader.Name = "secondPartNumberHeader";
            this.secondPartNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartNumberHeader.SizeF = new System.Drawing.SizeF(86.45831F, 34.2083F);
            this.secondPartNumberHeader.Text = "Номер второй части";
            // 
            // firstPartLengthHeader
            // 
            this.firstPartLengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(444.8334F, 12.58335F);
            this.firstPartLengthHeader.Name = "firstPartLengthHeader";
            this.firstPartLengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstPartLengthHeader.SizeF = new System.Drawing.SizeF(86.45831F, 34.2083F);
            this.firstPartLengthHeader.Text = "Длина первой части";
            // 
            // secondPartLengthHeader
            // 
            this.secondPartLengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(553.5417F, 12.58333F);
            this.secondPartLengthHeader.Name = "secondPartLengthHeader";
            this.secondPartLengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondPartLengthHeader.SizeF = new System.Drawing.SizeF(86.45837F, 34.2083F);
            this.secondPartLengthHeader.Text = "Длина второй части";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 12.58334F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.79165F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(650F, 12.58334F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.dateHeader,
            this.secondPartLengthHeader,
            this.firstPartNumberHeader,
            this.secondPartNumberHeader,
            this.firstPartLengthHeader,
            this.jointNumberHeader,
            this.xrLine1});
            this.ReportHeader.HeightF = 59.375F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.WeldDateReports.WeldDateReportData);
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3});
            this.ReportFooter.HeightF = 25F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(650F, 12.58334F);
            // 
            // WeldDateXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.DataSource = this.bindingSource;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 75, 73);
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
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraReports.UI.XRLabel weldReportByDateHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
    }
}
