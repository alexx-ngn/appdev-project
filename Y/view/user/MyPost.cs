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
        // Event handlers for repost and delete button clicks
        public event EventHandler RepostButtonClicked;
        public event EventHandler DeleteButtonClicked;

        // Private field to hold the post object
        private Post post;

        // Constructor accepting a Post object and initializing the base class with it
        public MyPost(Post post) : base(post)
        {
            this.post = post;
            InitializeComponent();
            repostButton.Click += RepostButtonClicked;
        }

        // Default constructor
        public MyPost()
        {
            InitializeComponent();
        }

        // Event handler for repost button click
        private void repostButton_Click(object sender, EventArgs e)
        {
            // Creating a repost by copying the original post and modifying its properties
            var rePost = post;
            rePost.Text = "REPOST: " + post.Text;
            rePost.DatePosted = DateTime.Now;
            rePost.accountId = UserOverviewSystem.Instance.CurrentUserId;
            UserOverviewSystem.Instance.AddPost(rePost);

            // Invoking the RepostButtonClicked event
            RepostButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        // Event handler for delete button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Removing the post from the system
            UserOverviewSystem.Instance.removePost(post);

            // Invoking the DeleteButtonClicked event
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MyPost_Load(object sender, EventArgs e)
        {
            likeCounterLabel.Text = "" + post.Likes;
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            post.Like(UserOverviewSystem.Instance.CurrentUserId);
            likeCounterLabel.Text = "" + post.Likes;
        }
    }
}
