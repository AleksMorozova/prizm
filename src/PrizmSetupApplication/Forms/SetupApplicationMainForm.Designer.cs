namespace PrizmSetupApplication.Forms
{
    partial class SetupApplicationMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDesign = new DevExpress.XtraEditors.LabelControl();
            this.lblClient = new DevExpress.XtraEditors.LabelControl();
            this.txtDesign = new DevExpress.XtraEditors.TextEdit();
            this.txtClient = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlPlate = new DevExpress.XtraGrid.GridControl();
            this.gridViewPlate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColPlateManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPlate = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPipe = new DevExpress.XtraGrid.GridControl();
            this.gridViewPipe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdColPipeManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdColPipeSizeGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SizeGradeItemCheckedBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.lblPipe = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGradeItemCheckedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesign
            // 
            this.lblDesign.Location = new System.Drawing.Point(29, 61);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(36, 13);
            this.lblDesign.TabIndex = 7;
            this.lblDesign.Text = "Design:";
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(29, 23);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(31, 13);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Client:";
            // 
            // txtDesign
            // 
            this.txtDesign.Location = new System.Drawing.Point(117, 20);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(251, 20);
            this.txtDesign.TabIndex = 5;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(117, 58);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(251, 20);
            this.txtClient.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainer.Location = new System.Drawing.Point(29, 99);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.gridControlPlate);
            this.splitContainer.Panel1.Controls.Add(this.lblPlate);
            this.splitContainer.Panel1.Text = "PlatePanel";
            this.splitContainer.Panel2.Controls.Add(this.gridControlPipe);
            this.splitContainer.Panel2.Controls.Add(this.lblPipe);
            this.splitContainer.Panel2.Text = "PipePanel";
            this.splitContainer.Size = new System.Drawing.Size(627, 300);
            this.splitContainer.SplitterPosition = 314;
            this.splitContainer.TabIndex = 8;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // gridControlPlate
            // 
            this.gridControlPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPlate.Location = new System.Drawing.Point(3, 57);
            this.gridControlPlate.MainView = this.gridViewPlate;
            this.gridControlPlate.Name = "gridControlPlate";
            this.gridControlPlate.Size = new System.Drawing.Size(300, 235);
            this.gridControlPlate.TabIndex = 10;
            this.gridControlPlate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPlate});
            // 
            // gridViewPlate
            // 
            this.gridViewPlate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColPlateManufacturer});
            this.gridViewPlate.GridControl = this.gridControlPlate;
            this.gridViewPlate.Name = "gridViewPlate";
            // 
            // GrdColPlateManufacturer
            // 
            this.GrdColPlateManufacturer.Caption = "Manufacture";
            this.GrdColPlateManufacturer.Name = "GrdColPlateManufacturer";
            this.GrdColPlateManufacturer.Visible = true;
            this.GrdColPlateManufacturer.VisibleIndex = 0;
            // 
            // lblPlate
            // 
            this.lblPlate.Location = new System.Drawing.Point(3, 20);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(97, 13);
            this.lblPlate.TabIndex = 9;
            this.lblPlate.Text = "Plate manufacturers";
            // 
            // gridControlPipe
            // 
            this.gridControlPipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPipe.Location = new System.Drawing.Point(8, 57);
            this.gridControlPipe.MainView = this.gridViewPipe;
            this.gridControlPipe.Name = "gridControlPipe";
            this.gridControlPipe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SizeGradeItemCheckedBox});
            this.gridControlPipe.Size = new System.Drawing.Size(299, 235);
            this.gridControlPipe.TabIndex = 11;
            this.gridControlPipe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPipe});
            // 
            // gridViewPipe
            // 
            this.gridViewPipe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdColPipeManufacturer,
            this.GrdColPipeSizeGrade});
            this.gridViewPipe.GridControl = this.gridControlPipe;
            this.gridViewPipe.Name = "gridViewPipe";
            // 
            // GrdColPipeManufacturer
            // 
            this.GrdColPipeManufacturer.Caption = "Manufacturer";
            this.GrdColPipeManufacturer.Name = "GrdColPipeManufacturer";
            this.GrdColPipeManufacturer.Visible = true;
            this.GrdColPipeManufacturer.VisibleIndex = 0;
            // 
            // GrdColPipeSizeGrade
            // 
            this.GrdColPipeSizeGrade.Caption = "Size Grade";
            this.GrdColPipeSizeGrade.ColumnEdit = this.SizeGradeItemCheckedBox;
            this.GrdColPipeSizeGrade.Name = "GrdColPipeSizeGrade";
            this.GrdColPipeSizeGrade.Visible = true;
            this.GrdColPipeSizeGrade.VisibleIndex = 1;
            // 
            // SizeGradeItemCheckedBox
            // 
            this.SizeGradeItemCheckedBox.AutoHeight = false;
            this.SizeGradeItemCheckedBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SizeGradeItemCheckedBox.Name = "SizeGradeItemCheckedBox";
            // 
            // lblPipe
            // 
            this.lblPipe.Cursor = System.Windows.Forms.Cursors.No;
            this.lblPipe.Location = new System.Drawing.Point(14, 20);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(93, 13);
            this.lblPipe.TabIndex = 10;
            this.lblPipe.Text = "Pipe manufacturers";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(580, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Close";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(469, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Export";
            // 
            // SetupApplicationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtClient);
            this.Name = "SetupApplicationMainForm";
            this.Text = "SetupApplicationMain";
            ((System.ComponentModel.ISupportInitialize)(this.txtDesign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGradeItemCheckedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDesign;
        private DevExpress.XtraEditors.LabelControl lblClient;
        private DevExpress.XtraEditors.TextEdit txtDesign;
        private DevExpress.XtraEditors.TextEdit txtClient;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraGrid.GridControl gridControlPlate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPlate;
        private DevExpress.XtraEditors.LabelControl lblPlate;
        private DevExpress.XtraEditors.LabelControl lblPipe;
        private DevExpress.XtraGrid.GridControl gridControlPipe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPipe;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColPlateManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColPipeManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn GrdColPipeSizeGrade;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit SizeGradeItemCheckedBox;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}