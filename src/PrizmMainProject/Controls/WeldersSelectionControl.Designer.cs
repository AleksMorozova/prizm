namespace Prizm.Main.Controls
{
   partial class WeldersSelectionControl
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
            this.gridControlWelders = new DevExpress.XtraGrid.GridControl();
            this.gridViewWelders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlWelders
            // 
            this.gridControlWelders.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlWelders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWelders.Location = new System.Drawing.Point(0, 0);
            this.gridControlWelders.MainView = this.gridViewWelders;
            this.gridControlWelders.MaximumSize = new System.Drawing.Size(600, 210);
            this.gridControlWelders.Name = "gridControlWelders";
            this.gridControlWelders.Size = new System.Drawing.Size(600, 210);
            this.gridControlWelders.TabIndex = 0;
            this.gridControlWelders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWelders});
            // 
            // gridViewWelders
            // 
            this.gridViewWelders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colMiddleName});
            this.gridViewWelders.GridControl = this.gridControlWelders;
            this.gridViewWelders.Name = "gridViewWelders";
            this.gridViewWelders.OptionsBehavior.Editable = false;
            this.gridViewWelders.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridViewWelders.OptionsSelection.MultiSelect = true;
            this.gridViewWelders.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewWelders.OptionsView.ShowGroupPanel = false;
            this.gridViewWelders.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewWelders_RowCellStyle);
            this.gridViewWelders.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewWelders_SelectionChanged);
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.FieldName = "Name.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.ReadOnly = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.FieldName = "Name.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.ReadOnly = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.FieldName = "Name.MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.OptionsColumn.ReadOnly = true;
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            // 
            // WeldersSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWelders);
            this.Name = "WeldersSelectionControl";
            this.Size = new System.Drawing.Size(600, 210);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraGrid.GridControl gridControlWelders;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewWelders;
      private DevExpress.XtraGrid.Columns.GridColumn colLastName;
      private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
      private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
   }
}
