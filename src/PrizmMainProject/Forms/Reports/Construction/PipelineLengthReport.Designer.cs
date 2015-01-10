namespace Prizm.Main.Forms.Reports.Construction
{
    partial class PipelineLengthReport
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PipelineLengthHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PipelineLengthGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.pipelinePartCount = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineLength = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineJointCount = new DevExpress.XtraReports.UI.XRLabel();
            this.coordinatesFrom = new DevExpress.XtraReports.UI.XRLabel();
            this.coordinatesTo = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineLengthHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelinePartCountXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineLengthXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipelineJointCountXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.coordinatesFromXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.coordinatesToXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.coordinatesToXrLabel,
            this.coordinatesFromXrLabel,
            this.pipelineJointCountXrLabel,
            this.pipelineLengthXrLabel,
            this.pipelinePartCountXrLabel});
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PipelineLengthHeader
            // 
            this.PipelineLengthHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pipelineLengthHeaderLabel});
            this.PipelineLengthHeader.HeightF = 55.20833F;
            this.PipelineLengthHeader.Name = "PipelineLengthHeader";
            // 
            // PipelineLengthGroupHeader
            // 
            this.PipelineLengthGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.coordinatesTo,
            this.coordinatesFrom,
            this.pipelineJointCount,
            this.pipelineLength,
            this.pipelinePartCount});
            this.PipelineLengthGroupHeader.HeightF = 51.04167F;
            this.PipelineLengthGroupHeader.Name = "PipelineLengthGroupHeader";
            // 
            // pipelinePartCount
            // 
            this.pipelinePartCount.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.pipelinePartCount.Name = "pipelinePartCount";
            this.pipelinePartCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipelinePartCount.SizeF = new System.Drawing.SizeF(100F, 34.16666F);
            this.pipelinePartCount.Text = "Колличество элементов";
            // 
            // pipelineLength
            // 
            this.pipelineLength.LocationFloat = new DevExpress.Utils.PointFloat(136.4583F, 10.00001F);
            this.pipelineLength.Name = "pipelineLength";
            this.pipelineLength.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelineLength.SizeF = new System.Drawing.SizeF(100F, 34.16666F);
            this.pipelineLength.Text = "Длина";
            // 
            // pipelineJointCount
            // 
            this.pipelineJointCount.LocationFloat = new DevExpress.Utils.PointFloat(262.5F, 10.00001F);
            this.pipelineJointCount.Name = "pipelineJointCount";
            this.pipelineJointCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelineJointCount.SizeF = new System.Drawing.SizeF(100F, 34.16666F);
            this.pipelineJointCount.Text = "Колличество стыков";
            // 
            // coordinatesFrom
            // 
            this.coordinatesFrom.LocationFloat = new DevExpress.Utils.PointFloat(388.5417F, 10.00001F);
            this.coordinatesFrom.Name = "coordinatesFrom";
            this.coordinatesFrom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.coordinatesFrom.SizeF = new System.Drawing.SizeF(100F, 34.16666F);
            this.coordinatesFrom.Text = "Координаты начала";
            // 
            // coordinatesTo
            // 
            this.coordinatesTo.LocationFloat = new DevExpress.Utils.PointFloat(511.4583F, 10.00001F);
            this.coordinatesTo.Name = "coordinatesTo";
            this.coordinatesTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.coordinatesTo.SizeF = new System.Drawing.SizeF(100F, 34.16666F);
            this.coordinatesTo.Text = "Координаты конца";
            // 
            // pipelineLengthHeaderLabel
            // 
            this.pipelineLengthHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pipelineLengthHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.pipelineLengthHeaderLabel.Name = "pipelineLengthHeaderLabel";
            this.pipelineLengthHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelineLengthHeaderLabel.SizeF = new System.Drawing.SizeF(601.4583F, 39.66667F);
            this.pipelineLengthHeaderLabel.StylePriority.UseFont = false;
            this.pipelineLengthHeaderLabel.Text = "Длинна участка трубопровода";
            // 
            // pipelinePartCountXrLabel
            // 
            this.pipelinePartCountXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.pipelinePartCountXrLabel.Name = "pipelinePartCountXrLabel";
            this.pipelinePartCountXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelinePartCountXrLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // pipelineLengthXrLabel
            // 
            this.pipelineLengthXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(136.4583F, 10.00001F);
            this.pipelineLengthXrLabel.Name = "pipelineLengthXrLabel";
            this.pipelineLengthXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelineLengthXrLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // pipelineJointCountXrLabel
            // 
            this.pipelineJointCountXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(262.5F, 10.00001F);
            this.pipelineJointCountXrLabel.Name = "pipelineJointCountXrLabel";
            this.pipelineJointCountXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pipelineJointCountXrLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // coordinatesFromXrLabel
            // 
            this.coordinatesFromXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(388.5417F, 10.00001F);
            this.coordinatesFromXrLabel.Name = "coordinatesFromXrLabel";
            this.coordinatesFromXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.coordinatesFromXrLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // coordinatesToXrLabel
            // 
            this.coordinatesToXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(511.4583F, 10.00001F);
            this.coordinatesToXrLabel.Name = "coordinatesToXrLabel";
            this.coordinatesToXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.coordinatesToXrLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // PipelineLengthReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PipelineLengthHeader,
            this.PipelineLengthGroupHeader});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand PipelineLengthHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand PipelineLengthGroupHeader;
        private DevExpress.XtraReports.UI.XRLabel pipelinePartCount;
        private DevExpress.XtraReports.UI.XRLabel coordinatesFrom;
        private DevExpress.XtraReports.UI.XRLabel pipelineJointCount;
        private DevExpress.XtraReports.UI.XRLabel pipelineLength;
        private DevExpress.XtraReports.UI.XRLabel coordinatesTo;
        private DevExpress.XtraReports.UI.XRLabel pipelineLengthHeaderLabel;
        private DevExpress.XtraReports.UI.XRLabel coordinatesToXrLabel;
        private DevExpress.XtraReports.UI.XRLabel coordinatesFromXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelineJointCountXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelineLengthXrLabel;
        private DevExpress.XtraReports.UI.XRLabel pipelinePartCountXrLabel;
    }
}
