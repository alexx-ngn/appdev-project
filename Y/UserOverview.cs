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
        public void loadPosts()
        {
            for (int i = 0; i < 5; i++)
            {
                Post post = new Post();
                overviewFlowLayoutPanel.Controls.Add(post);
            }
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
    }
}
