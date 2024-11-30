namespace Y
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.followButton = new System.Windows.Forms.Button();
            this.usernameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // followButton
            // 
            resources.ApplyResources(this.followButton, "followButton");
            this.followButton.Name = "followButton";
            this.followButton.UseVisualStyleBackColor = true;
            this.followButton.Click += new System.EventHandler(this.followButton_Click);
            // 
            // usernameLinkLabel
            // 
            resources.ApplyResources(this.usernameLinkLabel, "usernameLinkLabel");
            this.usernameLinkLabel.Name = "usernameLinkLabel";
            this.usernameLinkLabel.TabStop = true;
            this.usernameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernameLinkLabel_LinkClicked);
            // 
            // reportButton
            // 
            resources.ApplyResources(this.reportButton, "reportButton");
            this.reportButton.Name = "reportButton";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Profile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.usernameLinkLabel);
            this.Controls.Add(this.followButton);
            this.Name = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button followButton;
        private System.Windows.Forms.LinkLabel usernameLinkLabel;
        private System.Windows.Forms.Button reportButton;
    }
}
