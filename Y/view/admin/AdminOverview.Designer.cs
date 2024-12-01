namespace Y.view.admin
{
    partial class AdminOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOverview));
            this.sideViewPanel = new System.Windows.Forms.Panel();
            this.sideListView = new System.Windows.Forms.ListView();
            this.overviewTabControl = new System.Windows.Forms.TabControl();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsLabel = new System.Windows.Forms.Label();
            this.overviewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.postReportsListView = new System.Windows.Forms.ListView();
            this.PostReportPostColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostReportDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userReportsListView = new System.Windows.Forms.ListView();
            this.UserReportUserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserReportDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchListView = new System.Windows.Forms.ListView();
            this.UserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchEnterButton = new System.Windows.Forms.Button();
            this.sideViewPanel.SuspendLayout();
            this.overviewTabControl.SuspendLayout();
            this.reportsTab.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.overviewFlowLayoutPanel.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideViewPanel
            // 
            resources.ApplyResources(this.sideViewPanel, "sideViewPanel");
            this.sideViewPanel.Controls.Add(this.sideListView);
            this.sideViewPanel.Name = "sideViewPanel";
            // 
            // sideListView
            // 
            resources.ApplyResources(this.sideListView, "sideListView");
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("sideListView.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("sideListView.Items1")))});
            this.sideListView.Name = "sideListView";
            this.sideListView.Scrollable = false;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            this.sideListView.SelectedIndexChanged += new System.EventHandler(this.sideListView_SelectedIndexChanged);
            // 
            // overviewTabControl
            // 
            resources.ApplyResources(this.overviewTabControl, "overviewTabControl");
            this.overviewTabControl.Controls.Add(this.reportsTab);
            this.overviewTabControl.Controls.Add(this.searchTab);
            this.overviewTabControl.Name = "overviewTabControl";
            this.overviewTabControl.SelectedIndex = 0;
            // 
            // reportsTab
            // 
            resources.ApplyResources(this.reportsTab, "reportsTab");
            this.reportsTab.Controls.Add(this.homePanel);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // homePanel
            // 
            resources.ApplyResources(this.homePanel, "homePanel");
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.reportsLabel);
            this.homePanel.Controls.Add(this.overviewFlowLayoutPanel);
            this.homePanel.Name = "homePanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // reportsLabel
            // 
            resources.ApplyResources(this.reportsLabel, "reportsLabel");
            this.reportsLabel.Name = "reportsLabel";
            // 
            // overviewFlowLayoutPanel
            // 
            resources.ApplyResources(this.overviewFlowLayoutPanel, "overviewFlowLayoutPanel");
            this.overviewFlowLayoutPanel.Controls.Add(this.postReportsListView);
            this.overviewFlowLayoutPanel.Controls.Add(this.userReportsListView);
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            // 
            // postReportsListView
            // 
            resources.ApplyResources(this.postReportsListView, "postReportsListView");
            this.postReportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PostReportPostColumn,
            this.PostReportDateColumn});
            this.postReportsListView.HideSelection = false;
            this.postReportsListView.Name = "postReportsListView";
            this.postReportsListView.UseCompatibleStateImageBehavior = false;
            this.postReportsListView.View = System.Windows.Forms.View.Details;
            this.postReportsListView.Click += new System.EventHandler(this.postReportsListView_Click);
            // 
            // PostReportPostColumn
            // 
            resources.ApplyResources(this.PostReportPostColumn, "PostReportPostColumn");
            // 
            // PostReportDateColumn
            // 
            resources.ApplyResources(this.PostReportDateColumn, "PostReportDateColumn");
            // 
            // userReportsListView
            // 
            resources.ApplyResources(this.userReportsListView, "userReportsListView");
            this.userReportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserReportUserColumn,
            this.UserReportDateColumn});
            this.userReportsListView.HideSelection = false;
            this.userReportsListView.Name = "userReportsListView";
            this.userReportsListView.UseCompatibleStateImageBehavior = false;
            this.userReportsListView.View = System.Windows.Forms.View.Details;
            this.userReportsListView.Click += new System.EventHandler(this.userReportsListView_Click);
            // 
            // UserReportUserColumn
            // 
            resources.ApplyResources(this.UserReportUserColumn, "UserReportUserColumn");
            // 
            // UserReportDateColumn
            // 
            resources.ApplyResources(this.UserReportDateColumn, "UserReportDateColumn");
            // 
            // searchTab
            // 
            resources.ApplyResources(this.searchTab, "searchTab");
            this.searchTab.Controls.Add(this.searchPanel);
            this.searchTab.Name = "searchTab";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            resources.ApplyResources(this.searchPanel, "searchPanel");
            this.searchPanel.Controls.Add(this.searchListView);
            this.searchPanel.Controls.Add(this.clearButton);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchEnterButton);
            this.searchPanel.Name = "searchPanel";
            // 
            // searchListView
            // 
            resources.ApplyResources(this.searchListView, "searchListView");
            this.searchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserColumn});
            this.searchListView.HideSelection = false;
            this.searchListView.Name = "searchListView";
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            this.searchListView.Click += new System.EventHandler(this.searchListView_Click);
            // 
            // UserColumn
            // 
            resources.ApplyResources(this.UserColumn, "UserColumn");
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            // AdminOverview
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.overviewTabControl);
            this.Controls.Add(this.sideViewPanel);
            this.Name = "AdminOverview";
            this.Controls.SetChildIndex(this.sideViewPanel, 0);
            this.Controls.SetChildIndex(this.overviewTabControl, 0);
            this.sideViewPanel.ResumeLayout(false);
            this.overviewTabControl.ResumeLayout(false);
            this.reportsTab.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.overviewFlowLayoutPanel.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideViewPanel;
        private System.Windows.Forms.ListView sideListView;
        private System.Windows.Forms.TabControl overviewTabControl;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reportsLabel;
        private System.Windows.Forms.FlowLayoutPanel overviewFlowLayoutPanel;
        private System.Windows.Forms.ListView postReportsListView;
        private System.Windows.Forms.ListView userReportsListView;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchEnterButton;
        private System.Windows.Forms.ColumnHeader PostReportPostColumn;
        private System.Windows.Forms.ColumnHeader UserReportUserColumn;
        private System.Windows.Forms.ColumnHeader PostReportDateColumn;
        private System.Windows.Forms.ColumnHeader UserReportDateColumn;
        private System.Windows.Forms.ListView searchListView;
        private System.Windows.Forms.ColumnHeader UserColumn;
        private System.Windows.Forms.Button clearButton;
    }
}
