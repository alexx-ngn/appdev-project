namespace ParentOverviewForm
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
            YLabel = new Label();
            welcomeLabel = new Label();
            contentListView = new ListView();
            homeLabel = new Label();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            searchButton = new Button();
            SuspendLayout();
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YLabel.Location = new Point(71, 32);
            YLabel.Margin = new Padding(2, 0, 2, 0);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(63, 69);
            YLabel.TabIndex = 8;
            YLabel.Text = "𝕐";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(38, 105);
            welcomeLabel.Margin = new Padding(5, 0, 5, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(128, 56);
            welcomeLabel.TabIndex = 9;
            welcomeLabel.Text = "Welcome User";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // contentListView
            // 
            contentListView.Location = new Point(278, 69);
            contentListView.Margin = new Padding(5, 4, 5, 4);
            contentListView.Name = "contentListView";
            contentListView.Size = new Size(510, 603);
            contentListView.TabIndex = 10;
            contentListView.UseCompatibleStateImageBehavior = false;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeLabel.Location = new Point(272, 33);
            homeLabel.Margin = new Padding(5, 0, 5, 0);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(68, 25);
            homeLabel.TabIndex = 11;
            homeLabel.Text = "Home";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(798, 69);
            searchTextBox.Margin = new Padding(5, 4, 5, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(252, 26);
            searchTextBox.TabIndex = 12;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(792, 33);
            searchLabel.Margin = new Padding(5, 0, 5, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(81, 25);
            searchLabel.TabIndex = 13;
            searchLabel.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(949, 103);
            searchButton.Margin = new Padding(5, 4, 5, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(101, 36);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 692);
            Controls.Add(searchButton);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Controls.Add(homeLabel);
            Controls.Add(contentListView);
            Controls.Add(welcomeLabel);
            Controls.Add(YLabel);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Overview";
            Text = "Overview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListView contentListView;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
    }
}