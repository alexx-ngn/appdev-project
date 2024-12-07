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
    public partial class UserPost : UserControl
    {
        private int id { get; set; }
        private String postText { get; set; }
        private DateTime date { get; set; }
        private int likes { get; set; }
        private int userId { get; set; }

        public UserPost()
        {
            InitializeComponent();
        }
        public UserPost(Post post)
        {
            InitializeComponent();
            id = post.Id;
            postText = post.Text;
            date = post.DatePosted;
            likes = post.Likes;
            userId = post.accountId;
            setUsernameLabel();
            setPostText();
            setDateLabel();
        }

        private void setUsernameLabel()
        {
            String username = UserOverviewSystem.Instance.GetPostUsername(id);
            usernameLabel.Text = username;
        }

        private void setPostText()
        {
             postTextLabel.Text = postText;
        }

        private void setDateLabel()
        {
            dateLabel.Text = date.ToString();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            NewUserReport report = new NewUserReport();
            report.ShowDialog();
        }
    }
}
