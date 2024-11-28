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
            this.post4 = new Y.Post();
            this.post5 = new Y.Post();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // PostsFlowLayoutPanel
            // 
            this.PostsFlowLayoutPanel.AutoScroll = true;
            this.PostsFlowLayoutPanel.Controls.Add(this.post1);
            this.PostsFlowLayoutPanel.Controls.Add(this.post2);
            this.PostsFlowLayoutPanel.Controls.Add(this.post3);
            this.PostsFlowLayoutPanel.Controls.Add(this.post4);
            this.PostsFlowLayoutPanel.Controls.Add(this.post5);
            this.PostsFlowLayoutPanel.Location = new System.Drawing.Point(18, 44);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            this.PostsFlowLayoutPanel.Size = new System.Drawing.Size(770, 394);
            this.PostsFlowLayoutPanel.TabIndex = 1;
            // 
            // post1
            // 
            this.post1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post1.Location = new System.Drawing.Point(3, 3);
            this.post1.Name = "post1";
            this.post1.Size = new System.Drawing.Size(665, 148);
            this.post1.TabIndex = 0;
            // 
            // post2
            // 
            this.post2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post2.Location = new System.Drawing.Point(674, 3);
            this.post2.Name = "post2";
            this.post2.Size = new System.Drawing.Size(8, 8);
            this.post2.TabIndex = 1;
            // 
            // post3
            // 
            this.post3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post3.Location = new System.Drawing.Point(3, 157);
            this.post3.Name = "post3";
            this.post3.Size = new System.Drawing.Size(665, 148);
            this.post3.TabIndex = 2;
            // 
            // post4
            // 
            this.post4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post4.Location = new System.Drawing.Point(3, 311);
            this.post4.Name = "post4";
            this.post4.Size = new System.Drawing.Size(665, 148);
            this.post4.TabIndex = 3;
            // 
            // post5
            // 
            this.post5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post5.Location = new System.Drawing.Point(3, 465);
            this.post5.Name = "post5";
            this.post5.Size = new System.Drawing.Size(665, 148);
            this.post5.TabIndex = 4;
            // 
            // DetailedProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private Post post4;
        private Post post5;
    }
}