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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(UserReport));
            this.PostsFlowLayoutPanel = new global::System.Windows.Forms.FlowLayoutPanel();
            this.post1 = new Y.UserPost();
            this.post2 = new Y.UserPost();
            this.post3 = new Y.UserPost();
            this.label1 = new global::System.Windows.Forms.Label();
            this.allowButton = new global::System.Windows.Forms.Button();
            this.banButton = new global::System.Windows.Forms.Button();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.post1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            this.post1.Name = "post1";
            // 
            // post2
            // 
            resources.ApplyResources(this.post2, "post2");
            this.post2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            this.post2.Name = "post2";
            // 
            // post3
            // 
            resources.ApplyResources(this.post3, "post3");
            this.post3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            this.post3.Name = "post3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // allowButton
            // 
            resources.ApplyResources(this.allowButton, "allowButton");
            this.allowButton.ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allowButton.Name = "allowButton";
            this.allowButton.UseVisualStyleBackColor = true;
            this.allowButton.Click += new global::System.EventHandler(this.allowButton_Click);
            // 
            // banButton
            // 
            resources.ApplyResources(this.banButton, "banButton");
            this.banButton.ForeColor = global::System.Drawing.Color.Red;
            this.banButton.Name = "banButton";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new global::System.EventHandler(this.banButton_Click);
            // 
            // UserReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "UserReport";
            this.PostsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private UserPost post1;
        private UserPost post2;
        private UserPost post3;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Button allowButton;
        private global::System.Windows.Forms.Button banButton;
    }
}