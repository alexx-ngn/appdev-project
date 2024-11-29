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
        }

        private List<String> list = new List<String>();
        private void loadPostReports()
        {
            list.Add("Post 1 - DATE");
            list.Add("Post 2 - DATE");
            list.Add("Post 3 - DATE");
            list.Add("Post 4 - DATE");
            foreach (String report in list)
            {
                ListViewItem item = new ListViewItem(report);
                postReportsListView.Items.Add(item);
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
    }
}
