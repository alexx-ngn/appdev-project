﻿using System;
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
        // Instance of UserOverviewSystem
        UserOverviewSystem UserOverviewSystem = UserOverviewSystem.Instance;
        // User ID
        private int id;

        // Constructor initializing the UserOverview with a user ID
        public UserOverview(int id)
        {
            InitializeComponent();
            this.id = id;
            UserOverviewSystem.CurrentUserId = id;
        }

        // Method to load the feed
        public void loadFeed()
        {
            overviewFlowLayoutPanel.Controls.Clear();
            for (int i = UserOverviewSystem.UserPosts.Count - 1; i >= 0; i--)
            {
                UserPostProfile post = new UserPostProfile(UserOverviewSystem.UserPosts[i]);
                overviewFlowLayoutPanel.Controls.Add(post);
                post.RepostButtonClicked += (s, ev) =>
                {
                    UserOverviewSystem.ReloadUsers();
                    loadFeed();
                    loadProfile();
                };
            }
        }

        // Method to load the search results
        public void loadSearch()
        {
            searchFlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < UserOverviewSystem.UserAccounts.Count; i++)
            {
                Profile profile = new Profile(UserOverviewSystem.UserAccounts[i]);
                searchFlowLayoutPanel.Controls.Add(profile);
            }
        }

        // Method to load the user's profile
        public void loadProfile()
        {
            MyPostsFlowLayoutPanel.Controls.Clear();
            for (int i = UserOverviewSystem.UserPosts.Count - 1; i >= 0; i--)
            {
                if (UserOverviewSystem.UserPosts[i].accountId == id)
                {
                    MyPost post = new MyPost(UserOverviewSystem.UserPosts[i]);
                    MyPostsFlowLayoutPanel.Controls.Add(post);
                    post.RepostButtonClicked += (s, ev) =>
                    {
                        UserOverviewSystem.ReloadUsers();
                        loadFeed();
                        loadProfile();
                    };
                    post.DeleteButtonClicked += (s, ev) =>
                    {
                        UserOverviewSystem.ReloadUsers();
                        loadFeed();
                        loadProfile();
                    };
                }
            }
        }

        // Method to hide tabs
        private void hideTabs()
        {
            OverviewTabControl.Appearance = TabAppearance.FlatButtons;
            OverviewTabControl.ItemSize = new Size(0, 1);
            OverviewTabControl.SizeMode = TabSizeMode.Fixed;
        }

        // Event handler for post button click
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

        // Event handler for UserOverview load
        private void UserOverview_Load(object sender, EventArgs e)
        {
            overviewFlowLayoutPanel.Controls.Clear();
            hideTabs();
            loadFeed();
            loadProfile();
            loadSearch();
        }

        // Event handler for side list view selection change
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

        // Event handler for search enter button click
        private void searchEnterButton_Click(object sender, EventArgs e)
        {
            searchFlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < UserOverviewSystem.UserAccounts.Count; i++)
            {
                if (searchTextBox.Text == UserOverviewSystem.UserAccounts[i].Name)
                {
                    Profile profile = new Profile(UserOverviewSystem.UserAccounts[i]);
                    searchFlowLayoutPanel.Controls.Add(profile);
                }
            }
        }
    }
}
