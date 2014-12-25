﻿namespace Prizm.Main.Forms.MainChildForm
{
    partial class AppSplashScreen
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
            this.marqueeProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.EditValue = 0;
            this.marqueeProgressBarControl.Location = new System.Drawing.Point(23, 231);
            this.marqueeProgressBarControl.Name = "marqueeProgressBarControl";
            this.marqueeProgressBarControl.Size = new System.Drawing.Size(404, 12);
            this.marqueeProgressBarControl.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(23, 206);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(89, 13);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "Идет загрузка ...";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Prizm.Main.Properties.Resources.main_logo_03;
            this.pictureBox.Location = new System.Drawing.Point(86, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 164);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // AppSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.marqueeProgressBarControl);
            this.Name = "AppSplashScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl;
        private DevExpress.XtraEditors.LabelControl labelMessage;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
