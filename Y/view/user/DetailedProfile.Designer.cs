namespace Y
{
    partial class DetailedProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedProfile));
            this.profileLabel = new System.Windows.Forms.Label();
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.post1 = new Y.UserPost();
            this.post2 = new Y.UserPost();
            this.post3 = new Y.UserPost();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileLabel
            // 
            resources.ApplyResources(this.profileLabel, "profileLabel");
            this.profileLabel.Name = "profileLabel";
            // 
            // PostsFlowLayoutPanel
            // 
            resources.ApplyResources(this.PostsFlowLayoutPanel, "PostsFlowLayoutPanel");
            this.PostsFlowLayoutPanel.Controls.Add(this.post1);
            this.PostsFlowLayoutPanel.Controls.Add(this.post2);
            this.PostsFlowLayoutPanel.Controls.Add(this.post3);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            // 
            // post1
            // 
            resources.ApplyResources(this.post1, "post1");
            this.post1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post1.Name = "post1";
            // 
            // post2
            // 
            resources.ApplyResources(this.post2, "post2");
            this.post2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post2.Name = "post2";
            // 
            // post3
            // 
            resources.ApplyResources(this.post3, "post3");
            this.post3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post3.Name = "post3";
            // 
            // DetailedProfile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.profileLabel);
            this.Name = "DetailedProfile";
            this.Load += new System.EventHandler(this.DetailedProfile_Load);
            this.PostsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label profileLabel;
        private global::System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private UserPost post1;
        private UserPost post2;
        private UserPost post3;
    }
}