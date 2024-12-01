namespace Y.view.admin
{
    partial class DetailedProfileAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedProfileAdmin));
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminPost1 = new Y.view.admin.AdminPost();
            this.adminPost2 = new Y.view.admin.AdminPost();
            this.adminPost3 = new Y.view.admin.AdminPost();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostsFlowLayoutPanel
            // 
            resources.ApplyResources(this.PostsFlowLayoutPanel, "PostsFlowLayoutPanel");
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost1);
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost2);
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost3);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            // 
            // adminPost1
            // 
            resources.ApplyResources(this.adminPost1, "adminPost1");
            this.adminPost1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost1.Name = "adminPost1";
            // 
            // adminPost2
            // 
            resources.ApplyResources(this.adminPost2, "adminPost2");
            this.adminPost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost2.Name = "adminPost2";
            // 
            // adminPost3
            // 
            resources.ApplyResources(this.adminPost3, "adminPost3");
            this.adminPost3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost3.Name = "adminPost3";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DetailedProfileAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "DetailedProfileAdmin";
            this.PostsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PostsFlowLayoutPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label dateLabel;
        private AdminPost adminPost1;
        private AdminPost adminPost2;
        private AdminPost adminPost3;
        private System.Windows.Forms.Button deleteButton;
    }
}