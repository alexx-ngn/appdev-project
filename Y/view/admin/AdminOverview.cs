using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Y.controller;
using Y.view.admin;

namespace Y.view.admin
{
    public partial class AdminOverview : Overview.Overview
    {
        // Private field to store id
        private int id;

        // Default constructor
        public AdminOverview()
        {
            InitializeComponent();
        }

        // Constructor with id parameter
        public AdminOverview(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        // Method to load post reports
        private void loadPostReports()
        {
            // Clear existing items in postReportsListView
            postReportsListView.Items.Clear();
            // Iterate through each post report in ReportSystem
            foreach (var report in ReportSystem.Instance.PostReports)
            {
                // Create a new ListViewItem with report Id
                ListViewItem item = new ListViewItem($"{report.Id.ToString()}");
                // Add DateReported as subitem
                item.SubItems.Add(report.DateReported.ToString());
                // Add item to postReportsListView
                postReportsListView.Items.Add(item);
            }
        }

        // Method to load user reports
        private void loadUserReports()
        {
            // Clear existing items in userReportsListView
            userReportsListView.Items.Clear();
            // Iterate through each user report in ReportSystem
            foreach (var report in ReportSystem.Instance.UserReports)
            {
                // Create a new ListViewItem with report Id
                ListViewItem item = new ListViewItem($"{report.Id.ToString()}");
                // Add DateReported as subitem
                item.SubItems.Add(report.DateReported.ToString());
                // Add item to userReportsListView
                userReportsListView.Items.Add(item);
            }
        }

        // Method to load search results
        private void loadSearch()
        {
            // Clear existing items in searchListView
            searchListView.Items.Clear();
            // Iterate through each user account in UserOverviewSystem
            for (int i = 0; i < UserOverviewSystem.Instance.UserAccounts.Count; i++)
            {
                var account = UserOverviewSystem.Instance.UserAccounts[i];
                // Create a new ListViewItem with account Name
                ListViewItem item = new ListViewItem(account.Name);
                // Add item to searchListView
                searchListView.Items.Add(item);
            }
        }

        // Event handler for sideListView selection change
        private void sideListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (sideListView.SelectedItems.Count > 0)
            {
                ListViewItem item = sideListView.SelectedItems[0];
                // Switch case based on selected item text
                switch (item.Text)
                {
                    case "Reports":
                    case "Signaux":
                        // Select reportsTab
                        overviewTabControl.SelectedTab = reportsTab;
                        break;
                    case "Search":
                    case "Recherche":
                        // Load search results and select searchTab
                        loadSearch();
                        overviewTabControl.SelectedTab = searchTab;
                        break;
                    default:
                        break;
                }
            }
        }

        // Event handler for userReportsListView click
        private void userReportsListView_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (userReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userReportsListView.SelectedItems[0];
                int userReportId = int.Parse(selectedItem.Text);

                // Create a new UserReport dialog
                var userReport = new UserReport(ReportSystem.Instance.getUserReportFromId(userReportId));
                // Add event handlers for dismiss and ban clicks
                userReport.dismissClicked += (s, args) => remove();
                userReport.banClicked += (s, args) => remove();
                // Show the dialog
                userReport.ShowDialog();

                // Local method to remove selected item
                void remove()
                {
                    userReportsListView.Items.Remove(selectedItem);
                }
            }
        }

        // Event handler for postReportsListView click
        private void postReportsListView_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (postReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = postReportsListView.SelectedItems[0];
                int postReportId = int.Parse(selectedItem.Text);

                // Create a new PostReport dialog
                var postReport = new PostReport(ReportSystem.Instance.getPostReportFromId(postReportId));
                // Add event handlers for dismiss and ban clicks
                postReport.dismissClicked += (s, args) => remove();
                postReport.banClicked += (s, args) => remove();
                // Show the dialog
                postReport.ShowDialog();

                // Local method to remove selected item
                void remove()
                {
                    postReportsListView.Items.Remove(selectedItem);
                }
            }
        }

        // Event handler for searchListView click
        private void searchListView_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (searchListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = searchListView.SelectedItems[0];
                // Create a new DetailedProfileAdmin dialog
                var detailedProfile = new DetailedProfileAdmin();
                // Add event handler for ban click
                detailedProfile.banClicked += (s, args) => remove();
                // Show the dialog
                detailedProfile.ShowDialog();

                // Local method to remove selected item
                void remove()
                {
                    searchListView.Items.Remove(selectedItem);
                }
            }
        }

        // Event handler for searchEnterButton click
        private void searchEnterButton_Click(object sender, EventArgs e)
        {
            // Clear existing items in searchListView
            searchListView.Items.Clear();
            // Iterate through each user account in UserOverviewSystem
            for (int i = 0; i < UserOverviewSystem.Instance.UserAccounts.Count; i++)
            {
                // Check if search text matches account name
                if (searchTextBox.Text == UserOverviewSystem.Instance.UserAccounts[i].Name)
                {
                    var account = UserOverviewSystem.Instance.UserAccounts[i];
                    // Create a new ListViewItem with account Name
                    ListViewItem item = new ListViewItem(account.Name);
                    // Add item to searchListView
                    searchListView.Items.Add(item);
                }
            }
        }

        // Event handler for clearButton click
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear existing items in searchListView
            searchTextBox.Text = "";
        }

        // Event handler for AdminOverview load
        private void AdminOverview_Load(object sender, EventArgs e)
        {
            // Load user reports, post reports, and users from ReportSystem
            ReportSystem.Instance.loadUserReports();
            ReportSystem.Instance.loadPostReports();
            ReportSystem.Instance.LoadUsers();
            // Load post reports, user reports, and search results
            loadPostReports();
            loadUserReports();
            loadSearch();
        }
    }
}
