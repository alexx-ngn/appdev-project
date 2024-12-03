namespace Y
{
    partial class NewUserReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(NewUserReport));
            this.reportButton = new global::System.Windows.Forms.Button();
            this.newReportLabel = new global::System.Windows.Forms.Label();
            this.reportRichTextBox = new global::System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            resources.ApplyResources(this.reportButton, "reportButton");
            this.reportButton.Name = "reportButton";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new global::System.EventHandler(this.reportButton_Click);
            // 
            // newReportLabel
            // 
            resources.ApplyResources(this.newReportLabel, "newReportLabel");
            this.newReportLabel.Name = "newReportLabel";
            // 
            // reportRichTextBox
            // 
            resources.ApplyResources(this.reportRichTextBox, "reportRichTextBox");
            this.reportRichTextBox.Name = "reportRichTextBox";
            // 
            // NewUserReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.newReportLabel);
            this.Controls.Add(this.reportRichTextBox);
            this.Name = "NewUserReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Button reportButton;
        private global::System.Windows.Forms.Label newReportLabel;
        private global::System.Windows.Forms.RichTextBox reportRichTextBox;
    }
}