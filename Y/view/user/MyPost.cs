using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Y.controller;

namespace Y
{
    public partial class MyPost : Y.UserPost
    {
        public event EventHandler RepostButtonClicked;
        public event EventHandler DeleteButtonClicked;
        private Post post;
        public MyPost(Post post) : base(post)
        {
            this.post = post;
            InitializeComponent();
            repostButton.Click += RepostButtonClicked;
        }

        public MyPost()
        {
            InitializeComponent();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UserOverviewSystem.Instance.removePost(post);
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
