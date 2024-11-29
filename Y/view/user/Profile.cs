using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void followButton_Click(object sender, EventArgs e)
        {
            if (followButton.Text == "Follow")
            {
                followButton.Text = "Unfollow";
            }
            else
            {
                followButton.Text = "Follow";
            }
        }

        private void usernameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailedProfile detailedProfile = new DetailedProfile();
            detailedProfile.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            NewUserReport report = new NewUserReport();
            report.ShowDialog();
        }
    }
}
