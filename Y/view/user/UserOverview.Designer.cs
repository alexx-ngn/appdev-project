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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Home"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Search"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "My Profile"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.sideviewPanel = new System.Windows.Forms.Panel();
            this.sideListView = new System.Windows.Forms.ListView();
            this.postButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.overviewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profile1 = new Y.Profile();
            this.profile2 = new Y.Profile();
            this.profile3 = new Y.Profile();
            this.profile4 = new Y.Profile();
            this.profile5 = new Y.Profile();
            this.profile6 = new Y.Profile();
            this.profile7 = new Y.Profile();
            this.profile8 = new Y.Profile();
            this.profile9 = new Y.Profile();
            this.profile10 = new Y.Profile();
            this.profile11 = new Y.Profile();
            this.sideviewPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.OverviewTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.searchFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideviewPanel
            // 
            this.sideviewPanel.Controls.Add(this.sideListView);
            this.sideviewPanel.Controls.Add(this.postButton);
            this.sideviewPanel.Location = new System.Drawing.Point(52, 381);
            this.sideviewPanel.Name = "sideviewPanel";
            this.sideviewPanel.Size = new System.Drawing.Size(150, 413);
            this.sideviewPanel.TabIndex = 7;
            // 
            // sideListView
            // 
            this.sideListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.sideListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.sideListView.Location = new System.Drawing.Point(0, 0);
            this.sideListView.Name = "sideListView";
            this.sideListView.Scrollable = false;
            this.sideListView.Size = new System.Drawing.Size(150, 363);
            this.sideListView.TabIndex = 1;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            this.sideListView.SelectedIndexChanged += new System.EventHandler(this.sideListView_SelectedIndexChanged);
            // 
            // postButton
            // 
            this.postButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(0, 363);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(150, 50);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
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
            this.overviewFlowLayoutPanel.Location = new System.Drawing.Point(0, 35);
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            this.overviewFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overviewFlowLayoutPanel.Size = new System.Drawing.Size(1298, 677);
            this.overviewFlowLayoutPanel.TabIndex = 9;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(119, 32);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(128, -3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(261, 38);
            this.searchTextBox.TabIndex = 12;
            // 
            // searchEnterButton
            // 
            this.searchEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEnterButton.Location = new System.Drawing.Point(395, 0);
            this.searchEnterButton.Name = "searchEnterButton";
            this.searchEnterButton.Size = new System.Drawing.Size(35, 35);
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
            this.searchPanel.Size = new System.Drawing.Size(1298, 715);
            this.searchPanel.TabIndex = 14;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.overviewLabel);
            this.homePanel.Controls.Add(this.overviewFlowLayoutPanel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 3);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1298, 715);
            this.homePanel.TabIndex = 15;
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.Location = new System.Drawing.Point(3, 0);
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
            this.profilePanel.Size = new System.Drawing.Size(1304, 721);
            this.profilePanel.TabIndex = 16;
            // 
            // MyPostsLabel
            // 
            this.MyPostsLabel.AutoSize = true;
            this.MyPostsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyPostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPostsLabel.Location = new System.Drawing.Point(0, 0);
            this.MyPostsLabel.Name = "MyPostsLabel";
            this.MyPostsLabel.Size = new System.Drawing.Size(137, 32);
            this.MyPostsLabel.TabIndex = 12;
            this.MyPostsLabel.Text = "My Posts";
            // 
            // MyPostsFlowLayoutPanel
            // 
            this.MyPostsFlowLayoutPanel.AutoScroll = true;
            this.MyPostsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyPostsFlowLayoutPanel.Location = new System.Drawing.Point(0, 35);
            this.MyPostsFlowLayoutPanel.Name = "MyPostsFlowLayoutPanel";
            this.MyPostsFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyPostsFlowLayoutPanel.Size = new System.Drawing.Size(1304, 686);
            this.MyPostsFlowLayoutPanel.TabIndex = 11;
            // 
            // OverviewTabControl
            // 
            this.OverviewTabControl.Controls.Add(this.homeTab);
            this.OverviewTabControl.Controls.Add(this.searchTab);
            this.OverviewTabControl.Controls.Add(this.profileTab);
            this.OverviewTabControl.Location = new System.Drawing.Point(234, 44);
            this.OverviewTabControl.Name = "OverviewTabControl";
            this.OverviewTabControl.SelectedIndex = 0;
            this.OverviewTabControl.Size = new System.Drawing.Size(1312, 750);
            this.OverviewTabControl.TabIndex = 17;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePanel);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1304, 721);
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
            this.searchTab.Size = new System.Drawing.Size(1304, 721);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.profilePanel);
            this.profileTab.Location = new System.Drawing.Point(4, 25);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(1304, 721);
            this.profileTab.TabIndex = 2;
            this.profileTab.Text = "My Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // searchFlowLayoutPanel
            // 
            this.searchFlowLayoutPanel.AutoScroll = true;
            this.searchFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchFlowLayoutPanel.Controls.Add(this.profile1);
            this.searchFlowLayoutPanel.Controls.Add(this.profile2);
            this.searchFlowLayoutPanel.Controls.Add(this.profile3);
            this.searchFlowLayoutPanel.Controls.Add(this.profile4);
            this.searchFlowLayoutPanel.Controls.Add(this.profile5);
            this.searchFlowLayoutPanel.Controls.Add(this.profile6);
            this.searchFlowLayoutPanel.Controls.Add(this.profile7);
            this.searchFlowLayoutPanel.Controls.Add(this.profile8);
            this.searchFlowLayoutPanel.Controls.Add(this.profile9);
            this.searchFlowLayoutPanel.Controls.Add(this.profile10);
            this.searchFlowLayoutPanel.Controls.Add(this.profile11);
            this.searchFlowLayoutPanel.Location = new System.Drawing.Point(4, 62);
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            this.searchFlowLayoutPanel.Size = new System.Drawing.Size(1301, 650);
            this.searchFlowLayoutPanel.TabIndex = 10;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(3, 3);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1200, 57);
            this.profile1.TabIndex = 0;
            // 
            // profile2
            // 
            this.profile2.Location = new System.Drawing.Point(3, 66);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(1200, 57);
            this.profile2.TabIndex = 1;
            // 
            // profile3
            // 
            this.profile3.Location = new System.Drawing.Point(3, 129);
            this.profile3.Name = "profile3";
            this.profile3.Size = new System.Drawing.Size(1200, 57);
            this.profile3.TabIndex = 2;
            // 
            // profile4
            // 
            this.profile4.Location = new System.Drawing.Point(3, 192);
            this.profile4.Name = "profile4";
            this.profile4.Size = new System.Drawing.Size(1200, 57);
            this.profile4.TabIndex = 3;
            // 
            // profile5
            // 
            this.profile5.Location = new System.Drawing.Point(3, 255);
            this.profile5.Name = "profile5";
            this.profile5.Size = new System.Drawing.Size(1200, 57);
            this.profile5.TabIndex = 4;
            // 
            // profile6
            // 
            this.profile6.Location = new System.Drawing.Point(3, 318);
            this.profile6.Name = "profile6";
            this.profile6.Size = new System.Drawing.Size(1200, 57);
            this.profile6.TabIndex = 5;
            // 
            // profile7
            // 
            this.profile7.Location = new System.Drawing.Point(3, 381);
            this.profile7.Name = "profile7";
            this.profile7.Size = new System.Drawing.Size(1200, 57);
            this.profile7.TabIndex = 6;
            // 
            // profile8
            // 
            this.profile8.Location = new System.Drawing.Point(3, 444);
            this.profile8.Name = "profile8";
            this.profile8.Size = new System.Drawing.Size(1200, 57);
            this.profile8.TabIndex = 7;
            // 
            // profile9
            // 
            this.profile9.Location = new System.Drawing.Point(3, 507);
            this.profile9.Name = "profile9";
            this.profile9.Size = new System.Drawing.Size(1200, 57);
            this.profile9.TabIndex = 8;
            // 
            // profile10
            // 
            this.profile10.Location = new System.Drawing.Point(3, 570);
            this.profile10.Name = "profile10";
            this.profile10.Size = new System.Drawing.Size(1200, 57);
            this.profile10.TabIndex = 9;
            // 
            // profile11
            // 
            this.profile11.Location = new System.Drawing.Point(3, 633);
            this.profile11.Name = "profile11";
            this.profile11.Size = new System.Drawing.Size(1200, 57);
            this.profile11.TabIndex = 10;
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.OverviewTabControl);
            this.Controls.Add(this.sideviewPanel);
            this.Name = "UserOverview";
            this.Text = "User Overview";
            this.Load += new System.EventHandler(this.UserOverview_Load);
            this.Controls.SetChildIndex(this.sideviewPanel, 0);
            this.Controls.SetChildIndex(this.OverviewTabControl, 0);
            this.sideviewPanel.ResumeLayout(false);
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
            this.searchFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideviewPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView sideListView;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.FlowLayoutPanel overviewFlowLayoutPanel;
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
        private System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
        private Profile profile1;
        private Profile profile2;
        private Profile profile3;
        private Profile profile4;
        private Profile profile5;
        private Profile profile6;
        private Profile profile7;
        private Profile profile8;
        private Profile profile9;
        private Profile profile10;
        private Profile profile11;
    }
}
