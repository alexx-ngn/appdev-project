using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y.view.admin
{
    public partial class AdminOverview : Overview.Overview
    {
        public AdminOverview()
        {
            InitializeComponent();
            loadPostReports();
            loadUserReports();
        }

        private List<String> postReports = new List<String>();
        private List<String> userReports = new List<String>();
        private void loadPostReports()
        {
            postReports.Add("Post 1 - DATE");
            postReports.Add("Post 2 - DATE");
            postReports.Add("Post 3 - DATE");
            postReports.Add("Post 4 - DATE");
            foreach (String report in postReports)
            {
                ListViewItem item = new ListViewItem(report);
                postReportsListView.Items.Add(item);
            }
        }

        private void loadUserReports()
        {
            userReports.Add("User 1 - DATE");
            userReports.Add("User 2 - DATE");
            userReports.Add("User 3 - DATE");
            userReports.Add("User 4 - DATE");
            foreach (String report in postReports)
            {
                ListViewItem item = new ListViewItem(report);
                userReportsListView.Items.Add(item);
            }
        }

        private void sideListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sideListView.SelectedItems.Count > 0)
            {
                ListViewItem item = sideListView.SelectedItems[0];
                switch (item.Text)
                {
                    case "Reports":
                        overviewTabControl.SelectedTab = reportsTab;
                        break;
                    case "Search":
                        overviewTabControl.SelectedTab = searchTab;
                        break;
                    default:
                        break;
                }
            }
        }

        private void postReportsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (postReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = postReportsListView.SelectedItems[0];
                MessageBox.Show("Selected Report: " + selectedItem.Text);
            }
        }

        private void userReportsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userReportsListView.SelectedItems[0];
                MessageBox.Show("Selected Report: " + selectedItem.Text);
            }
        }
    }
}
