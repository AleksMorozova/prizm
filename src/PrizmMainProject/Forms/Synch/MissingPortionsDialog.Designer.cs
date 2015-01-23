namespace Prizm.Main.Forms.Synch
{
    partial class MissingPortionsDialog
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
            this.acceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.portionsDiapason = new DevExpress.XtraEditors.TextEdit();
            this.message = new DevExpress.XtraEditors.LabelControl();
            this.recomendation = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.portionsDiapason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 123);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Все равно импортировать";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(223, 123);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить импортирование";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // portionsDiapason
            // 
            this.portionsDiapason.Location = new System.Drawing.Point(110, 59);
            this.portionsDiapason.Name = "portionsDiapason";
            this.portionsDiapason.Properties.ReadOnly = true;
            this.portionsDiapason.Size = new System.Drawing.Size(172, 20);
            this.portionsDiapason.TabIndex = 2;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(15, 26);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 3;
            // 
            // recomendation
            // 
            this.recomendation.Location = new System.Drawing.Point(15, 95);
            this.recomendation.Name = "recomendation";
            this.recomendation.Size = new System.Drawing.Size(345, 13);
            this.recomendation.TabIndex = 4;
            this.recomendation.Text = "Рекомендуется отмена импортирования данной порции. Отменить?";
            // 
            // MissingPortionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 161);
            this.Controls.Add(this.recomendation);
            this.Controls.Add(this.message);
            this.Controls.Add(this.portionsDiapason);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "MissingPortionsDialog";
            this.Text = "Нарушена последовательность";
            ((System.ComponentModel.ISupportInitialize)(this.portionsDiapason.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.TextEdit portionsDiapason;
        private DevExpress.XtraEditors.LabelControl message;
        private DevExpress.XtraEditors.LabelControl recomendation;
    }
}