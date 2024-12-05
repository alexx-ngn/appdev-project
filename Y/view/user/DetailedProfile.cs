using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;

namespace Y
{
    public partial class DetailedProfile : Form
    {
        private UserAccount userAccount;
        private UserOverviewSystem UserOverviewSystem = UserOverviewSystem.Instance;

        public DetailedProfile()
        {
            InitializeComponent();
        }

        public DetailedProfile(UserAccount userAccount)
        {
            this.userAccount = userAccount;
            InitializeComponent();
        }

        private void DetailedProfile_Load(object sender, EventArgs e)
        {
            profileLabel.Text = userAccount.Name;
            loadPosts();
        }

        private void loadPosts()
        {
            // Load posts from userAccount
            PostsFlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < UserOverviewSystem.UserPosts.Count; i++)
            {
                if (UserOverviewSystem.UserPosts[i].accountId == userAccount.Id)
                {
                    UserPost userPost = new UserPost(UserOverviewSystem.UserPosts[i]);
                    PostsFlowLayoutPanel.Controls.Add(userPost);
                }
            }
        }
    }
}
