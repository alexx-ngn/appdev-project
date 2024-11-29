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
            this.userReportsListView = new System.Windows.Forms.ListView();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchEnterButton = new System.Windows.Forms.Button();
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
            this.sideViewPanel.SuspendLayout();
            this.overviewTabControl.SuspendLayout();
            this.reportsTab.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.overviewFlowLayoutPanel.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.searchFlowLayoutPanel.SuspendLayout();
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
            this.postReportsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postReportsListView.HideSelection = false;
            this.postReportsListView.Location = new System.Drawing.Point(3, 3);
            this.postReportsListView.Name = "postReportsListView";
            this.postReportsListView.Size = new System.Drawing.Size(623, 674);
            this.postReportsListView.TabIndex = 0;
            this.postReportsListView.UseCompatibleStateImageBehavior = false;
            this.postReportsListView.View = System.Windows.Forms.View.List;
            this.postReportsListView.SelectedIndexChanged += new System.EventHandler(this.postReportsListView_SelectedIndexChanged);
            // 
            // userReportsListView
            // 
            this.userReportsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.userReportsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReportsListView.HideSelection = false;
            this.userReportsListView.Location = new System.Drawing.Point(632, 3);
            this.userReportsListView.Name = "userReportsListView";
            this.userReportsListView.Size = new System.Drawing.Size(631, 674);
            this.userReportsListView.TabIndex = 1;
            this.userReportsListView.UseCompatibleStateImageBehavior = false;
            this.userReportsListView.View = System.Windows.Forms.View.List;
            this.userReportsListView.SelectedIndexChanged += new System.EventHandler(this.userReportsListView_SelectedIndexChanged);
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
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchEnterButton);
            this.searchPanel.Controls.Add(this.searchFlowLayoutPanel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1283, 715);
            this.searchPanel.TabIndex = 14;
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
            this.profile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile1.Location = new System.Drawing.Point(3, 3);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1200, 57);
            this.profile1.TabIndex = 0;
            // 
            // profile2
            // 
            this.profile2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile2.Location = new System.Drawing.Point(3, 66);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(1200, 57);
            this.profile2.TabIndex = 1;
            // 
            // profile3
            // 
            this.profile3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile3.Location = new System.Drawing.Point(3, 129);
            this.profile3.Name = "profile3";
            this.profile3.Size = new System.Drawing.Size(1200, 57);
            this.profile3.TabIndex = 2;
            // 
            // profile4
            // 
            this.profile4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile4.Location = new System.Drawing.Point(3, 192);
            this.profile4.Name = "profile4";
            this.profile4.Size = new System.Drawing.Size(1200, 57);
            this.profile4.TabIndex = 3;
            // 
            // profile5
            // 
            this.profile5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile5.Location = new System.Drawing.Point(3, 255);
            this.profile5.Name = "profile5";
            this.profile5.Size = new System.Drawing.Size(1200, 57);
            this.profile5.TabIndex = 4;
            // 
            // profile6
            // 
            this.profile6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile6.Location = new System.Drawing.Point(3, 318);
            this.profile6.Name = "profile6";
            this.profile6.Size = new System.Drawing.Size(1200, 57);
            this.profile6.TabIndex = 5;
            // 
            // profile7
            // 
            this.profile7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile7.Location = new System.Drawing.Point(3, 381);
            this.profile7.Name = "profile7";
            this.profile7.Size = new System.Drawing.Size(1200, 57);
            this.profile7.TabIndex = 6;
            // 
            // profile8
            // 
            this.profile8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile8.Location = new System.Drawing.Point(3, 444);
            this.profile8.Name = "profile8";
            this.profile8.Size = new System.Drawing.Size(1200, 57);
            this.profile8.TabIndex = 7;
            // 
            // profile9
            // 
            this.profile9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile9.Location = new System.Drawing.Point(3, 507);
            this.profile9.Name = "profile9";
            this.profile9.Size = new System.Drawing.Size(1200, 57);
            this.profile9.TabIndex = 8;
            // 
            // profile10
            // 
            this.profile10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile10.Location = new System.Drawing.Point(3, 570);
            this.profile10.Name = "profile10";
            this.profile10.Size = new System.Drawing.Size(1200, 57);
            this.profile10.TabIndex = 9;
            // 
            // profile11
            // 
            this.profile11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile11.Location = new System.Drawing.Point(3, 633);
            this.profile11.Name = "profile11";
            this.profile11.Size = new System.Drawing.Size(1200, 57);
            this.profile11.TabIndex = 10;
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
            this.searchFlowLayoutPanel.ResumeLayout(false);
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
