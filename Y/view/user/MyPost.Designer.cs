namespace Y
{
    partial class MyPost
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.repostButton = new System.Windows.Forms.Button();
            this.likeCounterLabel = new System.Windows.Forms.Label();
            this.likeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(84, 289);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 82);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "🗑️";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(3, 289);
            this.reportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(74, 82);
            this.reportButton.TabIndex = 16;
            this.reportButton.Text = "⚠️";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // repostButton
            // 
            this.repostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repostButton.Location = new System.Drawing.Point(1227, 289);
            this.repostButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repostButton.Name = "repostButton";
            this.repostButton.Size = new System.Drawing.Size(74, 82);
            this.repostButton.TabIndex = 14;
            this.repostButton.Text = "🔁";
            this.repostButton.UseVisualStyleBackColor = true;
            this.repostButton.Click += new System.EventHandler(this.repostButton_Click);
            // 
            // likeCounterLabel
            // 
            this.likeCounterLabel.AutoSize = true;
            this.likeCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeCounterLabel.Location = new System.Drawing.Point(1187, 312);
            this.likeCounterLabel.Name = "likeCounterLabel";
            this.likeCounterLabel.Size = new System.Drawing.Size(35, 38);
            this.likeCounterLabel.TabIndex = 13;
            this.likeCounterLabel.Text = "0";
            // 
            // likeButton
            // 
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.Location = new System.Drawing.Point(1106, 289);
            this.likeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(74, 82);
            this.likeButton.TabIndex = 12;
            this.likeButton.Text = "👍";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // MyPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.repostButton);
            this.Controls.Add(this.likeCounterLabel);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.deleteButton);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MyPost";
            this.Size = new System.Drawing.Size(1346, 384);
            this.Load += new System.EventHandler(this.MyPost_Load);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.likeButton, 0);
            this.Controls.SetChildIndex(this.likeCounterLabel, 0);
            this.Controls.SetChildIndex(this.repostButton, 0);
            this.Controls.SetChildIndex(this.reportButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Button deleteButton;
        private global::System.Windows.Forms.Button reportButton;
        private global::System.Windows.Forms.Button repostButton;
        private global::System.Windows.Forms.Label likeCounterLabel;
        private global::System.Windows.Forms.Button likeButton;
    }
}
