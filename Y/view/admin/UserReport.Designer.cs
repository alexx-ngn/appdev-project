namespace Y.view.admin
{
    partial class UserReport
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
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.post1 = new Y.UserPost();
            this.post2 = new Y.UserPost();
            this.post3 = new Y.UserPost();
            this.label1 = new System.Windows.Forms.Label();
            this.allowButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostsFlowLayoutPanel
            // 
            this.PostsFlowLayoutPanel.AutoScroll = true;
            this.PostsFlowLayoutPanel.Controls.Add(this.post1);
            this.PostsFlowLayoutPanel.Controls.Add(this.post2);
            this.PostsFlowLayoutPanel.Controls.Add(this.post3);
            this.PostsFlowLayoutPanel.Location = new System.Drawing.Point(18, 44);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            this.PostsFlowLayoutPanel.Size = new System.Drawing.Size(1260, 487);
            this.PostsFlowLayoutPanel.TabIndex = 3;
            // 
            // post1
            // 
            this.post1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post1.Location = new System.Drawing.Point(3, 3);
            this.post1.Name = "post1";
            this.post1.Size = new System.Drawing.Size(1200, 300);
            this.post1.TabIndex = 0;
            // 
            // post2
            // 
            this.post2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post2.Location = new System.Drawing.Point(3, 309);
            this.post2.Name = "post2";
            this.post2.Size = new System.Drawing.Size(1200, 300);
            this.post2.TabIndex = 1;
            // 
            // post3
            // 
            this.post3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post3.Location = new System.Drawing.Point(3, 615);
            this.post3.Name = "post3";
            this.post3.Size = new System.Drawing.Size(1200, 300);
            this.post3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME PROFILE";
            // 
            // allowButton
            // 
            this.allowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allowButton.Location = new System.Drawing.Point(1081, 547);
            this.allowButton.Name = "allowButton";
            this.allowButton.Size = new System.Drawing.Size(103, 33);
            this.allowButton.TabIndex = 21;
            this.allowButton.Text = "DISMISS";
            this.allowButton.UseVisualStyleBackColor = true;
            this.allowButton.Click += new System.EventHandler(this.allowButton_Click);
            // 
            // banButton
            // 
            this.banButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banButton.ForeColor = System.Drawing.Color.Red;
            this.banButton.Location = new System.Drawing.Point(1190, 547);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(72, 33);
            this.banButton.TabIndex = 20;
            this.banButton.Text = "BAN";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 592);
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "UserReport";
            this.Text = "UserReport";
            this.PostsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private UserPost post1;
        private UserPost post2;
        private UserPost post3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button allowButton;
        private System.Windows.Forms.Button banButton;
    }
}