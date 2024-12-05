using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Y.view.user;
using Y.controller;

namespace Y
{
    public partial class UserOverview : Overview.Overview
    {
        UserOverviewSystem UserOverviewSystem = UserOverviewSystem.Instance;
        private int id;
        public UserOverview(int id)
        {
            InitializeComponent();
            this.id = id;
            UserOverviewSystem.CurrentUserId = id;
        }
        public void loadFeed()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    UserPostProfile post = new UserPostProfile();
            //    overviewFlowLayoutPanel.Controls.Add(post);
            //}
            //for (int i = 0; i < 5 ; i++) {
            //    MyPost post = new MyPost();
            //    MyPostsFlowLayoutPanel.Controls.Add(post);
            //}
            //for (int i = 0; i < UserOverviewSystem.UserPosts.Count; i++)
            //{

            //    //int id = UserOverviewSystem.UserPosts[i].Id;
            //    UserPostProfile post = new UserPostProfile(UserOverviewSystem.UserPosts[i]);
            //    overviewFlowLayoutPanel.Controls.Add(post);
            //}
            overviewFlowLayoutPanel.Controls.Clear();
            for (int i = UserOverviewSystem.UserPosts.Count - 1; i >= 0; i--)
            {
                UserPostProfile post = new UserPostProfile(UserOverviewSystem.UserPosts[i]);
                overviewFlowLayoutPanel.Controls.Add(post);
            }
        }

        public void loadProfile()
        {
            MyPostsFlowLayoutPanel.Controls.Clear();
            for (int i = UserOverviewSystem.UserPosts.Count - 1; i >= 0; i--)
            {
                if (UserOverviewSystem.UserPosts[i].accountId == id)
                {
                    MyPost post = new MyPost(UserOverviewSystem.UserPosts[i]);
                    MyPostsFlowLayoutPanel.Controls.Add(post);
                }
            }
        }

        private void hideTabs()
        {
            OverviewTabControl.Appearance = TabAppearance.FlatButtons;
            OverviewTabControl.ItemSize = new Size(0, 1);
            OverviewTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            NewPost post = new NewPost(id);
            post.PostButton += (s, ev) =>
            {
                UserOverviewSystem.Instance.ReloadUsers();
                loadFeed();
                loadProfile();
            };
            post.ShowDialog();
        }

        private void UserOverview_Load(object sender, EventArgs e)
        {
            hideTabs();
            loadFeed();
            loadProfile();
        }

        private void sideListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sideListView.SelectedItems.Count > 0)
            {
                ListViewItem item = sideListView.SelectedItems[0];
                switch (item.Text)
                {
                    case "Home":
                    case "Accueil":
                        OverviewTabControl.SelectedTab = homeTab;
                        break;
                    case "Search":
                    case "Recherche":
                        OverviewTabControl.SelectedTab = searchTab;
                        break;
                    case "My Profile":
                    case "Mon Profil":
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
