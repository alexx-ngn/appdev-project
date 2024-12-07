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
    // Profile class inheriting from UserControl
    public partial class Profile : UserControl
    {
        // Private field to store user account information
        private UserAccount userAccount;

        // Default constructor
        public Profile()
        {
            InitializeComponent();
        }

        // Constructor with UserAccount parameter
        public Profile(UserAccount userAccount)
        {
            this.userAccount = userAccount;
            InitializeComponent();
            // Setting the username link label text to the user's name
            usernameLinkLabel.Text = userAccount.Name;
        }

        // Event handler for follow button click
        private void followButton_Click(object sender, EventArgs e)
        {
            // Switch case to toggle follow/unfollow text based on current text
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

        // Event handler for username link label click
        private void usernameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Creating and showing a detailed profile dialog
            DetailedProfile detailedProfile = new DetailedProfile(userAccount);
            detailedProfile.ShowDialog();
        }

        // Event handler for report button click
        private void reportButton_Click(object sender, EventArgs e)
        {
            // Getting the current user ID and the reported user ID
            int reporterUserId = UserOverviewSystem.Instance.CurrentUserId;
            int reportedUserId = userAccount.Id;

            // Creating and showing a new user report form
            NewUserReport reportForm = new NewUserReport(reporterUserId, reportedUserId, true);
            reportForm.ShowDialog();
        }
    }
}
