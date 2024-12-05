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
    public partial class Profile : UserControl
    {
        private UserAccount userAccount;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(UserAccount userAccount)
        {
            this.userAccount = userAccount;
            InitializeComponent();
            usernameLinkLabel.Text = userAccount.Name;
        }

        private void followButton_Click(object sender, EventArgs e)
        {
            switch (followButton.Text)
            {
                case "Follow":
                    followButton.Text = "Unfollow";
                    break;
                case "Unfollow":
                    followButton.Text = "Follow";
                    break;
                case "Suivre":
                    followButton.Text = "Ne plus suivre";
                    break;
                case "Ne plus suivre":
                    followButton.Text = "Suivre";
                    break;
            }
        }

        private void usernameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailedProfile detailedProfile = new DetailedProfile(userAccount);
            detailedProfile.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            int reporterUserId = UserOverviewSystem.Instance.CurrentUserId;
            int reportedUserId = userAccount.Id;

            NewUserReport reportForm = new NewUserReport(reporterUserId, reportedUserId, true);
            reportForm.ShowDialog();
        }
    }
}
