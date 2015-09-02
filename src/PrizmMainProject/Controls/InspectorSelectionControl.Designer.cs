namespace Prizm.Main.Controls
{
    partial class InspectorSelectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inspectorsGridControl = new DevExpress.XtraGrid.GridControl();
            this.inspectorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inspectorsGridControl
            // 
            this.inspectorsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectorsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectorsGridControl.Location = new System.Drawing.Point(0, 0);
            this.inspectorsGridControl.MainView = this.inspectorsGridView;
            this.inspectorsGridControl.Name = "inspectorsGridControl";
            this.inspectorsGridControl.Size = new System.Drawing.Size(372, 193);
            this.inspectorsGridControl.TabIndex = 0;
            this.inspectorsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectorsGridView});
            // 
            // inspectorsGridView
            // 
            this.inspectorsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colMiddleName});
            this.inspectorsGridView.GridControl = this.inspectorsGridControl;
            this.inspectorsGridView.Name = "inspectorsGridView";
            this.inspectorsGridView.OptionsBehavior.Editable = false;
            this.inspectorsGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectorsGridView.OptionsNavigation.UseTabKey = false;
            this.inspectorsGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.inspectorsGridView.OptionsSelection.MultiSelect = true;
            this.inspectorsGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.inspectorsGridView.OptionsView.ShowGroupPanel = false;
            this.inspectorsGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.inspectorsGridView_RowCellStyle);
            this.inspectorsGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.inspectorsGridView_SelectionChanged);
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.FieldName = "Name.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.FieldName = "Name.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.FieldName = "Name.MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 2;
            // 
            // InspectorSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inspectorsGridControl);
            this.Name = "InspectorSelectionControl";
            this.Size = new System.Drawing.Size(372, 193);
            this.Load += new System.EventHandler(this.InspectorSelectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl inspectorsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectorsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
    }
}
