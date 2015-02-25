namespace Prizm.Main.Forms.Settings
{
   partial class PasswordChangeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeDialog));
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.passwordChangeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblOldPassLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblPassLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblConfirmLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordChangeLayout)).BeginInit();
            this.passwordChangeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOldPassLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(12, 28);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(338, 20);
            this.txtOldPass.StyleController = this.passwordChangeLayout;
            this.txtOldPass.TabIndex = 3;
            // 
            // passwordChangeLayout
            // 
            this.passwordChangeLayout.Controls.Add(this.txtConfirm);
            this.passwordChangeLayout.Controls.Add(this.btnCancel);
            this.passwordChangeLayout.Controls.Add(this.btnOk);
            this.passwordChangeLayout.Controls.Add(this.txtNewPass);
            this.passwordChangeLayout.Controls.Add(this.txtOldPass);
            this.passwordChangeLayout.Location = new System.Drawing.Point(12, 12);
            this.passwordChangeLayout.Name = "passwordChangeLayout";
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passwordChangeLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.passwordChangeLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.passwordChangeLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.passwordChangeLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.passwordChangeLayout.Root = this.Root;
            this.passwordChangeLayout.Size = new System.Drawing.Size(362, 180);
            this.passwordChangeLayout.TabIndex = 8;
            this.passwordChangeLayout.Text = "layoutControl1";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(12, 108);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(338, 20);
            this.txtConfirm.StyleController = this.passwordChangeLayout;
            this.txtConfirm.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 22);
            this.btnCancel.StyleController = this.passwordChangeLayout;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Отмена";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 22);
            this.btnOk.StyleController = this.passwordChangeLayout;
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(12, 68);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(338, 20);
            this.txtNewPass.StyleController = this.passwordChangeLayout;
            this.txtNewPass.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblOldPassLayout,
            this.lblPassLayout,
            this.lblConfirmLayout,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(362, 180);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // lblOldPassLayout
            // 
            this.lblOldPassLayout.Control = this.txtOldPass;
            this.lblOldPassLayout.CustomizationFormText = "Старый пароль:";
            this.lblOldPassLayout.Location = new System.Drawing.Point(0, 0);
            this.lblOldPassLayout.Name = "lblOldPassLayout";
            this.lblOldPassLayout.Size = new System.Drawing.Size(342, 40);
            this.lblOldPassLayout.Text = "Старый пароль:";
            this.lblOldPassLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.lblOldPassLayout.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lblPassLayout
            // 
            this.lblPassLayout.Control = this.txtNewPass;
            this.lblPassLayout.CustomizationFormText = "Пароль:";
            this.lblPassLayout.Location = new System.Drawing.Point(0, 40);
            this.lblPassLayout.Name = "lblPassLayout";
            this.lblPassLayout.Size = new System.Drawing.Size(342, 40);
            this.lblPassLayout.Text = "Пароль:";
            this.lblPassLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.lblPassLayout.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lblConfirmLayout
            // 
            this.lblConfirmLayout.Control = this.txtConfirm;
            this.lblConfirmLayout.CustomizationFormText = "Подтверждение:";
            this.lblConfirmLayout.Location = new System.Drawing.Point(0, 80);
            this.lblConfirmLayout.Name = "lblConfirmLayout";
            this.lblConfirmLayout.Size = new System.Drawing.Size(342, 40);
            this.lblConfirmLayout.Text = "Подтверждение:";
            this.lblConfirmLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.lblConfirmLayout.TextSize = new System.Drawing.Size(87, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(342, 14);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 134);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(143, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnOk;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(143, 134);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(243, 134);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // PasswordChangeDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(387, 201);
            this.Controls.Add(this.passwordChangeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordChangeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена пароля";
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordChangeLayout)).EndInit();
            this.passwordChangeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOldPassLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.TextEdit txtOldPass;
      private DevExpress.XtraEditors.TextEdit txtNewPass;
      private DevExpress.XtraEditors.TextEdit txtConfirm;
      private DevExpress.XtraEditors.SimpleButton btnOk;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraLayout.LayoutControl passwordChangeLayout;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem lblOldPassLayout;
      private DevExpress.XtraLayout.LayoutControlItem lblPassLayout;
      private DevExpress.XtraLayout.LayoutControlItem lblConfirmLayout;
      private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
      private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
   }
}