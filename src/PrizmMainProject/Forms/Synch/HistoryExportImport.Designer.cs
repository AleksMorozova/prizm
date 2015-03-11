namespace Prizm.Main.Forms.Synch
{
    partial class HistoryExportImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryExportImport));
            this.gridControlHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.portionIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.portionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isExportСolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReexport = new DevExpress.XtraEditors.SimpleButton();
            this.historyLayout = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.historyGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnReexportLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underBtnEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.underGridEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyLayout)).BeginInit();
            this.historyLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReexportLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underBtnEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGridEmptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.Location = new System.Drawing.Point(12, 12);
            this.gridControlHistory.MainView = this.gridViewHistory;
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.Size = new System.Drawing.Size(632, 434);
            this.gridControlHistory.TabIndex = 0;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistory});
            // 
            // gridViewHistory
            // 
            this.gridViewHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.portionIdColumn,
            this.portionDateColumn,
            this.isExportСolumn});
            this.gridViewHistory.GridControl = this.gridControlHistory;
            this.gridViewHistory.Name = "gridViewHistory";
            this.gridViewHistory.OptionsBehavior.Editable = false;
            this.gridViewHistory.OptionsView.ShowGroupPanel = false;
            // 
            // portionIdColumn
            // 
            this.portionIdColumn.Caption = "ID порции";
            this.portionIdColumn.FieldName = "Id";
            this.portionIdColumn.Name = "portionIdColumn";
            this.portionIdColumn.Visible = true;
            this.portionIdColumn.VisibleIndex = 0;
            // 
            // portionDateColumn
            // 
            this.portionDateColumn.Caption = "Дата экспорта/импорта";
            this.portionDateColumn.FieldName = "ExportDateTime";
            this.portionDateColumn.Name = "portionDateColumn";
            this.portionDateColumn.Visible = true;
            this.portionDateColumn.VisibleIndex = 1;
            // 
            // isExportСolumn
            // 
            this.isExportСolumn.Caption = "Экспорт/Импорт";
            this.isExportСolumn.FieldName = "IsExport";
            this.isExportСolumn.Name = "isExportСolumn";
            this.isExportСolumn.Visible = true;
            this.isExportСolumn.VisibleIndex = 2;
            // 
            // btnReexport
            // 
            this.btnReexport.Image = ((System.Drawing.Image)(resources.GetObject("btnReexport.Image")));
            this.btnReexport.Location = new System.Drawing.Point(498, 464);
            this.btnReexport.Name = "btnReexport";
            this.btnReexport.Size = new System.Drawing.Size(146, 22);
            this.btnReexport.StyleController = this.historyLayout;
            this.btnReexport.TabIndex = 1;
            this.btnReexport.Text = "&Переэкспортировать";
            this.btnReexport.Click += new System.EventHandler(this.btnReexport_Click);
            // 
            // historyLayout
            // 
            this.historyLayout.Controls.Add(this.gridControlHistory);
            this.historyLayout.Controls.Add(this.btnReexport);
            this.historyLayout.Location = new System.Drawing.Point(12, 12);
            this.historyLayout.Name = "historyLayout";
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.historyLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.historyLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.historyLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.historyLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.historyLayout.Root = this.Root;
            this.historyLayout.Size = new System.Drawing.Size(656, 498);
            this.historyLayout.TabIndex = 2;
            this.historyLayout.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.historyGridLayout,
            this.btnReexportLayout,
            this.underBtnEmptySpace,
            this.underGridEmptySpaceItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(656, 498);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // historyGridLayout
            // 
            this.historyGridLayout.Control = this.gridControlHistory;
            this.historyGridLayout.CustomizationFormText = "historyGridLayout";
            this.historyGridLayout.Location = new System.Drawing.Point(0, 0);
            this.historyGridLayout.Name = "historyGridLayout";
            this.historyGridLayout.Size = new System.Drawing.Size(636, 438);
            this.historyGridLayout.Text = "historyGridLayout";
            this.historyGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.historyGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.historyGridLayout.TextVisible = false;
            // 
            // btnReexportLayout
            // 
            this.btnReexportLayout.Control = this.btnReexport;
            this.btnReexportLayout.CustomizationFormText = "btnReexportLayout";
            this.btnReexportLayout.Location = new System.Drawing.Point(486, 452);
            this.btnReexportLayout.Name = "btnReexportLayout";
            this.btnReexportLayout.Size = new System.Drawing.Size(150, 26);
            this.btnReexportLayout.Text = "btnReexportLayout";
            this.btnReexportLayout.TextSize = new System.Drawing.Size(0, 0);
            this.btnReexportLayout.TextVisible = false;
            // 
            // underBtnEmptySpace
            // 
            this.underBtnEmptySpace.AllowHotTrack = false;
            this.underBtnEmptySpace.CustomizationFormText = "underBtnEmptySpace";
            this.underBtnEmptySpace.Location = new System.Drawing.Point(0, 452);
            this.underBtnEmptySpace.Name = "underBtnEmptySpace";
            this.underBtnEmptySpace.Size = new System.Drawing.Size(486, 26);
            this.underBtnEmptySpace.Text = "underBtnEmptySpace";
            this.underBtnEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // underGridEmptySpaceItem
            // 
            this.underGridEmptySpaceItem.AllowHotTrack = false;
            this.underGridEmptySpaceItem.CustomizationFormText = "underGridEmptySpaceItem";
            this.underGridEmptySpaceItem.Location = new System.Drawing.Point(0, 438);
            this.underGridEmptySpaceItem.Name = "underGridEmptySpaceItem";
            this.underGridEmptySpaceItem.Size = new System.Drawing.Size(636, 14);
            this.underGridEmptySpaceItem.Text = "underGridEmptySpaceItem";
            this.underGridEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // HistoryExportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 516);
            this.Controls.Add(this.historyLayout);
            this.Name = "HistoryExportImport";
            this.Text = "HistoryExportImport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryExportImport_FormClosed);
            this.Load += new System.EventHandler(this.HistoryExportImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyLayout)).EndInit();
            this.historyLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReexportLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underBtnEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGridEmptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistory;
        private DevExpress.XtraGrid.Columns.GridColumn portionIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn portionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isExportСolumn;
        private DevExpress.XtraEditors.SimpleButton btnReexport;
        private DevExpress.XtraLayout.LayoutControl historyLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem historyGridLayout;
        private DevExpress.XtraLayout.LayoutControlItem btnReexportLayout;
        private DevExpress.XtraLayout.EmptySpaceItem underBtnEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem underGridEmptySpaceItem;
    }
}