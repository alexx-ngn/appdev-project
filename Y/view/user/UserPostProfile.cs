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
        public event EventHandler RepostButtonClicked;
        private Post post;
        public UserPostProfile()
        {
            InitializeComponent();
        }

        public UserPostProfile(Post post) : base(post)
        {
            this.post = post;
            InitializeComponent();
            repostButton.Click += RepostButtonClicked;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            int reporterUserId = UserOverviewSystem.Instance.CurrentUserId;
            int reportedPostId = post.Id; 
            
            NewPostReport reportForm = new NewPostReport(reporterUserId, reportedPostId);
            reportForm.Show();
        }

        private void repostButton_Click(object sender, EventArgs e)
        {
            var rePost = post;
            rePost.Text = "REPOST: " + post.Text;
            rePost.DatePosted = DateTime.Now;
            rePost.accountId = UserOverviewSystem.Instance.CurrentUserId;
            UserOverviewSystem.Instance.AddPost(rePost);
            //UserOverviewSystem.Instance.SavePosts();
            RepostButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            post.Like(UserOverviewSystem.Instance.CurrentUserId);
            likeCounterLabel.Text = "" + post.Likes;
        }

        private void UserPostProfile_Load(object sender, EventArgs e)
        {
            likeCounterLabel.Text = "" + post.Likes;
        }
    }
}
