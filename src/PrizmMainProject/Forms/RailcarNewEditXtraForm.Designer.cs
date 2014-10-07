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
            this.lblDesigner = new DevExpress.XtraEditors.LabelControl();
            this.lblClient = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxDesigner = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxClient = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPurchaseOrder = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtPurchaseOrder = new DevExpress.XtraEditors.TextEdit();
            this.lblRailcar = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxRailcar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControlPipesList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPipesList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblDeliveryDate = new DevExpress.XtraEditors.LabelControl();
            this.lblShippedDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDelivery = new DevExpress.XtraEditors.DateEdit();
            this.dateEditShipped = new DevExpress.XtraEditors.DateEdit();
            this.lblCertificate = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtCertificateNo = new DevExpress.XtraEditors.TextEdit();
            this.btnunship = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDesigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPurchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxRailcar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPipesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditShipped.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditShipped.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCertificateNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesigner
            // 
            this.lblDesigner.Location = new System.Drawing.Point(12, 68);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(42, 13);
            this.lblDesigner.TabIndex = 0;
            this.lblDesigner.Text = "Designer";
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(187, 68);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(27, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client";
            // 
            // comboBoxDesigner
            // 
            this.comboBoxDesigner.Location = new System.Drawing.Point(12, 87);
            this.comboBoxDesigner.Name = "comboBoxDesigner";
            this.comboBoxDesigner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxDesigner.Size = new System.Drawing.Size(138, 20);
            this.comboBoxDesigner.TabIndex = 2;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Location = new System.Drawing.Point(187, 87);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxClient.Size = new System.Drawing.Size(138, 20);
            this.comboBoxClient.TabIndex = 3;
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.Location = new System.Drawing.Point(357, 68);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(73, 13);
            this.lblPurchaseOrder.TabIndex = 4;
            this.lblPurchaseOrder.Text = "Purchase order";
            // 
            // txtEdtPurchaseOrder
            // 
            this.txtEdtPurchaseOrder.Location = new System.Drawing.Point(357, 87);
            this.txtEdtPurchaseOrder.Name = "txtEdtPurchaseOrder";
            this.txtEdtPurchaseOrder.Size = new System.Drawing.Size(132, 20);
            this.txtEdtPurchaseOrder.TabIndex = 5;
            // 
            // lblRailcar
            // 
            this.lblRailcar.Location = new System.Drawing.Point(12, 14);
            this.lblRailcar.Name = "lblRailcar";
            this.lblRailcar.Size = new System.Drawing.Size(71, 13);
            this.lblRailcar.TabIndex = 6;
            this.lblRailcar.Text = "Railcar number";
            // 
            // comboBoxRailcar
            // 
            this.comboBoxRailcar.Location = new System.Drawing.Point(12, 33);
            this.comboBoxRailcar.Name = "comboBoxRailcar";
            this.comboBoxRailcar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxRailcar.Size = new System.Drawing.Size(71, 20);
            this.comboBoxRailcar.TabIndex = 7;
            // 
            // gridControlPipesList
            // 
            this.gridControlPipesList.Location = new System.Drawing.Point(12, 177);
            this.gridControlPipesList.MainView = this.gridViewPipesList;
            this.gridControlPipesList.Name = "gridControlPipesList";
            this.gridControlPipesList.Size = new System.Drawing.Size(685, 159);
            this.gridControlPipesList.TabIndex = 8;
            this.gridControlPipesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPipesList});
            // 
            // gridViewPipesList
            // 
            this.gridViewPipesList.GridControl = this.gridControlPipesList;
            this.gridViewPipesList.Name = "gridViewPipesList";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Location = new System.Drawing.Point(12, 121);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(64, 13);
            this.lblDeliveryDate.TabIndex = 9;
            this.lblDeliveryDate.Text = "Delivery date";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.Location = new System.Drawing.Point(187, 121);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(63, 13);
            this.lblShippedDate.TabIndex = 10;
            this.lblShippedDate.Text = "Shipped date";
            // 
            // dateEditDelivery
            // 
            this.dateEditDelivery.EditValue = null;
            this.dateEditDelivery.Location = new System.Drawing.Point(12, 140);
            this.dateEditDelivery.Name = "dateEditDelivery";
            this.dateEditDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDelivery.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditDelivery.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditDelivery.Size = new System.Drawing.Size(138, 20);
            this.dateEditDelivery.TabIndex = 11;
            // 
            // dateEditShipped
            // 
            this.dateEditShipped.EditValue = null;
            this.dateEditShipped.Location = new System.Drawing.Point(187, 140);
            this.dateEditShipped.Name = "dateEditShipped";
            this.dateEditShipped.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditShipped.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditShipped.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditShipped.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditShipped.Size = new System.Drawing.Size(138, 20);
            this.dateEditShipped.TabIndex = 12;
            // 
            // lblCertificate
            // 
            this.lblCertificate.Location = new System.Drawing.Point(116, 12);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(89, 13);
            this.lblCertificate.TabIndex = 13;
            this.lblCertificate.Text = "Certificate number";
            // 
            // txtEdtCertificateNo
            // 
            this.txtEdtCertificateNo.Location = new System.Drawing.Point(116, 33);
            this.txtEdtCertificateNo.Name = "txtEdtCertificateNo";
            this.txtEdtCertificateNo.Size = new System.Drawing.Size(289, 20);
            this.txtEdtCertificateNo.TabIndex = 14;
            // 
            // btnunship
            // 
            this.btnunship.Location = new System.Drawing.Point(519, 351);
            this.btnunship.Name = "btnunship";
            this.btnunship.Size = new System.Drawing.Size(75, 23);
            this.btnunship.TabIndex = 15;
            this.btnunship.Text = "Unship";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            // 
            // RailcarNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnunship);
            this.Controls.Add(this.txtEdtCertificateNo);
            this.Controls.Add(this.lblCertificate);
            this.Controls.Add(this.dateEditShipped);
            this.Controls.Add(this.dateEditDelivery);
            this.Controls.Add(this.lblShippedDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.gridControlPipesList);
            this.Controls.Add(this.comboBoxRailcar);
            this.Controls.Add(this.lblRailcar);
            this.Controls.Add(this.txtEdtPurchaseOrder);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxDesigner);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDesigner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarNewEditXtraForm";
            this.Text = "RailcarNewEditXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDesigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPurchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxRailcar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPipesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditShipped.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditShipped.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCertificateNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDesigner;
        private DevExpress.XtraEditors.LabelControl lblClient;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDesigner;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxClient;
        private DevExpress.XtraEditors.LabelControl lblPurchaseOrder;
        private DevExpress.XtraEditors.TextEdit txtEdtPurchaseOrder;
        private DevExpress.XtraEditors.LabelControl lblRailcar;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxRailcar;
        private DevExpress.XtraGrid.GridControl gridControlPipesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPipesList;
        private DevExpress.XtraEditors.LabelControl lblDeliveryDate;
        private DevExpress.XtraEditors.LabelControl lblShippedDate;
        private DevExpress.XtraEditors.DateEdit dateEditDelivery;
        private DevExpress.XtraEditors.DateEdit dateEditShipped;
        private DevExpress.XtraEditors.LabelControl lblCertificate;
        private DevExpress.XtraEditors.TextEdit txtEdtCertificateNo;
        private DevExpress.XtraEditors.SimpleButton btnunship;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}