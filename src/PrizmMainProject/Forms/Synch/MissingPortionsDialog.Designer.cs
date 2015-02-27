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
            this.recomendation = new DevExpress.XtraEditors.LabelControl();
            this.missingNumbers = new DevExpress.XtraEditors.LabelControl();
            this.missingNumbersText = new DevExpress.XtraEditors.TextEdit();
            this.millNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.portionsDiapasonLabel = new DevExpress.XtraEditors.LabelControl();
            this.millNameText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.portionsDiapason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingNumbersText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millNameText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 252);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Все равно импортировать";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить импортирование";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // portionsDiapason
            // 
            this.portionsDiapason.Location = new System.Drawing.Point(12, 113);
            this.portionsDiapason.Name = "portionsDiapason";
            this.portionsDiapason.Properties.ReadOnly = true;
            this.portionsDiapason.Size = new System.Drawing.Size(391, 20);
            this.portionsDiapason.TabIndex = 2;
            // 
            // recomendation
            // 
            this.recomendation.Location = new System.Drawing.Point(12, 223);
            this.recomendation.Name = "recomendation";
            this.recomendation.Size = new System.Drawing.Size(345, 13);
            this.recomendation.TabIndex = 4;
            this.recomendation.Text = "Рекомендуется отмена импортирования данной порции. Отменить?";
            // 
            // missingNumbers
            // 
            this.missingNumbers.Location = new System.Drawing.Point(12, 163);
            this.missingNumbers.Name = "missingNumbers";
            this.missingNumbers.Size = new System.Drawing.Size(116, 13);
            this.missingNumbers.TabIndex = 5;
            this.missingNumbers.Text = "Недостающие порции:";
            // 
            // missingNumbersText
            // 
            this.missingNumbersText.Location = new System.Drawing.Point(12, 182);
            this.missingNumbersText.Name = "missingNumbersText";
            this.missingNumbersText.Properties.ReadOnly = true;
            this.missingNumbersText.Size = new System.Drawing.Size(391, 20);
            this.missingNumbersText.TabIndex = 6;
            // 
            // millNameLabel
            // 
            this.millNameLabel.Location = new System.Drawing.Point(12, 25);
            this.millNameLabel.Name = "millNameLabel";
            this.millNameLabel.Size = new System.Drawing.Size(383, 13);
            this.millNameLabel.TabIndex = 7;
            this.millNameLabel.Text = "Последовательность импортируемых данных нарушена. Рабочая станция:";
            // 
            // portionsDiapasonLabel
            // 
            this.portionsDiapasonLabel.Location = new System.Drawing.Point(12, 94);
            this.portionsDiapasonLabel.Name = "portionsDiapasonLabel";
            this.portionsDiapasonLabel.Size = new System.Drawing.Size(190, 13);
            this.portionsDiapasonLabel.TabIndex = 8;
            this.portionsDiapasonLabel.Text = "Уже существуют порции с номерами:";
            // 
            // millNameText
            // 
            this.millNameText.Location = new System.Drawing.Point(12, 44);
            this.millNameText.Name = "millNameText";
            this.millNameText.Properties.ReadOnly = true;
            this.millNameText.Size = new System.Drawing.Size(391, 20);
            this.millNameText.TabIndex = 9;
            // 
            // MissingPortionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 287);
            this.Controls.Add(this.millNameText);
            this.Controls.Add(this.portionsDiapasonLabel);
            this.Controls.Add(this.millNameLabel);
            this.Controls.Add(this.missingNumbersText);
            this.Controls.Add(this.missingNumbers);
            this.Controls.Add(this.recomendation);
            this.Controls.Add(this.portionsDiapason);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "MissingPortionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Нарушена последовательность";
            ((System.ComponentModel.ISupportInitialize)(this.portionsDiapason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingNumbersText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millNameText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.TextEdit portionsDiapason;
        private DevExpress.XtraEditors.LabelControl recomendation;
        private DevExpress.XtraEditors.LabelControl missingNumbers;
        private DevExpress.XtraEditors.TextEdit missingNumbersText;
        private DevExpress.XtraEditors.LabelControl millNameLabel;
        private DevExpress.XtraEditors.LabelControl portionsDiapasonLabel;
        private DevExpress.XtraEditors.TextEdit millNameText;
    }
}