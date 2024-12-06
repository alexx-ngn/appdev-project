using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Y.controller;

namespace Y.view.user
{
    public partial class UserPostProfile : Y.UserPost
    {
        private Post post;

        public UserPostProfile()
        {
            InitializeComponent();
        }

        public UserPostProfile(Post post) : base(post)
        {
            this.post = post;
            InitializeComponent();
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            int reporterUserId = UserOverviewSystem.Instance.CurrentUserId;
            int reportedPostId = post.Id; 
            
            NewPostReport reportForm = new NewPostReport(reporterUserId, reportedPostId);
            reportForm.Show();
        }
    }
}
