namespace Y.view.admin
{
    partial class UserReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReport));
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameProfile = new System.Windows.Forms.Label();
            this.allowButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PostsFlowLayoutPanel
            // 
            resources.ApplyResources(this.PostsFlowLayoutPanel, "PostsFlowLayoutPanel");
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            // 
            // usernameProfile
            // 
            resources.ApplyResources(this.usernameProfile, "usernameProfile");
            this.usernameProfile.Name = "usernameProfile";
            // 
            // allowButton
            // 
            resources.ApplyResources(this.allowButton, "allowButton");
            this.allowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allowButton.Name = "allowButton";
            this.allowButton.UseVisualStyleBackColor = true;
            this.allowButton.Click += new System.EventHandler(this.allowButton_Click);
            // 
            // banButton
            // 
            resources.ApplyResources(this.banButton, "banButton");
            this.banButton.ForeColor = System.Drawing.Color.Red;
            this.banButton.Name = "banButton";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // UserReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.usernameProfile);
            this.Name = "UserReport";
            this.Load += new System.EventHandler(this.UserReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private global::System.Windows.Forms.Label usernameProfile;
        private global::System.Windows.Forms.Button allowButton;
        private global::System.Windows.Forms.Button banButton;
    }
}