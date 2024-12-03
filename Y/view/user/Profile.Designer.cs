namespace Y
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.followButton = new global::System.Windows.Forms.Button();
            this.usernameLinkLabel = new global::System.Windows.Forms.LinkLabel();
            this.reportButton = new global::System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // followButton
            // 
            resources.ApplyResources(this.followButton, "followButton");
            this.followButton.Name = "followButton";
            this.followButton.UseVisualStyleBackColor = true;
            this.followButton.Click += new global::System.EventHandler(this.followButton_Click);
            // 
            // usernameLinkLabel
            // 
            resources.ApplyResources(this.usernameLinkLabel, "usernameLinkLabel");
            this.usernameLinkLabel.Name = "usernameLinkLabel";
            this.usernameLinkLabel.TabStop = true;
            this.usernameLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernameLinkLabel_LinkClicked);
            // 
            // reportButton
            // 
            resources.ApplyResources(this.reportButton, "reportButton");
            this.reportButton.Name = "reportButton";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new global::System.EventHandler(this.reportButton_Click);
            // 
            // Profile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.usernameLinkLabel);
            this.Controls.Add(this.followButton);
            this.Name = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::System.Windows.Forms.Button followButton;
        private global::System.Windows.Forms.LinkLabel usernameLinkLabel;
        private global::System.Windows.Forms.Button reportButton;
    }
}
