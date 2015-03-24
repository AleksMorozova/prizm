namespace Prizm.Main.Forms.Joint.NewEdit
{
    partial class JointSelectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointSelectDialog));
            this.JointSearchLayout = new DevExpress.XtraLayout.LayoutControl();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.resultsGrid = new DevExpress.XtraGrid.GridControl();
            this.resultsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.resultsGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.JointSearchLayout)).BeginInit();
            this.JointSearchLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // JointSearchLayout
            // 
            this.JointSearchLayout.Controls.Add(this.editButton);
            this.JointSearchLayout.Controls.Add(this.cancelButton);
            this.JointSearchLayout.Controls.Add(this.resultsGrid);
            this.JointSearchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JointSearchLayout.Location = new System.Drawing.Point(0, 0);
            this.JointSearchLayout.Name = "JointSearchLayout";
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JointSearchLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JointSearchLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.JointSearchLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.JointSearchLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JointSearchLayout.Root = this.Root;
            this.JointSearchLayout.Size = new System.Drawing.Size(337, 272);
            this.JointSearchLayout.TabIndex = 0;
            this.JointSearchLayout.Text = "layoutControl1";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(224, 238);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(101, 22);
            this.editButton.StyleController = this.JointSearchLayout;
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактировать";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 22);
            this.cancelButton.StyleController = this.JointSearchLayout;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            // 
            // resultsGrid
            // 
            this.resultsGrid.Location = new System.Drawing.Point(12, 28);
            this.resultsGrid.MainView = this.resultsGridView;
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.Size = new System.Drawing.Size(313, 191);
            this.resultsGrid.TabIndex = 4;
            this.resultsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.resultsGridView});
            // 
            // resultsGridView
            // 
            this.resultsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberGridColumn});
            this.resultsGridView.GridControl = this.resultsGrid;
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.OptionsBehavior.Editable = false;
            this.resultsGridView.OptionsBehavior.ReadOnly = true;
            this.resultsGridView.OptionsNavigation.UseTabKey = false;
            this.resultsGridView.OptionsView.ShowGroupPanel = false;
            this.resultsGridView.OptionsView.ShowIndicator = false;
            // 
            // numberGridColumn
            // 
            this.numberGridColumn.Caption = "Номер стыка";
            this.numberGridColumn.FieldName = "Number";
            this.numberGridColumn.Name = "numberGridColumn";
            this.numberGridColumn.Visible = true;
            this.numberGridColumn.VisibleIndex = 0;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.resultsGridLayout,
            this.CancelButtonLayout,
            this.editButtonLayout,
            this.buttonsEmptySpaceItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(337, 272);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // resultsGridLayout
            // 
            this.resultsGridLayout.Control = this.resultsGrid;
            this.resultsGridLayout.CustomizationFormText = "Результаты поиска";
            this.resultsGridLayout.Location = new System.Drawing.Point(0, 0);
            this.resultsGridLayout.Name = "resultsGridLayout";
            this.resultsGridLayout.Size = new System.Drawing.Size(317, 211);
            this.resultsGridLayout.Text = "Результаты поиска";
            this.resultsGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.resultsGridLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // CancelButtonLayout
            // 
            this.CancelButtonLayout.Control = this.cancelButton;
            this.CancelButtonLayout.CustomizationFormText = "CancelButtonLayout";
            this.CancelButtonLayout.Location = new System.Drawing.Point(0, 211);
            this.CancelButtonLayout.Name = "CancelButtonLayout";
            this.CancelButtonLayout.Size = new System.Drawing.Size(129, 41);
            this.CancelButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 15, 0);
            this.CancelButtonLayout.Text = "CancelButtonLayout";
            this.CancelButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.CancelButtonLayout.TextVisible = false;
            // 
            // editButtonLayout
            // 
            this.editButtonLayout.Control = this.editButton;
            this.editButtonLayout.CustomizationFormText = "editButtonLayout";
            this.editButtonLayout.Location = new System.Drawing.Point(197, 211);
            this.editButtonLayout.Name = "editButtonLayout";
            this.editButtonLayout.Size = new System.Drawing.Size(120, 41);
            this.editButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 15, 0);
            this.editButtonLayout.Text = "editButtonLayout";
            this.editButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.editButtonLayout.TextVisible = false;
            // 
            // buttonsEmptySpaceItem
            // 
            this.buttonsEmptySpaceItem.AllowHotTrack = false;
            this.buttonsEmptySpaceItem.CustomizationFormText = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.Location = new System.Drawing.Point(129, 211);
            this.buttonsEmptySpaceItem.Name = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.Size = new System.Drawing.Size(68, 41);
            this.buttonsEmptySpaceItem.Text = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // JointSelectDialog
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(337, 272);
            this.Controls.Add(this.JointSearchLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JointSelectDialog";
            this.Text = "Выбор стыка";
            this.Load += new System.EventHandler(this.JointSelectDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JointSearchLayout)).EndInit();
            this.JointSearchLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl JointSearchLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl resultsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView resultsGridView;
        private DevExpress.XtraLayout.LayoutControlItem resultsGridLayout;
        private DevExpress.XtraGrid.Columns.GridColumn numberGridColumn;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem CancelButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpaceItem;
    }
}