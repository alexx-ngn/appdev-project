namespace Y.view
{
    partial class ReasonUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReasonUserControl));
            this.reporterLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reporterLabel
            // 
            this.reporterLabel.AutoSize = true;
            this.reporterLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.reporterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterLabel.Location = new System.Drawing.Point(0, 0);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(149, 32);
            this.reporterLabel.TabIndex = 0;
            this.reporterLabel.Text = "Reporter: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(1107, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(93, 32);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "DATE";
            // 
            // reasonLabel
            // 
            this.reasonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.Location = new System.Drawing.Point(5, 39);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(1190, 184);
            this.reasonLabel.TabIndex = 9;
            this.reasonLabel.Text = resources.GetString("reasonLabel.Text");
            // 
            // ReasonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.reporterLabel);
            this.Name = "ReasonUserControl";
            this.Size = new System.Drawing.Size(1200, 262);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label reasonLabel;
    }
}
