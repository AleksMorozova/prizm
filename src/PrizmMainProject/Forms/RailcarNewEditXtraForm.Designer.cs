namespace PrizmMain.Forms
{
    partial class RailcarNewEditXtraForm
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
            this.designerLabel = new DevExpress.XtraEditors.LabelControl();
            this.clientLabel = new DevExpress.XtraEditors.LabelControl();
            this.designer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.client = new DevExpress.XtraEditors.ComboBoxEdit();
            this.purchaseOrderLabel = new DevExpress.XtraEditors.LabelControl();
            this.purchaseOrder = new DevExpress.XtraEditors.TextEdit();
            this.railcarLabel = new DevExpress.XtraEditors.LabelControl();
            this.railcarNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipesList = new DevExpress.XtraGrid.GridControl();
            this.pipesListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deliveryDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.shippedDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.deliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.certificateNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.unshipButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeSizeLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeSize = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // designerLabel
            // 
            this.designerLabel.Location = new System.Drawing.Point(12, 68);
            this.designerLabel.Name = "designerLabel";
            this.designerLabel.Size = new System.Drawing.Size(42, 13);
            this.designerLabel.TabIndex = 0;
            this.designerLabel.Text = "Designer";
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(214, 68);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Client";
            // 
            // designer
            // 
            this.designer.Location = new System.Drawing.Point(12, 87);
            this.designer.Name = "designer";
            this.designer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designer.Size = new System.Drawing.Size(167, 20);
            this.designer.TabIndex = 2;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(214, 87);
            this.client.Name = "client";
            this.client.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client.Size = new System.Drawing.Size(167, 20);
            this.client.TabIndex = 3;
            // 
            // purchaseOrderLabel
            // 
            this.purchaseOrderLabel.Location = new System.Drawing.Point(591, 14);
            this.purchaseOrderLabel.Name = "purchaseOrderLabel";
            this.purchaseOrderLabel.Size = new System.Drawing.Size(73, 13);
            this.purchaseOrderLabel.TabIndex = 4;
            this.purchaseOrderLabel.Text = "Purchase order";
            // 
            // purchaseOrder
            // 
            this.purchaseOrder.Location = new System.Drawing.Point(591, 33);
            this.purchaseOrder.Name = "purchaseOrder";
            this.purchaseOrder.Size = new System.Drawing.Size(132, 20);
            this.purchaseOrder.TabIndex = 5;
            // 
            // railcarLabel
            // 
            this.railcarLabel.Location = new System.Drawing.Point(12, 14);
            this.railcarLabel.Name = "railcarLabel";
            this.railcarLabel.Size = new System.Drawing.Size(71, 13);
            this.railcarLabel.TabIndex = 6;
            this.railcarLabel.Text = "Railcar number";
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(12, 33);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.railcarNumber.Size = new System.Drawing.Size(71, 20);
            this.railcarNumber.TabIndex = 7;
            // 
            // pipesList
            // 
            this.pipesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesList.Location = new System.Drawing.Point(12, 130);
            this.pipesList.MainView = this.pipesListView;
            this.pipesList.Name = "pipesList";
            this.pipesList.Size = new System.Drawing.Size(916, 261);
            this.pipesList.TabIndex = 8;
            this.pipesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesListView});
            // 
            // pipesListView
            // 
            this.pipesListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumberGridColumn,
            this.pipeSizeGridColumn,
            this.pipeStatusGridColumn});
            this.pipesListView.GridControl = this.pipesList;
            this.pipesListView.Name = "pipesListView";
            this.pipesListView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeNumberGridColumn
            // 
            this.pipeNumberGridColumn.Caption = "Pipe number";
            this.pipeNumberGridColumn.FieldName = "PipeNumber";
            this.pipeNumberGridColumn.Name = "pipeNumberGridColumn";
            this.pipeNumberGridColumn.Visible = true;
            this.pipeNumberGridColumn.VisibleIndex = 0;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Size";
            this.pipeSizeGridColumn.FieldName = "Size";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 1;
            // 
            // pipeStatusGridColumn
            // 
            this.pipeStatusGridColumn.Caption = "Status";
            this.pipeStatusGridColumn.FieldName = "Status";
            this.pipeStatusGridColumn.Name = "pipeStatusGridColumn";
            this.pipeStatusGridColumn.Visible = true;
            this.pipeStatusGridColumn.VisibleIndex = 2;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(591, 68);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(64, 13);
            this.deliveryDateLabel.TabIndex = 9;
            this.deliveryDateLabel.Text = "Delivery date";
            // 
            // shippedDateLabel
            // 
            this.shippedDateLabel.Location = new System.Drawing.Point(416, 68);
            this.shippedDateLabel.Name = "shippedDateLabel";
            this.shippedDateLabel.Size = new System.Drawing.Size(65, 13);
            this.shippedDateLabel.TabIndex = 10;
            this.shippedDateLabel.Text = "Shipping date";
            // 
            // deliveryDate
            // 
            this.deliveryDate.EditValue = null;
            this.deliveryDate.Location = new System.Drawing.Point(591, 87);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Size = new System.Drawing.Size(138, 20);
            this.deliveryDate.TabIndex = 11;
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(416, 87);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(138, 20);
            this.shippedDate.TabIndex = 12;
            // 
            // certificateNumberLabel
            // 
            this.certificateNumberLabel.Location = new System.Drawing.Point(116, 12);
            this.certificateNumberLabel.Name = "certificateNumberLabel";
            this.certificateNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.certificateNumberLabel.TabIndex = 13;
            this.certificateNumberLabel.Text = "Certificate number";
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(116, 33);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(265, 20);
            this.certificateNumber.TabIndex = 14;
            // 
            // unshipButton
            // 
            this.unshipButton.Location = new System.Drawing.Point(750, 404);
            this.unshipButton.Name = "unshipButton";
            this.unshipButton.Size = new System.Drawing.Size(75, 23);
            this.unshipButton.TabIndex = 15;
            this.unshipButton.Text = "Unship";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(853, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            // 
            // pipeSizeLabel
            // 
            this.pipeSizeLabel.Location = new System.Drawing.Point(416, 14);
            this.pipeSizeLabel.Name = "pipeSizeLabel";
            this.pipeSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.pipeSizeLabel.TabIndex = 17;
            this.pipeSizeLabel.Text = "Pipe size";
            // 
            // pipeSize
            // 
            this.pipeSize.Location = new System.Drawing.Point(416, 33);
            this.pipeSize.Name = "pipeSize";
            this.pipeSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSize.Size = new System.Drawing.Size(138, 20);
            this.pipeSize.TabIndex = 18;
            // 
            // RailcarNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pipeSize);
            this.Controls.Add(this.pipeSizeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.unshipButton);
            this.Controls.Add(this.certificateNumber);
            this.Controls.Add(this.certificateNumberLabel);
            this.Controls.Add(this.shippedDate);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.shippedDateLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.pipesList);
            this.Controls.Add(this.railcarNumber);
            this.Controls.Add(this.railcarLabel);
            this.Controls.Add(this.purchaseOrder);
            this.Controls.Add(this.purchaseOrderLabel);
            this.Controls.Add(this.client);
            this.Controls.Add(this.designer);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.designerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarNewEditXtraForm";
            this.Text = "New or Edit railcar";
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl designerLabel;
        private DevExpress.XtraEditors.LabelControl clientLabel;
        private DevExpress.XtraEditors.ComboBoxEdit designer;
        private DevExpress.XtraEditors.ComboBoxEdit client;
        private DevExpress.XtraEditors.LabelControl purchaseOrderLabel;
        private DevExpress.XtraEditors.TextEdit purchaseOrder;
        private DevExpress.XtraEditors.LabelControl railcarLabel;
        private DevExpress.XtraEditors.ComboBoxEdit railcarNumber;
        private DevExpress.XtraGrid.GridControl pipesList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesListView;
        private DevExpress.XtraEditors.LabelControl deliveryDateLabel;
        private DevExpress.XtraEditors.LabelControl shippedDateLabel;
        private DevExpress.XtraEditors.DateEdit deliveryDate;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.LabelControl certificateNumberLabel;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.SimpleButton unshipButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl pipeSizeLabel;
        private DevExpress.XtraEditors.ComboBoxEdit pipeSize;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeStatusGridColumn;
    }
}