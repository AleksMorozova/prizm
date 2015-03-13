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
            this.isExportColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryIsExportСolumnTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.workstationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.historyLayout = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.historyGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsExportСolumnTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyLayout)).BeginInit();
            this.historyLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.Location = new System.Drawing.Point(12, 12);
            this.gridControlHistory.MainView = this.gridViewHistory;
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryIsExportСolumnTextEdit});
            this.gridControlHistory.Size = new System.Drawing.Size(851, 474);
            this.gridControlHistory.TabIndex = 0;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistory});
            // 
            // gridViewHistory
            // 
            this.gridViewHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.portionIdColumn,
            this.portionDateColumn,
            this.isExportColumn,
            this.workstationColumn});
            this.gridViewHistory.GridControl = this.gridControlHistory;
            this.gridViewHistory.Name = "gridViewHistory";
            this.gridViewHistory.OptionsBehavior.Editable = false;
            this.gridViewHistory.OptionsView.ShowGroupPanel = false;
            this.gridViewHistory.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewHistory_CustomColumnDisplayText);
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
            // isExportColumn
            // 
            this.isExportColumn.Caption = "Экспорт/Импорт";
            this.isExportColumn.ColumnEdit = this.repositoryIsExportСolumnTextEdit;
            this.isExportColumn.FieldName = "IsExport";
            this.isExportColumn.Name = "isExportColumn";
            this.isExportColumn.Visible = true;
            this.isExportColumn.VisibleIndex = 2;
            // 
            // repositoryIsExportСolumnTextEdit
            // 
            this.repositoryIsExportСolumnTextEdit.AutoHeight = false;
            this.repositoryIsExportСolumnTextEdit.Name = "repositoryIsExportСolumnTextEdit";
            // 
            // workstationColumn
            // 
            this.workstationColumn.Caption = "Рабочая станция";
            this.workstationColumn.FieldName = "Project.WorkstationType";
            this.workstationColumn.Name = "workstationColumn";
            this.workstationColumn.Visible = true;
            this.workstationColumn.VisibleIndex = 3;
            // 
            // historyLayout
            // 
            this.historyLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyLayout.Controls.Add(this.gridControlHistory);
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
            this.historyLayout.Size = new System.Drawing.Size(875, 498);
            this.historyLayout.TabIndex = 2;
            this.historyLayout.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.historyGridLayout});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(875, 498);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // historyGridLayout
            // 
            this.historyGridLayout.Control = this.gridControlHistory;
            this.historyGridLayout.CustomizationFormText = "historyGridLayout";
            this.historyGridLayout.Location = new System.Drawing.Point(0, 0);
            this.historyGridLayout.Name = "historyGridLayout";
            this.historyGridLayout.Size = new System.Drawing.Size(855, 478);
            this.historyGridLayout.Text = "historyGridLayout";
            this.historyGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.historyGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.historyGridLayout.TextVisible = false;
            // 
            // HistoryExportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 516);
            this.Controls.Add(this.historyLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryExportImport";
            this.Text = "История экспорта / импорта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryExportImport_FormClosed);
            this.Load += new System.EventHandler(this.HistoryExportImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsExportСolumnTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyLayout)).EndInit();
            this.historyLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistory;
        private DevExpress.XtraGrid.Columns.GridColumn portionIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn portionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isExportColumn;
        private DevExpress.XtraLayout.LayoutControl historyLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem historyGridLayout;
        private DevExpress.XtraGrid.Columns.GridColumn workstationColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryIsExportСolumnTextEdit;
    }
}