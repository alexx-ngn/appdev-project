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
            this.profileDescriptionLabel = new System.Windows.Forms.Label();
            this.followButton = new System.Windows.Forms.Button();
            this.usernameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // profileDescriptionLabel
            // 
            this.profileDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileDescriptionLabel.Location = new System.Drawing.Point(6, 51);
            this.profileDescriptionLabel.Name = "profileDescriptionLabel";
            this.profileDescriptionLabel.Size = new System.Drawing.Size(639, 88);
            this.profileDescriptionLabel.TabIndex = 9;
            this.profileDescriptionLabel.Text = resources.GetString("profileDescriptionLabel.Text");
            // 
            // followButton
            // 
            this.followButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followButton.Location = new System.Drawing.Point(527, 10);
            this.followButton.Name = "followButton";
            this.followButton.Size = new System.Drawing.Size(118, 38);
            this.followButton.TabIndex = 10;
            this.followButton.Text = "Follow";
            this.followButton.UseVisualStyleBackColor = true;
            this.followButton.Click += new System.EventHandler(this.followButton_Click);
            // 
            // usernameLinkLabel
            // 
            this.usernameLinkLabel.AutoSize = true;
            this.usernameLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLinkLabel.Location = new System.Drawing.Point(3, 21);
            this.usernameLinkLabel.Name = "usernameLinkLabel";
            this.usernameLinkLabel.Size = new System.Drawing.Size(92, 16);
            this.usernameLinkLabel.TabIndex = 11;
            this.usernameLinkLabel.TabStop = true;
            this.usernameLinkLabel.Text = "USERNAME";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usernameLinkLabel);
            this.Controls.Add(this.followButton);
            this.Controls.Add(this.profileDescriptionLabel);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(665, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label profileDescriptionLabel;
        private System.Windows.Forms.Button followButton;
        private System.Windows.Forms.LinkLabel usernameLinkLabel;
    }
}
