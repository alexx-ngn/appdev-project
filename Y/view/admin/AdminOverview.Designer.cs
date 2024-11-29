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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reports"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Search"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
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
            this.sideViewPanel.Controls.Add(this.sideListView);
            this.sideViewPanel.Location = new System.Drawing.Point(52, 372);
            this.sideViewPanel.Name = "sideViewPanel";
            this.sideViewPanel.Size = new System.Drawing.Size(150, 404);
            this.sideViewPanel.TabIndex = 9;
            // 
            // sideListView
            // 
            this.sideListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.sideListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.sideListView.Location = new System.Drawing.Point(0, 0);
            this.sideListView.Name = "sideListView";
            this.sideListView.Scrollable = false;
            this.sideListView.Size = new System.Drawing.Size(150, 404);
            this.sideListView.TabIndex = 2;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            this.sideListView.SelectedIndexChanged += new System.EventHandler(this.sideListView_SelectedIndexChanged);
            // 
            // overviewTabControl
            // 
            this.overviewTabControl.Controls.Add(this.reportsTab);
            this.overviewTabControl.Controls.Add(this.searchTab);
            this.overviewTabControl.Location = new System.Drawing.Point(223, 26);
            this.overviewTabControl.Name = "overviewTabControl";
            this.overviewTabControl.SelectedIndex = 0;
            this.overviewTabControl.Size = new System.Drawing.Size(1297, 750);
            this.overviewTabControl.TabIndex = 18;
            // 
            // reportsTab
            // 
            this.reportsTab.Controls.Add(this.homePanel);
            this.reportsTab.Location = new System.Drawing.Point(4, 25);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTab.Size = new System.Drawing.Size(1289, 721);
            this.reportsTab.TabIndex = 0;
            this.reportsTab.Text = "Reports";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.reportsLabel);
            this.homePanel.Controls.Add(this.overviewFlowLayoutPanel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 3);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1283, 715);
            this.homePanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Reports";
            // 
            // reportsLabel
            // 
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLabel.Location = new System.Drawing.Point(3, 0);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(189, 32);
            this.reportsLabel.TabIndex = 10;
            this.reportsLabel.Text = "Post Reports";
            // 
            // overviewFlowLayoutPanel
            // 
            this.overviewFlowLayoutPanel.AutoScroll = true;
            this.overviewFlowLayoutPanel.Controls.Add(this.postReportsListView);
            this.overviewFlowLayoutPanel.Controls.Add(this.userReportsListView);
            this.overviewFlowLayoutPanel.Location = new System.Drawing.Point(0, 35);
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            this.overviewFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overviewFlowLayoutPanel.Size = new System.Drawing.Size(1298, 677);
            this.overviewFlowLayoutPanel.TabIndex = 9;
            // 
            // postReportsListView
            // 
            this.postReportsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.postReportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PostReportPostColumn,
            this.PostReportDateColumn});
            this.postReportsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postReportsListView.HideSelection = false;
            this.postReportsListView.Location = new System.Drawing.Point(3, 3);
            this.postReportsListView.Name = "postReportsListView";
            this.postReportsListView.Size = new System.Drawing.Size(623, 674);
            this.postReportsListView.TabIndex = 0;
            this.postReportsListView.UseCompatibleStateImageBehavior = false;
            this.postReportsListView.View = System.Windows.Forms.View.Details;
            this.postReportsListView.SelectedIndexChanged += new System.EventHandler(this.postReportsListView_SelectedIndexChanged);
            // 
            // PostReportPostColumn
            // 
            this.PostReportPostColumn.Text = "Post";
            this.PostReportPostColumn.Width = 154;
            // 
            // PostReportDateColumn
            // 
            this.PostReportDateColumn.Text = "Date";
            this.PostReportDateColumn.Width = 165;
            // 
            // userReportsListView
            // 
            this.userReportsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.userReportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserReportUserColumn,
            this.UserReportDateColumn});
            this.userReportsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReportsListView.HideSelection = false;
            this.userReportsListView.Location = new System.Drawing.Point(632, 3);
            this.userReportsListView.Name = "userReportsListView";
            this.userReportsListView.Size = new System.Drawing.Size(631, 674);
            this.userReportsListView.TabIndex = 1;
            this.userReportsListView.UseCompatibleStateImageBehavior = false;
            this.userReportsListView.View = System.Windows.Forms.View.Details;
            this.userReportsListView.SelectedIndexChanged += new System.EventHandler(this.userReportsListView_SelectedIndexChanged);
            // 
            // UserReportUserColumn
            // 
            this.UserReportUserColumn.Text = "User";
            this.UserReportUserColumn.Width = 155;
            // 
            // UserReportDateColumn
            // 
            this.UserReportDateColumn.Text = "Date";
            this.UserReportDateColumn.Width = 187;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchPanel);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(1289, 721);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchListView);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchEnterButton);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1283, 715);
            this.searchPanel.TabIndex = 14;
            // 
            // searchListView
            // 
            this.searchListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.searchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserColumn});
            this.searchListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchListView.HideSelection = false;
            this.searchListView.Location = new System.Drawing.Point(9, 38);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(1271, 674);
            this.searchListView.TabIndex = 14;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            this.searchListView.SelectedIndexChanged += new System.EventHandler(this.searchListView_SelectedIndexChanged);
            // 
            // UserColumn
            // 
            this.UserColumn.Text = "User";
            this.UserColumn.Width = 154;
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
            // AdminOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1582, 853);
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
    }
}
