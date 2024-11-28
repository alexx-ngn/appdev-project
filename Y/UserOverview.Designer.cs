namespace Y
{
    partial class UserOverview
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Home");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Search");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("My Profile");
            this.sideviewPanel = new System.Windows.Forms.Panel();
            this.postButton = new System.Windows.Forms.Button();
            this.sideListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.overviewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profile1 = new Y.Profile();
            this.profile2 = new Y.Profile();
            this.profile3 = new Y.Profile();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchEnterButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.MyPostsLabel = new System.Windows.Forms.Label();
            this.MyPostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OverviewTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.sideviewPanel.SuspendLayout();
            this.searchFlowLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.OverviewTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideviewPanel
            // 
            this.sideviewPanel.Controls.Add(this.postButton);
            this.sideviewPanel.Controls.Add(this.sideListView);
            this.sideviewPanel.Location = new System.Drawing.Point(12, 147);
            this.sideviewPanel.Name = "sideviewPanel";
            this.sideviewPanel.Size = new System.Drawing.Size(123, 409);
            this.sideviewPanel.TabIndex = 7;
            // 
            // postButton
            // 
            this.postButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postButton.Location = new System.Drawing.Point(0, 386);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(123, 23);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // sideListView
            // 
            this.sideListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.sideListView.Location = new System.Drawing.Point(0, 0);
            this.sideListView.Name = "sideListView";
            this.sideListView.Size = new System.Drawing.Size(123, 409);
            this.sideListView.TabIndex = 1;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            this.sideListView.SelectedIndexChanged += new System.EventHandler(this.sideListView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // overviewFlowLayoutPanel
            // 
            this.overviewFlowLayoutPanel.AutoScroll = true;
            this.overviewFlowLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            this.overviewFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overviewFlowLayoutPanel.Size = new System.Drawing.Size(725, 480);
            this.overviewFlowLayoutPanel.TabIndex = 9;
            // 
            // searchFlowLayoutPanel
            // 
            this.searchFlowLayoutPanel.AutoScroll = true;
            this.searchFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchFlowLayoutPanel.Controls.Add(this.profile1);
            this.searchFlowLayoutPanel.Controls.Add(this.profile2);
            this.searchFlowLayoutPanel.Controls.Add(this.profile3);
            this.searchFlowLayoutPanel.Location = new System.Drawing.Point(4, 40);
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            this.searchFlowLayoutPanel.Size = new System.Drawing.Size(721, 477);
            this.searchFlowLayoutPanel.TabIndex = 10;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(3, 3);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(661, 148);
            this.profile1.TabIndex = 0;
            // 
            // profile2
            // 
            this.profile2.Location = new System.Drawing.Point(3, 157);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(665, 148);
            this.profile2.TabIndex = 1;
            // 
            // profile3
            // 
            this.profile3.Location = new System.Drawing.Point(3, 311);
            this.profile3.Name = "profile3";
            this.profile3.Size = new System.Drawing.Size(665, 148);
            this.profile3.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(-2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(119, 32);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(123, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(177, 30);
            this.searchTextBox.TabIndex = 12;
            // 
            // searchEnterButton
            // 
            this.searchEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEnterButton.Location = new System.Drawing.Point(306, 2);
            this.searchEnterButton.Name = "searchEnterButton";
            this.searchEnterButton.Size = new System.Drawing.Size(32, 32);
            this.searchEnterButton.TabIndex = 13;
            this.searchEnterButton.Text = "🔍";
            this.searchEnterButton.UseVisualStyleBackColor = true;
            this.searchEnterButton.Click += new System.EventHandler(this.searchEnterButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchEnterButton);
            this.searchPanel.Controls.Add(this.searchFlowLayoutPanel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(878, 539);
            this.searchPanel.TabIndex = 14;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.overviewLabel);
            this.homePanel.Controls.Add(this.overviewFlowLayoutPanel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 3);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(878, 539);
            this.homePanel.TabIndex = 15;
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.Location = new System.Drawing.Point(3, 10);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(140, 32);
            this.overviewLabel.TabIndex = 10;
            this.overviewLabel.Text = "Overview";
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.MyPostsLabel);
            this.profilePanel.Controls.Add(this.MyPostsFlowLayoutPanel);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(884, 545);
            this.profilePanel.TabIndex = 16;
            // 
            // MyPostsLabel
            // 
            this.MyPostsLabel.AutoSize = true;
            this.MyPostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPostsLabel.Location = new System.Drawing.Point(3, 0);
            this.MyPostsLabel.Name = "MyPostsLabel";
            this.MyPostsLabel.Size = new System.Drawing.Size(137, 32);
            this.MyPostsLabel.TabIndex = 12;
            this.MyPostsLabel.Text = "My Posts";
            // 
            // MyPostsFlowLayoutPanel
            // 
            this.MyPostsFlowLayoutPanel.AutoScroll = true;
            this.MyPostsFlowLayoutPanel.Location = new System.Drawing.Point(0, 35);
            this.MyPostsFlowLayoutPanel.Name = "MyPostsFlowLayoutPanel";
            this.MyPostsFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyPostsFlowLayoutPanel.Size = new System.Drawing.Size(725, 510);
            this.MyPostsFlowLayoutPanel.TabIndex = 11;
            // 
            // OverviewTabControl
            // 
            this.OverviewTabControl.Controls.Add(this.homeTab);
            this.OverviewTabControl.Controls.Add(this.searchTab);
            this.OverviewTabControl.Controls.Add(this.profileTab);
            this.OverviewTabControl.Location = new System.Drawing.Point(141, 8);
            this.OverviewTabControl.Name = "OverviewTabControl";
            this.OverviewTabControl.SelectedIndex = 0;
            this.OverviewTabControl.Size = new System.Drawing.Size(892, 574);
            this.OverviewTabControl.TabIndex = 17;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePanel);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(884, 545);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchPanel);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(884, 545);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.profilePanel);
            this.profileTab.Location = new System.Drawing.Point(4, 25);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(884, 545);
            this.profileTab.TabIndex = 2;
            this.profileTab.Text = "My Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.OverviewTabControl);
            this.Controls.Add(this.sideviewPanel);
            this.Name = "UserOverview";
            this.Text = "User Overview";
            this.Load += new System.EventHandler(this.UserOverview_Load);
            this.Controls.SetChildIndex(this.sideviewPanel, 0);
            this.Controls.SetChildIndex(this.OverviewTabControl, 0);
            this.sideviewPanel.ResumeLayout(false);
            this.searchFlowLayoutPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.OverviewTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideviewPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView sideListView;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.FlowLayoutPanel overviewFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
        private Profile profile1;
        private Profile profile2;
        private Profile profile3;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchEnterButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabControl OverviewTabControl;
        private System.Windows.Forms.Label MyPostsLabel;
        private System.Windows.Forms.FlowLayoutPanel MyPostsFlowLayoutPanel;
    }
}
