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
                UserPostProfile post = new UserPostProfile();
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
                    case "Chercher":
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

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
                    break;
                default:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
