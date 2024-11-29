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
            this.PostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.adminPost1 = new Y.view.admin.AdminPost();
            this.adminPost2 = new Y.view.admin.AdminPost();
            this.adminPost3 = new Y.view.admin.AdminPost();
            this.PostsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostsFlowLayoutPanel
            // 
            this.PostsFlowLayoutPanel.AutoScroll = true;
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost1);
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost2);
            this.PostsFlowLayoutPanel.Controls.Add(this.adminPost3);
            this.PostsFlowLayoutPanel.Location = new System.Drawing.Point(15, 44);
            this.PostsFlowLayoutPanel.Name = "PostsFlowLayoutPanel";
            this.PostsFlowLayoutPanel.Size = new System.Drawing.Size(1282, 394);
            this.PostsFlowLayoutPanel.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(316, 32);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "USERNAME PROFILE";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(1033, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(242, 32);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "DATE CREATED";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(345, 8);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 33);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "BAN";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // adminPost1
            // 
            this.adminPost1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPost1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost1.Location = new System.Drawing.Point(3, 3);
            this.adminPost1.Name = "adminPost1";
            this.adminPost1.Size = new System.Drawing.Size(1196, 301);
            this.adminPost1.TabIndex = 0;
            // 
            // adminPost2
            // 
            this.adminPost2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost2.Location = new System.Drawing.Point(3, 310);
            this.adminPost2.Name = "adminPost2";
            this.adminPost2.Size = new System.Drawing.Size(1196, 301);
            this.adminPost2.TabIndex = 1;
            // 
            // adminPost3
            // 
            this.adminPost3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPost3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPost3.Location = new System.Drawing.Point(3, 617);
            this.adminPost3.Name = "adminPost3";
            this.adminPost3.Size = new System.Drawing.Size(1196, 301);
            this.adminPost3.TabIndex = 2;
            // 
            // DetailedProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.PostsFlowLayoutPanel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "DetailedProfileAdmin";
            this.Text = "Username Profile";
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