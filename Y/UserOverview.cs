using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y
{
    public partial class UserOverview : Overview.Overview
    {
        public UserOverview()
        {
            InitializeComponent();
        }
        private void loadPosts()
        {
            for (int i = 0; i < 5; i++)
            {
                Post post = new Post();
                overviewFlowLayoutPanel.Controls.Add(post);
            }
        }

        private void hidePanels()
        {
            //homePanel.Hide();
            searchPanel.Hide();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            NewPost post = new NewPost();
            post.ShowDialog();
        }

        private void UserOverview_Load(object sender, EventArgs e)
        {
            loadPosts();
            hidePanels();
        }

        private void sideListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sideListView.SelectedItems.Count > 0)
            {
                ListViewItem item = sideListView.SelectedItems[0];
                switch (item.Text)
                {
                    case "Home":
                        searchPanel.Hide();
                        homePanel.Show();
                        break;
                    case "Search":
                        homePanel.Hide();
                        searchPanel.Show();
                        break;
                    case "My Profile":
                        homePanel.Hide();
                        searchPanel.Hide();
                        break;
                }
            }
        }

        private void searchEnterButton_Click(object sender, EventArgs e)
        {
            searchFlowLayoutPanel.Controls.Clear();
        }
    }
}
