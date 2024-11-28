namespace Y
{
    partial class NewPost
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
            this.postRichTextBox = new System.Windows.Forms.RichTextBox();
            this.newPostLabel = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postRichTextBox
            // 
            this.postRichTextBox.Location = new System.Drawing.Point(12, 41);
            this.postRichTextBox.Name = "postRichTextBox";
            this.postRichTextBox.Size = new System.Drawing.Size(607, 96);
            this.postRichTextBox.TabIndex = 0;
            this.postRichTextBox.Text = "";
            // 
            // newPostLabel
            // 
            this.newPostLabel.AutoSize = true;
            this.newPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPostLabel.Location = new System.Drawing.Point(12, 18);
            this.newPostLabel.Name = "newPostLabel";
            this.newPostLabel.Size = new System.Drawing.Size(191, 20);
            this.newPostLabel.TabIndex = 1;
            this.newPostLabel.Text = "What\'s on your mind?";
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(544, 143);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // NewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 189);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.newPostLabel);
            this.Controls.Add(this.postRichTextBox);
            this.Name = "NewPost";
            this.Text = "New Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox postRichTextBox;
        private System.Windows.Forms.Label newPostLabel;
        private System.Windows.Forms.Button postButton;
    }
}