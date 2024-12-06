using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;
using Y.view.admin;

namespace Y.view.admin
{
    public partial class UserReport : Form
    {
        private Y.UserReport userReport;

        public UserReport()
        {
            InitializeComponent();
        }

        public UserReport(Y.UserReport userReport)
        {
            this.userReport = userReport;
            InitializeComponent();

        }

        public event EventHandler dismissClicked;
        public event EventHandler banClicked;

        private void allowButton_Click(object sender, EventArgs e)
        {
            dismissClicked?.Invoke(this, EventArgs.Empty);
            var culture = CultureInfo.CurrentUICulture.ToString();
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("Le signal a été rejeté.");
                    break;
                default:
                    MessageBox.Show("The report has been dismissed.");
                    break;
            }
            ReportSystem.Instance.removeReport(userReport);
            this.Close();
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            var culture = CultureInfo.CurrentUICulture.ToString();
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("L'utilisateur est supprimé.");
                    break;
                default:
                    MessageBox.Show("The user is banned.");
                    break;
            }
            ReportSystem.Instance.removeReport(userReport);
            ReportSystem.Instance.RemoveUser(userReport.ReportedUserId);
            UserOverviewSystem.Instance.ReloadUsers();
            this.Close();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            var ReasonUserControl = new ReasonUserControl(userReport);
            PostsFlowLayoutPanel.Controls.Add(ReasonUserControl);
            loadProfile(userReport.ReportedUserId);
        }

        private void loadProfile(int id)
        {
            //usernameProfile.Hide();
            PostsFlowLayoutPanel.Controls.Add(usernameProfile);
            for (int i = ReportSystem.Instance.getUserPosts(id).Count - 1; i >= 0; i--)
            {
                UserPost post = new UserPost(ReportSystem.Instance.getUserPosts(id)[i]);
                PostsFlowLayoutPanel.Controls.Add(post);
            }
        }
    }
}
