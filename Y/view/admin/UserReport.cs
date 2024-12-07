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
        // Private field to store the user report
        private Y.UserReport userReport;

        // Default constructor
        public UserReport()
        {
            InitializeComponent();
        }

        // Constructor with user report parameter
        public UserReport(Y.UserReport userReport)
        {
            this.userReport = userReport;
            InitializeComponent();
        }

        // Event triggered when dismiss button is clicked
        public event EventHandler dismissClicked;
        // Event triggered when ban button is clicked
        public event EventHandler banClicked;

        // Method called when allow button is clicked
        private void allowButton_Click(object sender, EventArgs e)
        {
            // Invoke dismissClicked event
            dismissClicked?.Invoke(this, EventArgs.Empty);
            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();
            // Show message based on culture
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("Le signal a été rejeté.");
                    break;
                default:
                    MessageBox.Show("The report has been dismissed.");
                    break;
            }
            // Remove the report from the system
            ReportSystem.Instance.removeReport(userReport);
            // Close the form
            this.Close();
        }

        // Method called when ban button is clicked
        private void banButton_Click(object sender, EventArgs e)
        {
            // Invoke banClicked event
            banClicked?.Invoke(this, EventArgs.Empty);
            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();
            // Show message based on culture
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("L'utilisateur est supprimé.");
                    break;
                default:
                    MessageBox.Show("The user is banned.");
                    break;
            }
            // Remove the report from the system
            ReportSystem.Instance.removeReport(userReport);
            // Remove the user from the system
            ReportSystem.Instance.RemoveUser(userReport.ReportedUserId);
            // Reload the user overview
            UserOverviewSystem.Instance.ReloadUsers();
            // Close the form
            this.Close();
        }

        // Method called when the form is loaded
        private void UserReport_Load(object sender, EventArgs e)
        {
            // Create a new ReasonUserControl with the user report
            var ReasonUserControl = new ReasonUserControl(userReport);
            // Add the ReasonUserControl to the flow layout panel
            PostsFlowLayoutPanel.Controls.Add(ReasonUserControl);
            // Load the profile of the reported user
            loadProfile(userReport.ReportedUserId);
        }

        // Method to load the profile of a user by ID
        private void loadProfile(int id)
        {
            // Add the username profile to the flow layout panel
            PostsFlowLayoutPanel.Controls.Add(usernameProfile);
            // Loop through the user's posts in reverse order and add them to the flow layout panel
            for (int i = ReportSystem.Instance.getUserPosts(id).Count - 1; i >= 0; i--)
            {
                UserPost post = new UserPost(ReportSystem.Instance.getUserPosts(id)[i]);
                PostsFlowLayoutPanel.Controls.Add(post);
            }
        }
    }
}
