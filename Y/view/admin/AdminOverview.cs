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
        private int id;
        public AdminOverview()
        {
            InitializeComponent();
        }

        public AdminOverview(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        //private List<(String, String)> postReports = new List<(String, String)>();
        //private List<(String, String)> userReports = new List<(String, String)>();

        private void loadPostReports()
        {
            //for (int i = 0; i < 50; i++)
            //{
            //    postReports.Add(("Post " + i, "Date " + i));
            //}
            //this.postReports.Clear();
            //foreach (var report in Y.controller.ReportSystem.Instance.PostReports)
            //{
            //    postReports.Add((report.Id.ToString(), report.DateReported.ToString()));
            //}
            postReportsListView.Items.Clear();
            foreach (var report in ReportSystem.Instance.PostReports)
            {
                ListViewItem item = new ListViewItem($"{report.Id.ToString()}");
                item.SubItems.Add(report.DateReported.ToString());
                postReportsListView.Items.Add(item);
            }
        }

        private void loadUserReports()
        {
            userReportsListView.Items.Clear();
            foreach (var report in ReportSystem.Instance.UserReports)
            {
                ListViewItem item = new ListViewItem($"{report.Id.ToString()}");
                item.SubItems.Add(report.DateReported.ToString());
                userReportsListView.Items.Add(item);
            }
        }

        //private void loadSearchResults()
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        ListViewItem item = new ListViewItem("User " + i);
        //        item.SubItems.Add("User " + i);
        //        searchListView.Items.Add(item);
        //    }
        //}

        private void loadSearch()
        {
            searchListView.Items.Clear();
            for (int i = 0; i < UserOverviewSystem.Instance.UserAccounts.Count; i++)
            {
                var account = UserOverviewSystem.Instance.UserAccounts[i];
                ListViewItem item = new ListViewItem(account.Name);
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
                    case "Signaux":
                        overviewTabControl.SelectedTab = reportsTab;
                        break;
                    case "Search":
                    case "Recherche":
                        loadSearch();
                        overviewTabControl.SelectedTab = searchTab;
                        break;
                    default:
                        break;
                }
            }
        }

        private void userReportsListView_Click(object sender, EventArgs e)
        {
            if (userReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userReportsListView.SelectedItems[0];
                int userReportId = int.Parse(selectedItem.Text);

                var userReport = new UserReport(ReportSystem.Instance.getUserReportFromId(userReportId));
                userReport.dismissClicked += (s, args) => remove();
                userReport.banClicked += (s, args) => remove();
                userReport.ShowDialog();

                void remove()
                {
                    userReportsListView.Items.Remove(selectedItem);
                    //loadUserReports();
                }
            }
        }

        private void postReportsListView_Click(object sender, EventArgs e)
        {
            if (postReportsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = postReportsListView.SelectedItems[0];
                int postReportId = int.Parse(selectedItem.Text);

                var postReport = new PostReport(ReportSystem.Instance.getPostReportFromId(postReportId));
                postReport.dismissClicked += (s, args) => remove();
                postReport.banClicked += (s, args) => remove();
                postReport.ShowDialog();

                void remove()
                {
                    postReportsListView.Items.Remove(selectedItem);
                    //loadPostReports();
                }
            }
        }

        private void searchListView_Click(object sender, EventArgs e)
        {
            if (searchListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = searchListView.SelectedItems[0];
                var detailedProfile = new DetailedProfileAdmin();
                detailedProfile.banClicked += (s, args) => remove();
                detailedProfile.ShowDialog();

                void remove()
                {
                    searchListView.Items.Remove(selectedItem);
                }
            }
        }

        private void searchEnterButton_Click(object sender, EventArgs e)
        {
            //loadSearchResults();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchListView.Items.Clear();
        }

        private void AdminOverview_Load(object sender, EventArgs e)
        {
            ReportSystem.Instance.loadUserReports();
            ReportSystem.Instance.loadPostReports();
            ReportSystem.Instance.LoadUsers();
            loadPostReports();
            loadUserReports();
            loadSearch();
        }
    }
}
