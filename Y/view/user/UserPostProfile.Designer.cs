namespace Y.view.user
{
    partial class UserPostProfile
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
            this.repostCounterLabel = new System.Windows.Forms.Label();
            this.repostButton = new System.Windows.Forms.Button();
            this.likeCounterLabel = new System.Windows.Forms.Label();
            this.likeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(3, 237);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(66, 66);
            this.reportButton.TabIndex = 15;
            this.reportButton.Text = "⚠️";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // repostCounterLabel
            // 
            this.repostCounterLabel.AutoSize = true;
            this.repostCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repostCounterLabel.Location = new System.Drawing.Point(1163, 256);
            this.repostCounterLabel.Name = "repostCounterLabel";
            this.repostCounterLabel.Size = new System.Drawing.Size(30, 32);
            this.repostCounterLabel.TabIndex = 14;
            this.repostCounterLabel.Text = "0";
            // 
            // repostButton
            // 
            this.repostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repostButton.Location = new System.Drawing.Point(1091, 237);
            this.repostButton.Name = "repostButton";
            this.repostButton.Size = new System.Drawing.Size(66, 66);
            this.repostButton.TabIndex = 13;
            this.repostButton.Text = "🔁";
            this.repostButton.UseVisualStyleBackColor = true;
            // 
            // likeCounterLabel
            // 
            this.likeCounterLabel.AutoSize = true;
            this.likeCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeCounterLabel.Location = new System.Drawing.Point(1055, 256);
            this.likeCounterLabel.Name = "likeCounterLabel";
            this.likeCounterLabel.Size = new System.Drawing.Size(30, 32);
            this.likeCounterLabel.TabIndex = 12;
            this.likeCounterLabel.Text = "0";
            // 
            // likeButton
            // 
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.Location = new System.Drawing.Point(983, 237);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(66, 66);
            this.likeButton.TabIndex = 11;
            this.likeButton.Text = "👍";
            this.likeButton.UseVisualStyleBackColor = true;
            // 
            // UserPostProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.repostCounterLabel);
            this.Controls.Add(this.repostButton);
            this.Controls.Add(this.likeCounterLabel);
            this.Controls.Add(this.likeButton);
            this.Name = "UserPostProfile";
            this.Size = new System.Drawing.Size(1196, 310);
            this.Controls.SetChildIndex(this.likeButton, 0);
            this.Controls.SetChildIndex(this.likeCounterLabel, 0);
            this.Controls.SetChildIndex(this.repostButton, 0);
            this.Controls.SetChildIndex(this.repostCounterLabel, 0);
            this.Controls.SetChildIndex(this.reportButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label repostCounterLabel;
        private System.Windows.Forms.Button repostButton;
        private System.Windows.Forms.Label likeCounterLabel;
        private System.Windows.Forms.Button likeButton;
    }
}
