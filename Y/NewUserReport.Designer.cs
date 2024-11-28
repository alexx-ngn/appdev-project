namespace Y
{
    partial class NewUserReport
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
            this.reportButton = new System.Windows.Forms.Button();
            this.newReportLabel = new System.Windows.Forms.Label();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(550, 145);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 32);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // newReportLabel
            // 
            this.newReportLabel.AutoSize = true;
            this.newReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReportLabel.Location = new System.Drawing.Point(18, 20);
            this.newReportLabel.Name = "newReportLabel";
            this.newReportLabel.Size = new System.Drawing.Size(190, 20);
            this.newReportLabel.TabIndex = 4;
            this.newReportLabel.Text = "Enter your statement.";
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(18, 43);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.Size = new System.Drawing.Size(607, 96);
            this.reportRichTextBox.TabIndex = 3;
            this.reportRichTextBox.Text = "";
            // 
            // NewUserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 189);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.newReportLabel);
            this.Controls.Add(this.reportRichTextBox);
            this.Name = "NewUserReport";
            this.Text = "New Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label newReportLabel;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
    }
}