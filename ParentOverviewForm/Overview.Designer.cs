namespace Y
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
            YLabel.Location = new Point(62, 24);
            YLabel.Margin = new Padding(2, 0, 2, 0);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(50, 55);
            YLabel.TabIndex = 8;
            YLabel.Text = "𝕐";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(33, 79);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(112, 42);
            welcomeLabel.TabIndex = 9;
            welcomeLabel.Text = "Welcome User";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // contentListView
            // 
            contentListView.Location = new Point(243, 52);
            contentListView.Margin = new Padding(4, 3, 4, 3);
            contentListView.Name = "contentListView";
            contentListView.Size = new Size(447, 453);
            contentListView.TabIndex = 10;
            contentListView.UseCompatibleStateImageBehavior = false;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeLabel.Location = new Point(238, 25);
            homeLabel.Margin = new Padding(4, 0, 4, 0);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(56, 20);
            homeLabel.TabIndex = 11;
            homeLabel.Text = "Home";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(698, 52);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(221, 22);
            searchTextBox.TabIndex = 12;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(693, 25);
            searchLabel.Margin = new Padding(4, 0, 4, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(66, 20);
            searchLabel.TabIndex = 13;
            searchLabel.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(832, 89);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 27);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(searchButton);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Controls.Add(homeLabel);
            Controls.Add(contentListView);
            Controls.Add(welcomeLabel);
            Controls.Add(YLabel);
            Margin = new Padding(4, 3, 4, 3);
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