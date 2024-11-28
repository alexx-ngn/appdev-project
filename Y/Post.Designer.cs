namespace Y
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.likeCounterLabel = new System.Windows.Forms.Label();
            this.likeButton = new System.Windows.Forms.Button();
            this.repostButton = new System.Windows.Forms.Button();
            this.repostCounterLabel = new System.Windows.Forms.Label();
            this.postContentLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "USERNAME";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(617, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 16);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "DATE";
            // 
            // likeCounterLabel
            // 
            this.likeCounterLabel.AutoSize = true;
            this.likeCounterLabel.Location = new System.Drawing.Point(589, 116);
            this.likeCounterLabel.Name = "likeCounterLabel";
            this.likeCounterLabel.Size = new System.Drawing.Size(14, 16);
            this.likeCounterLabel.TabIndex = 5;
            this.likeCounterLabel.Text = "0";
            this.likeCounterLabel.Click += new System.EventHandler(this.likeCounterLabel_Click);
            // 
            // likeButton
            // 
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.Location = new System.Drawing.Point(550, 107);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(33, 32);
            this.likeButton.TabIndex = 4;
            this.likeButton.Text = "👍";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // repostButton
            // 
            this.repostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repostButton.Location = new System.Drawing.Point(609, 107);
            this.repostButton.Name = "repostButton";
            this.repostButton.Size = new System.Drawing.Size(33, 32);
            this.repostButton.TabIndex = 6;
            this.repostButton.Text = "🔁";
            this.repostButton.UseVisualStyleBackColor = true;
            // 
            // repostCounterLabel
            // 
            this.repostCounterLabel.AutoSize = true;
            this.repostCounterLabel.Location = new System.Drawing.Point(648, 116);
            this.repostCounterLabel.Name = "repostCounterLabel";
            this.repostCounterLabel.Size = new System.Drawing.Size(14, 16);
            this.repostCounterLabel.TabIndex = 7;
            this.repostCounterLabel.Text = "0";
            // 
            // postContentLabel
            // 
            this.postContentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postContentLabel.Location = new System.Drawing.Point(3, 16);
            this.postContentLabel.Name = "postContentLabel";
            this.postContentLabel.Size = new System.Drawing.Size(639, 88);
            this.postContentLabel.TabIndex = 8;
            this.postContentLabel.Text = resources.GetString("postContentLabel.Text");
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(3, 107);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(33, 32);
            this.reportButton.TabIndex = 10;
            this.reportButton.Text = "⚠️";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.postContentLabel);
            this.Controls.Add(this.repostCounterLabel);
            this.Controls.Add(this.repostButton);
            this.Controls.Add(this.likeCounterLabel);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(665, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label likeCounterLabel;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button repostButton;
        private System.Windows.Forms.Label repostCounterLabel;
        private System.Windows.Forms.Label postContentLabel;
        private System.Windows.Forms.Button reportButton;
    }
}
