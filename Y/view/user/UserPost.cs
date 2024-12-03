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
        private int userId { get; set; }

        public UserPost()
        {
            InitializeComponent();
        }
        public UserPost(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            setUsernameLabel();
            setPostText();
            setDateLabel();
        }
        
        private void setUsernameLabel()
        {
            String username = UserOverviewSystem.UserAccounts.Find(x => x.Id == userId).Name;
            usernameLabel.Text = username;
        }

        private void setPostText()
        {
            String postText = UserOverviewSystem.UserAccounts.Find(x => x.Id == userId).GetPosts()[0].Text;
            postTextLabel.Text = postText;
        }

        private void setDateLabel()
        {
            String date = UserOverviewSystem.UserAccounts.Find(x => x.Id == userId).GetPosts()[0].DatePosted.ToShortDateString();
            dateLabel.Text = date;
        }

        private void likeButton_Click(object sender, EventArgs e)
        {

        }

        private void likeCounterLabel_Click(object sender, EventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            NewUserReport report = new NewUserReport();
            report.ShowDialog();
        }
    }
}
