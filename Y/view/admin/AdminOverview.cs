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

        private List<(String, String)> postReports = new List<(String, String)>();
        private List<(String, String)> userReports = new List<(String, String)>();

        private void loadPostReports()
        {
            for (int i = 0; i < 50; i++)
            {
                postReports.Add(("Post " + i, "Date " + i));
            }
            foreach ((String, String) report in postReports)
            {
                ListViewItem item = new ListViewItem($"{report.Item1}");
                item.SubItems.Add($"{report.Item2}");
                postReportsListView.Items.Add(item);
            }
        }

        private void loadUserReports()
        {
            for (int i = 0; i < 50; i++) {
                userReports.Add(("User " + i, "Date " + i));
            }
            foreach ((String, String) report in userReports)
            {
                ListViewItem item = new ListViewItem($"{report.Item1}");
                item.SubItems.Add($"{report.Item2}");
                userReportsListView.Items.Add(item);
            }
        }

        private void loadSearchResults()
        {
            for (int i = 0; i < 50; i++)
            {
                ListViewItem item = new ListViewItem("User " + i);
                item.SubItems.Add("User " + i);
                searchListView.Items.Add(item);
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
                new PostReport().ShowDialog();
            }
        }

        private void userReportsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userReportsListView.SelectedItems[0];
                new UserReport().ShowDialog();
            }
        }

        private void searchListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = searchListView.SelectedItems[0];
                new DetailedProfileAdmin().ShowDialog();
            }
        }

        private void searchEnterButton_Click(object sender, EventArgs e)
        {
            loadSearchResults();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchListView.Items.Clear();
        }
    }
}
