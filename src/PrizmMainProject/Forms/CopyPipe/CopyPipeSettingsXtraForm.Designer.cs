namespace PrizmMain.Forms.CopyPipe
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
            this.pipeSettings = new DevExpress.XtraEditors.CheckEdit();
            this.listOfTestOperations = new DevExpress.XtraEditors.CheckEdit();
            this.pipeManufacturer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeSizes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeManufacturerLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeSizesLabel = new DevExpress.XtraEditors.LabelControl();
            this.copyButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSettings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfTestOperations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeSettings
            // 
            this.pipeSettings.Location = new System.Drawing.Point(44, 25);
            this.pipeSettings.Name = "pipeSettings";
            this.pipeSettings.Properties.Caption = "Pipe settings";
            this.pipeSettings.Size = new System.Drawing.Size(165, 19);
            this.pipeSettings.TabIndex = 0;
            // 
            // listOfTestOperations
            // 
            this.listOfTestOperations.Location = new System.Drawing.Point(44, 63);
            this.listOfTestOperations.Name = "listOfTestOperations";
            this.listOfTestOperations.Properties.Caption = "List of test operations";
            this.listOfTestOperations.Size = new System.Drawing.Size(165, 19);
            this.listOfTestOperations.TabIndex = 1;
            // 
            // pipeManufacturer
            // 
            this.pipeManufacturer.Location = new System.Drawing.Point(46, 123);
            this.pipeManufacturer.Name = "pipeManufacturer";
            this.pipeManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeManufacturer.Size = new System.Drawing.Size(320, 20);
            this.pipeManufacturer.TabIndex = 2;
            // 
            // pipeSizes
            // 
            this.pipeSizes.Location = new System.Drawing.Point(46, 184);
            this.pipeSizes.Name = "pipeSizes";
            this.pipeSizes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSizes.Size = new System.Drawing.Size(320, 20);
            this.pipeSizes.TabIndex = 3;
            // 
            // pipeManufacturerLabel
            // 
            this.pipeManufacturerLabel.Location = new System.Drawing.Point(46, 103);
            this.pipeManufacturerLabel.Name = "pipeManufacturerLabel";
            this.pipeManufacturerLabel.Size = new System.Drawing.Size(126, 13);
            this.pipeManufacturerLabel.TabIndex = 4;
            this.pipeManufacturerLabel.Text = "Set the pipe manufacturer";
            // 
            // pipeSizesLabel
            // 
            this.pipeSizesLabel.Location = new System.Drawing.Point(46, 164);
            this.pipeSizesLabel.Name = "pipeSizesLabel";
            this.pipeSizesLabel.Size = new System.Drawing.Size(186, 13);
            this.pipeSizesLabel.TabIndex = 5;
            this.pipeSizesLabel.Text = "Pipe sizes, performance characteristics";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(291, 226);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(394, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Сancel";
            // 
            // CopyPipeSettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.pipeSizesLabel);
            this.Controls.Add(this.pipeManufacturerLabel);
            this.Controls.Add(this.pipeSizes);
            this.Controls.Add(this.pipeManufacturer);
            this.Controls.Add(this.listOfTestOperations);
            this.Controls.Add(this.pipeSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CopyPipeSettingsXtraForm";
            this.Text = "Copy pipe settings";
            ((System.ComponentModel.ISupportInitialize)(this.pipeSettings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfTestOperations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit pipeSettings;
        private DevExpress.XtraEditors.CheckEdit listOfTestOperations;
        private DevExpress.XtraEditors.ComboBoxEdit pipeManufacturer;
        private DevExpress.XtraEditors.ComboBoxEdit pipeSizes;
        private DevExpress.XtraEditors.LabelControl pipeManufacturerLabel;
        private DevExpress.XtraEditors.LabelControl pipeSizesLabel;
        private DevExpress.XtraEditors.SimpleButton copyButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
    }
}