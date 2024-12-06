namespace Y.view.admin
{
    partial class PostReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostReport));
            this.banButton = new System.Windows.Forms.Button();
            this.allowButton = new System.Windows.Forms.Button();
            this.userPost = new Y.UserPost();
            this.reasonUserControl = new Y.view.ReasonUserControl();
            this.SuspendLayout();
            // 
            // banButton
            // 
            resources.ApplyResources(this.banButton, "banButton");
            this.banButton.ForeColor = System.Drawing.Color.Red;
            this.banButton.Name = "banButton";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // allowButton
            // 
            resources.ApplyResources(this.allowButton, "allowButton");
            this.allowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allowButton.Name = "allowButton";
            this.allowButton.UseVisualStyleBackColor = true;
            this.allowButton.Click += new System.EventHandler(this.allowButton_Click);
            // 
            // userPost
            // 
            resources.ApplyResources(this.userPost, "userPost");
            this.userPost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPost.Name = "userPost";
            // 
            // reasonUserControl
            // 
            resources.ApplyResources(this.reasonUserControl, "reasonUserControl");
            this.reasonUserControl.Name = "reasonUserControl";
            // 
            // PostReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.reasonUserControl);
            this.Controls.Add(this.userPost);
            this.Name = "PostReport";
            this.Load += new System.EventHandler(this.PostReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserPost userPost;
        private global::System.Windows.Forms.Button banButton;
        private global::System.Windows.Forms.Button allowButton;
        private ReasonUserControl reasonUserControl;
    }
}