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
            for (int i = 0; i < 5 ; i++) {
                MyPost post = new MyPost();
                MyPostsFlowLayoutPanel.Controls.Add(post);
            }
        }

        private void hideTabs()
        {
            OverviewTabControl.TabPages.Remove(homeTab);
            OverviewTabControl.TabPages.Remove(searchTab);
            OverviewTabControl.TabPages.Remove(profileTab);
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            NewPost post = new NewPost();
            post.ShowDialog();
        }

        private void UserOverview_Load(object sender, EventArgs e)
        {
            loadPosts();
            //hideTabs();
        }

        private void sideListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sideListView.SelectedItems.Count > 0)
            {
                ListViewItem item = sideListView.SelectedItems[0];
                switch (item.Text)
                {
                    case "Home":
                        OverviewTabControl.SelectedTab = homeTab;
                        break;
                    case "Search":
                        OverviewTabControl.SelectedTab = searchTab;
                        break;
                    case "My Profile":
                        OverviewTabControl.SelectedTab = profileTab;
                        break;
                    default:
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
