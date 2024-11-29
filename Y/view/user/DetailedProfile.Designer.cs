namespace Y
{
    partial class DetailedProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.post1 = new Y.Post();
            this.post2 = new Y.Post();
            this.post3 = new Y.Post();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME PROFILE";
            // 
            // PostsFlowLayoutPanel
            // 
            this.PostsFlowLayoutPanel.AutoScroll = true;
            this.PostsFlowLayoutPanel.Controls.Add(this.post1);
            this.PostsFlowLayoutPanel.Controls.Add(this.post2);
            this.PostsFlowLayoutPanel.Controls.Add(this.post3);
            this.PostsFlowLayoutPanel.Location = new System.Drawing.Point(18, 44);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            this.PostsFlowLayoutPanel.Size = new System.Drawing.Size(1282, 394);
            this.PostsFlowLayoutPanel.TabIndex = 1;
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
            // DetailedProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 450);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "DetailedProfile";
            this.Text = "USERNAME Profile";
            this.PostsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private Post post1;
        private Post post2;
        private Post post3;
    }
}