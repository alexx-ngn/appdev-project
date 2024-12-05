namespace Y
{
    partial class UserOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOverview));
            this.sideViewPanel = new System.Windows.Forms.Panel();
            this.postButton = new System.Windows.Forms.Button();
            this.sideListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.overviewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchEnterButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.MyPostsLabel = new System.Windows.Forms.Label();
            this.MyPostsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OverviewTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.sideViewPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.OverviewTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideViewPanel
            // 
            this.sideViewPanel.Controls.Add(this.postButton);
            this.sideViewPanel.Controls.Add(this.sideListView);
            resources.ApplyResources(this.sideViewPanel, "sideViewPanel");
            this.sideViewPanel.Name = "sideViewPanel";
            // 
            // postButton
            // 
            resources.ApplyResources(this.postButton, "postButton");
            this.postButton.Name = "postButton";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // sideListView
            // 
            resources.ApplyResources(this.sideListView, "sideListView");
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("sideListView.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("sideListView.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("sideListView.Items2")))});
            this.sideListView.Name = "sideListView";
            this.sideListView.Scrollable = false;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            this.sideListView.SelectedIndexChanged += new System.EventHandler(this.sideListView_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // overviewFlowLayoutPanel
            // 
            resources.ApplyResources(this.overviewFlowLayoutPanel, "overviewFlowLayoutPanel");
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            // 
            // searchEnterButton
            // 
            resources.ApplyResources(this.searchEnterButton, "searchEnterButton");
            this.searchEnterButton.Name = "searchEnterButton";
            this.searchEnterButton.UseVisualStyleBackColor = true;
            this.searchEnterButton.Click += new System.EventHandler(this.searchEnterButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchEnterButton);
            this.searchPanel.Controls.Add(this.searchFlowLayoutPanel);
            resources.ApplyResources(this.searchPanel, "searchPanel");
            this.searchPanel.Name = "searchPanel";
            // 
            // searchFlowLayoutPanel
            // 
            resources.ApplyResources(this.searchFlowLayoutPanel, "searchFlowLayoutPanel");
            this.searchFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.overviewFlowLayoutPanel);
            this.homePanel.Controls.Add(this.overviewLabel);
            resources.ApplyResources(this.homePanel, "homePanel");
            this.homePanel.Name = "homePanel";
            // 
            // overviewLabel
            // 
            resources.ApplyResources(this.overviewLabel, "overviewLabel");
            this.overviewLabel.Name = "overviewLabel";
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.MyPostsLabel);
            this.profilePanel.Controls.Add(this.MyPostsFlowLayoutPanel);
            resources.ApplyResources(this.profilePanel, "profilePanel");
            this.profilePanel.Name = "profilePanel";
            // 
            // MyPostsLabel
            // 
            resources.ApplyResources(this.MyPostsLabel, "MyPostsLabel");
            this.MyPostsLabel.Name = "MyPostsLabel";
            // 
            // MyPostsFlowLayoutPanel
            // 
            resources.ApplyResources(this.MyPostsFlowLayoutPanel, "MyPostsFlowLayoutPanel");
            this.MyPostsFlowLayoutPanel.Name = "MyPostsFlowLayoutPanel";
            // 
            // OverviewTabControl
            // 
            this.OverviewTabControl.Controls.Add(this.homeTab);
            this.OverviewTabControl.Controls.Add(this.searchTab);
            this.OverviewTabControl.Controls.Add(this.profileTab);
            resources.ApplyResources(this.OverviewTabControl, "OverviewTabControl");
            this.OverviewTabControl.Name = "OverviewTabControl";
            this.OverviewTabControl.SelectedIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePanel);
            resources.ApplyResources(this.homeTab, "homeTab");
            this.homeTab.Name = "homeTab";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchPanel);
            resources.ApplyResources(this.searchTab, "searchTab");
            this.searchTab.Name = "searchTab";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.profilePanel);
            resources.ApplyResources(this.profileTab, "profileTab");
            this.profileTab.Name = "profileTab";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // UserOverview
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.OverviewTabControl);
            this.Controls.Add(this.sideViewPanel);
            this.Name = "UserOverview";
            this.Load += new System.EventHandler(this.UserOverview_Load);
            this.Controls.SetChildIndex(this.sideViewPanel, 0);
            this.Controls.SetChildIndex(this.OverviewTabControl, 0);
            this.sideViewPanel.ResumeLayout(false);
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

        private global::System.Windows.Forms.Panel sideViewPanel;
        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.ListView sideListView;
        private global::System.Windows.Forms.Button postButton;
        private global::System.Windows.Forms.FlowLayoutPanel overviewFlowLayoutPanel;
        private global::System.Windows.Forms.Label searchLabel;
        private global::System.Windows.Forms.TextBox searchTextBox;
        private global::System.Windows.Forms.Button searchEnterButton;
        private global::System.Windows.Forms.Panel searchPanel;
        private global::System.Windows.Forms.Panel homePanel;
        private global::System.Windows.Forms.Label overviewLabel;
        private global::System.Windows.Forms.Panel profilePanel;
        private global::System.Windows.Forms.TabPage homeTab;
        private global::System.Windows.Forms.TabPage searchTab;
        private global::System.Windows.Forms.TabPage profileTab;
        private global::System.Windows.Forms.TabControl OverviewTabControl;
        private global::System.Windows.Forms.Label MyPostsLabel;
        private global::System.Windows.Forms.FlowLayoutPanel MyPostsFlowLayoutPanel;
        private global::System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
    }
}
