﻿namespace Overview
{
    partial class Overview
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(876, 19);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(75, 25);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(881, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(202, 22);
            this.searchTextBox.TabIndex = 5;
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.Location = new System.Drawing.Point(141, 19);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(102, 25);
            this.overviewLabel.TabIndex = 4;
            this.overviewLabel.Text = "Overview";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(21, 100);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(97, 16);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome User";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(12, -19);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(123, 135);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "𝕐";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1008, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(24, 119);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 27);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.overviewLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.YLabel);
            this.Name = "Overview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logoutButton;
    }
}
