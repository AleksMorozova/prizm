namespace PrizmMain.Forms
{
    partial class CopyPipeSettingsXtraForm
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
            this.checkEditPipeSettings = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditListOfTestOperations = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditPipeManufacturer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPipeSizes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlPipeManufacturer = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPipeSizes = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonCopy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPipeSettings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditListOfTestOperations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPipeManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPipeSizes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditPipeSettings
            // 
            this.checkEditPipeSettings.Location = new System.Drawing.Point(44, 25);
            this.checkEditPipeSettings.Name = "checkEditPipeSettings";
            this.checkEditPipeSettings.Properties.Caption = "Pipe settings";
            this.checkEditPipeSettings.Size = new System.Drawing.Size(165, 19);
            this.checkEditPipeSettings.TabIndex = 0;
            // 
            // checkEditListOfTestOperations
            // 
            this.checkEditListOfTestOperations.Location = new System.Drawing.Point(44, 63);
            this.checkEditListOfTestOperations.Name = "checkEditListOfTestOperations";
            this.checkEditListOfTestOperations.Properties.Caption = "List of test operations";
            this.checkEditListOfTestOperations.Size = new System.Drawing.Size(165, 19);
            this.checkEditListOfTestOperations.TabIndex = 1;
            // 
            // comboBoxEditPipeManufacturer
            // 
            this.comboBoxEditPipeManufacturer.Location = new System.Drawing.Point(46, 123);
            this.comboBoxEditPipeManufacturer.Name = "comboBoxEditPipeManufacturer";
            this.comboBoxEditPipeManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPipeManufacturer.Size = new System.Drawing.Size(320, 20);
            this.comboBoxEditPipeManufacturer.TabIndex = 2;
            // 
            // comboBoxEditPipeSizes
            // 
            this.comboBoxEditPipeSizes.Location = new System.Drawing.Point(46, 184);
            this.comboBoxEditPipeSizes.Name = "comboBoxEditPipeSizes";
            this.comboBoxEditPipeSizes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPipeSizes.Size = new System.Drawing.Size(320, 20);
            this.comboBoxEditPipeSizes.TabIndex = 3;
            // 
            // labelControlPipeManufacturer
            // 
            this.labelControlPipeManufacturer.Location = new System.Drawing.Point(46, 103);
            this.labelControlPipeManufacturer.Name = "labelControlPipeManufacturer";
            this.labelControlPipeManufacturer.Size = new System.Drawing.Size(126, 13);
            this.labelControlPipeManufacturer.TabIndex = 4;
            this.labelControlPipeManufacturer.Text = "Set the pipe manufacturer";
            // 
            // labelControlPipeSizes
            // 
            this.labelControlPipeSizes.Location = new System.Drawing.Point(46, 164);
            this.labelControlPipeSizes.Name = "labelControlPipeSizes";
            this.labelControlPipeSizes.Size = new System.Drawing.Size(186, 13);
            this.labelControlPipeSizes.TabIndex = 5;
            this.labelControlPipeSizes.Text = "Pipe sizes, performance characteristics";
            // 
            // simpleButtonCopy
            // 
            this.simpleButtonCopy.Location = new System.Drawing.Point(291, 226);
            this.simpleButtonCopy.Name = "simpleButtonCopy";
            this.simpleButtonCopy.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCopy.TabIndex = 6;
            this.simpleButtonCopy.Text = "Copy";
            // 
            // simpleButtonСancel
            // 
            this.simpleButtonСancel.Location = new System.Drawing.Point(394, 226);
            this.simpleButtonСancel.Name = "simpleButtonСancel";
            this.simpleButtonСancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonСancel.TabIndex = 7;
            this.simpleButtonСancel.Text = "Сancel";
            // 
            // CopyPipeSettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.simpleButtonСancel);
            this.Controls.Add(this.simpleButtonCopy);
            this.Controls.Add(this.labelControlPipeSizes);
            this.Controls.Add(this.labelControlPipeManufacturer);
            this.Controls.Add(this.comboBoxEditPipeSizes);
            this.Controls.Add(this.comboBoxEditPipeManufacturer);
            this.Controls.Add(this.checkEditListOfTestOperations);
            this.Controls.Add(this.checkEditPipeSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CopyPipeSettingsXtraForm";
            this.Text = "Copy pipe settings";
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPipeSettings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditListOfTestOperations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPipeManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPipeSizes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEditPipeSettings;
        private DevExpress.XtraEditors.CheckEdit checkEditListOfTestOperations;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPipeManufacturer;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPipeSizes;
        private DevExpress.XtraEditors.LabelControl labelControlPipeManufacturer;
        private DevExpress.XtraEditors.LabelControl labelControlPipeSizes;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCopy;
        private DevExpress.XtraEditors.SimpleButton simpleButtonСancel;
    }
}