namespace Prizm.Main.Forms.Reports.Construction
{
    partial class TracingReporn
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
            this.partNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.partTypeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lenghtXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.CoordinateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.TracingPageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TracingGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.partNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.tracingPageHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.partTypeHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.lengthHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.jointNumberHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.coordinatesHeder = new DevExpress.XtraReports.UI.XRLabel();
            this.tracingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tracingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CoordinateXrLabel,
            this.partTypeXrLabel,
            this.partNumberXrLabel,
            this.jointNumberXrLabel,
            this.lenghtXrLabel});
            this.Detail.HeightF = 29.25002F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // partNumberXrLabel
            // 
            this.partNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PartNumber")});
            this.partNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.partNumberXrLabel.Name = "partNumberXrLabel";
            this.partNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partNumberXrLabel.SizeF = new System.Drawing.SizeF(130.2083F, 26.125F);
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
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // partTypeXrLabel
            // 
            this.partTypeXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PartTypeDescription")});
            this.partTypeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(141.25F, 0F);
            this.partTypeXrLabel.Name = "partTypeXrLabel";
            this.partTypeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partTypeXrLabel.SizeF = new System.Drawing.SizeF(130.2083F, 26.125F);
            // 
            // lenghtXrLabel
            // 
            this.lenghtXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Length")});
            this.lenghtXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(283.9583F, 0F);
            this.lenghtXrLabel.Name = "lenghtXrLabel";
            this.lenghtXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lenghtXrLabel.SizeF = new System.Drawing.SizeF(130.2083F, 26.125F);
            // 
            // jointNumberXrLabel
            // 
            this.jointNumberXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "JointNumber")});
            this.jointNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(425.625F, 0F);
            this.jointNumberXrLabel.Name = "jointNumberXrLabel";
            this.jointNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberXrLabel.SizeF = new System.Drawing.SizeF(130.2084F, 26.125F);
            // 
            // CoordinateXrLabel
            // 
            this.CoordinateXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "JointСoordinates")});
            this.CoordinateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(567.2916F, 0F);
            this.CoordinateXrLabel.Name = "CoordinateXrLabel";
            this.CoordinateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CoordinateXrLabel.SizeF = new System.Drawing.SizeF(130.2084F, 26.125F);
            // 
            // TracingPageHeader
            // 
            this.TracingPageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tracingPageHeaderXrLabel});
            this.TracingPageHeader.HeightF = 50F;
            this.TracingPageHeader.Name = "TracingPageHeader";
            // 
            // TracingGroupHeader
            // 
            this.TracingGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.coordinatesHeder,
            this.jointNumberHeder,
            this.lengthHeder,
            this.partTypeHeder,
            this.partNumberHeader});
            this.TracingGroupHeader.HeightF = 47.91667F;
            this.TracingGroupHeader.Name = "TracingGroupHeader";
            // 
            // partNumberHeader
            // 
            this.partNumberHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.partNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.91667F);
            this.partNumberHeader.Name = "partNumberHeader";
            this.partNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partNumberHeader.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.partNumberHeader.StylePriority.UseFont = false;
            this.partNumberHeader.Text = "Номер элемента";
            // 
            // tracingPageHeaderXrLabel
            // 
            this.tracingPageHeaderXrLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tracingPageHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tracingPageHeaderXrLabel.Name = "tracingPageHeaderXrLabel";
            this.tracingPageHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tracingPageHeaderXrLabel.SizeF = new System.Drawing.SizeF(647.5001F, 50F);
            this.tracingPageHeaderXrLabel.StylePriority.UseFont = false;
            this.tracingPageHeaderXrLabel.Text = "Трассировка трубопровода";
            // 
            // partTypeHeder
            // 
            this.partTypeHeder.LocationFloat = new DevExpress.Utils.PointFloat(141.25F, 14.91667F);
            this.partTypeHeder.Name = "partTypeHeder";
            this.partTypeHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.partTypeHeder.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.partTypeHeder.Text = "Тип элемента";
            // 
            // lengthHeder
            // 
            this.lengthHeder.LocationFloat = new DevExpress.Utils.PointFloat(283.9583F, 14.91667F);
            this.lengthHeder.Name = "lengthHeder";
            this.lengthHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lengthHeder.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.lengthHeder.Text = "Длина";
            // 
            // jointNumberHeder
            // 
            this.jointNumberHeder.LocationFloat = new DevExpress.Utils.PointFloat(425.625F, 14.91667F);
            this.jointNumberHeder.Name = "jointNumberHeder";
            this.jointNumberHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jointNumberHeder.SizeF = new System.Drawing.SizeF(130.2084F, 23F);
            this.jointNumberHeder.Text = "Номер стыка";
            // 
            // coordinatesHeder
            // 
            this.coordinatesHeder.LocationFloat = new DevExpress.Utils.PointFloat(567.2916F, 14.91667F);
            this.coordinatesHeder.Name = "coordinatesHeder";
            this.coordinatesHeder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.coordinatesHeder.SizeF = new System.Drawing.SizeF(130.2084F, 23F);
            this.coordinatesHeder.Text = "Координаты стыка";
            // 
            // tracingBindingSource
            // 
            this.tracingBindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.TracingData);
            // 
            // TracingReporn
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.TracingPageHeader,
            this.TracingGroupHeader});
            this.DataSource = this.tracingBindingSource;
            this.Margins = new System.Drawing.Printing.Margins(54, 46, 50, 100);
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.tracingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource tracingBindingSource;
        private DevExpress.XtraReports.UI.XRLabel partNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel CoordinateXrLabel;
        private DevExpress.XtraReports.UI.XRLabel partTypeXrLabel;
        private DevExpress.XtraReports.UI.XRLabel jointNumberXrLabel;
        private DevExpress.XtraReports.UI.XRLabel lenghtXrLabel;
        private DevExpress.XtraReports.UI.PageHeaderBand TracingPageHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand TracingGroupHeader;
        private DevExpress.XtraReports.UI.XRLabel tracingPageHeaderXrLabel;
        private DevExpress.XtraReports.UI.XRLabel coordinatesHeder;
        private DevExpress.XtraReports.UI.XRLabel jointNumberHeder;
        private DevExpress.XtraReports.UI.XRLabel lengthHeder;
        private DevExpress.XtraReports.UI.XRLabel partTypeHeder;
        private DevExpress.XtraReports.UI.XRLabel partNumberHeader;
    }
}
