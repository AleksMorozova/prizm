namespace Prizm.Main.Forms.Parts.Inspection
{
    partial class InspectionSelectPartDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionSelectPartDialog));
            this.dialogLayout = new DevExpress.XtraLayout.LayoutControl();
            this.acceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchResults = new DevExpress.XtraGrid.GridControl();
            this.searchResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dialogLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchResultsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.acceptButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dialogLayout)).BeginInit();
            this.dialogLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButtonLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogLayout
            // 
            this.dialogLayout.Controls.Add(this.acceptButton);
            this.dialogLayout.Controls.Add(this.cancelButton);
            this.dialogLayout.Controls.Add(this.searchResults);
            this.dialogLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogLayout.Location = new System.Drawing.Point(0, 0);
            this.dialogLayout.Name = "dialogLayout";
            this.dialogLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dialogLayout.Root = this.dialogLayoutControlGroup;
            this.dialogLayout.Size = new System.Drawing.Size(417, 261);
            this.dialogLayout.TabIndex = 0;
            this.dialogLayout.Text = "dialogLayoutControl";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(225, 227);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(180, 22);
            this.acceptButton.StyleController = this.dialogLayout;
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Конт&роль";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(179, 22);
            this.cancelButton.StyleController = this.dialogLayout;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "О&тменить";
            // 
            // searchResults
            // 
            this.searchResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResults.Location = new System.Drawing.Point(12, 28);
            this.searchResults.MainView = this.searchResultsView;
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(393, 180);
            this.searchResults.TabIndex = 4;
            this.searchResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchResultsView});
            // 
            // searchResultsView
            // 
            this.searchResultsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberCol,
            this.typeCol});
            this.searchResultsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.searchResultsView.GridControl = this.searchResults;
            this.searchResultsView.Name = "searchResultsView";
            this.searchResultsView.OptionsBehavior.Editable = false;
            this.searchResultsView.OptionsBehavior.FocusLeaveOnTab = true;
            this.searchResultsView.OptionsBehavior.ReadOnly = true;
            this.searchResultsView.OptionsNavigation.UseTabKey = false;
            this.searchResultsView.OptionsView.ShowGroupPanel = false;
            this.searchResultsView.OptionsView.ShowIndicator = false;
            this.searchResultsView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.searchResultsView_CustomColumnDisplayText);
            // 
            // numberCol
            // 
            this.numberCol.Caption = "Номер";
            this.numberCol.FieldName = "Number";
            this.numberCol.Name = "numberCol";
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 0;
            // 
            // typeCol
            // 
            this.typeCol.Caption = "Тип";
            this.typeCol.FieldName = "Type";
            this.typeCol.Name = "typeCol";
            this.typeCol.Visible = true;
            this.typeCol.VisibleIndex = 1;
            // 
            // dialogLayoutControlGroup
            // 
            this.dialogLayoutControlGroup.CustomizationFormText = "dialogLayoutControlGroup";
            this.dialogLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.dialogLayoutControlGroup.GroupBordersVisible = false;
            this.dialogLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchResultsLayout,
            this.cancelButtonLayout,
            this.acceptButtonLayout});
            this.dialogLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.dialogLayoutControlGroup.Name = "dialogLayoutControlGroup";
            this.dialogLayoutControlGroup.Size = new System.Drawing.Size(417, 261);
            this.dialogLayoutControlGroup.Text = "dialogLayoutControlGroup";
            this.dialogLayoutControlGroup.TextVisible = false;
            // 
            // searchResultsLayout
            // 
            this.searchResultsLayout.Control = this.searchResults;
            this.searchResultsLayout.CustomizationFormText = "Рез&ультаты поиска";
            this.searchResultsLayout.Location = new System.Drawing.Point(0, 0);
            this.searchResultsLayout.Name = "searchResultsLayout";
            this.searchResultsLayout.Size = new System.Drawing.Size(397, 200);
            this.searchResultsLayout.Text = "Результаты поиска";
            this.searchResultsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.searchResultsLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // cancelButtonLayout
            // 
            this.cancelButtonLayout.Control = this.cancelButton;
            this.cancelButtonLayout.CustomizationFormText = "cancelButtonLayout";
            this.cancelButtonLayout.Location = new System.Drawing.Point(0, 200);
            this.cancelButtonLayout.Name = "cancelButtonLayout";
            this.cancelButtonLayout.Size = new System.Drawing.Size(198, 41);
            this.cancelButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 15, 0);
            this.cancelButtonLayout.Text = "cancelButtonLayout";
            this.cancelButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayout.TextVisible = false;
            // 
            // acceptButtonLayout
            // 
            this.acceptButtonLayout.Control = this.acceptButton;
            this.acceptButtonLayout.CustomizationFormText = "acceptButtonLayout";
            this.acceptButtonLayout.Location = new System.Drawing.Point(198, 200);
            this.acceptButtonLayout.Name = "acceptButtonLayout";
            this.acceptButtonLayout.Size = new System.Drawing.Size(199, 41);
            this.acceptButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 15, 0);
            this.acceptButtonLayout.Text = "acceptButtonLayout";
            this.acceptButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.acceptButtonLayout.TextVisible = false;
            // 
            // InspectionSelectPartDialog
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.dialogLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspectionSelectPartDialog";
            this.Text = "Выбор элемента";
            this.Load += new System.EventHandler(this.NumbersDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dialogLayout)).EndInit();
            this.dialogLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButtonLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl dialogLayout;
        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraGrid.GridControl searchResults;
        private DevExpress.XtraGrid.Views.Grid.GridView searchResultsView;
        private DevExpress.XtraLayout.LayoutControlGroup dialogLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem searchResultsLayout;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem acceptButtonLayout;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn typeCol;
    }
}