namespace PrizmMain.Forms
{
    partial class RolesPrivilegeEditXtraForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.priveleges = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.roleEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.privilegesLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priveleges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.priveleges);
            this.layoutControl1.Controls.Add(this.roleEdit);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(396, 131, 499, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.ShowTemplates = true;
            this.layoutControl1.Size = new System.Drawing.Size(534, 511);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // priveleges
            // 
            this.priveleges.Location = new System.Drawing.Point(32, 103);
            this.priveleges.Name = "priveleges";
            this.priveleges.Size = new System.Drawing.Size(470, 342);
            this.priveleges.StyleController = this.layoutControl1;
            this.priveleges.TabIndex = 5;
            // 
            // roleEdit
            // 
            this.roleEdit.Location = new System.Drawing.Point(32, 48);
            this.roleEdit.Name = "roleEdit";
            this.roleEdit.Size = new System.Drawing.Size(470, 20);
            this.roleEdit.StyleController = this.layoutControl1;
            this.roleEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.roleLabel,
            this.privilegesLabel,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(534, 511);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.priveleges;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(474, 353);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 7);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.Control = this.roleEdit;
            this.roleLabel.CustomizationFormText = "Role";
            this.roleLabel.Location = new System.Drawing.Point(0, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(474, 47);
            this.roleLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 7);
            this.roleLabel.Text = "Роль пользователя";
            this.roleLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLabel.TextSize = new System.Drawing.Size(172, 13);
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AllowHotTrack = false;
            this.privilegesLabel.CustomizationFormText = "Список привилегий пользователя";
            this.privilegesLabel.Location = new System.Drawing.Point(0, 47);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(282, 24);
            this.privilegesLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 0);
            this.privilegesLabel.Text = "Список привилегий пользователя";
            this.privilegesLabel.TextSize = new System.Drawing.Size(172, 13);
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(338, 456);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "OK";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(427, 456);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Cancel";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem6.Location = new System.Drawing.Point(306, 424);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(79, 27);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem2";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton2;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem7.Location = new System.Drawing.Point(395, 424);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem3";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(193, 242);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 242);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(114, 27);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // RolesPrivilegeEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.layoutControl1);
            this.Name = "RolesPrivilegeEditXtraForm";
            this.Text = "Edit roles";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priveleges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl priveleges;
        private DevExpress.XtraEditors.TextEdit roleEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem roleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem privilegesLabel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;

    }
}