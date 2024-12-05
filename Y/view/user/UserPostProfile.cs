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
        private int userId { get; set; }

        public UserPostProfile()
        {
            InitializeComponent();
        }

        public UserPostProfile(Post post) : base(post)
        {
            InitializeComponent();
            userId = post.accountId;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            int reporterUserId = UserOverviewSystem.Instance.CurrentUserId;
            int reportedUserId = userId;
            
            NewUserReport reportForm = new NewUserReport(reporterUserId, reportedUserId);
            reportForm.Show();
        }
    }
}
