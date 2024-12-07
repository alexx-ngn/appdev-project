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
        // Private fields
        private UserAccount userAccount;
        private UserOverviewSystem UserOverviewSystem = UserOverviewSystem.Instance;

        // Default constructor
        public DetailedProfile()
        {
            InitializeComponent();
        }

        // Constructor with UserAccount parameter
        public DetailedProfile(UserAccount userAccount)
        {
            this.userAccount = userAccount;
            InitializeComponent();
        }

        // Event handler for form load
        private void DetailedProfile_Load(object sender, EventArgs e)
        {
            profileLabel.Text = userAccount.Name;
            loadPosts();
        }

        // Method to load posts
        private void loadPosts()
        {
            // Clear existing controls
            PostsFlowLayoutPanel.Controls.Clear();
            // Iterate through user posts
            for (int i = 0; i < UserOverviewSystem.UserPosts.Count; i++)
            {
                // Check if post belongs to the current user
                if (UserOverviewSystem.UserPosts[i].accountId == userAccount.Id)
                {
                    // Create a new UserPost control and add it to the panel
                    UserPost userPost = new UserPost(UserOverviewSystem.UserPosts[i]);
                    PostsFlowLayoutPanel.Controls.Add(userPost);
                }
            }
        }
    }
}
