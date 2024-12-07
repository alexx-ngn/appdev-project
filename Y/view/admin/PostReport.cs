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

namespace Y.view.admin
{
    public partial class PostReport : Form
    {
        // Private field to hold the post report
        private Y.PostReport postReport;

        // Events for dismiss and ban actions
        public event EventHandler dismissClicked;
        public event EventHandler banClicked;

        // Default constructor
        public PostReport()
        {
            InitializeComponent();
        }

        // Constructor with a post report parameter
        public PostReport(Y.PostReport postReport)
        {
            InitializeComponent();
            this.postReport = postReport;
        }

        // Event handler for the allow button click
        private void allowButton_Click(object sender, EventArgs e)
        {
            // Invoke the dismissClicked event
            dismissClicked?.Invoke(this, EventArgs.Empty);

            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();

            // Show a message box based on the culture
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
            ReportSystem.Instance.removeReport(postReport);

            // Close the form
            this.Close();
        }

        // Event handler for the ban button click
        private void banButton_Click(object sender, EventArgs e)
        {
            // Invoke the banClicked event
            banClicked?.Invoke(this, EventArgs.Empty);

            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();

            // Show a message box based on the culture
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("La publication est supprimée.");
                    break;
                default:
                    MessageBox.Show("The post is removed.");
                    break;
            }

            // Remove the report and the post from the system
            ReportSystem.Instance.removeReport(postReport);
            ReportSystem.Instance.removePost(postReport.ReportedPostId);
            UserOverviewSystem.Instance.removePosts(postReport.ReportedPostId);

            // Close the form
            this.Close();
        }

        // Event handler for the form load event
        private void PostReport_Load(object sender, EventArgs e)
        {
            // Hide the reason user control and user post
            reasonUserControl.Hide();
            userPost.Hide();

            // Initialize the reason user control and user post with the post report data
            reasonUserControl = new ReasonUserControl(postReport);
            userPost = new UserPost(ReportSystem.Instance.getPostFromId(postReport.ReportedPostId));

            // Adjust the location of the user post
            userPost.Location = new Point(userPost.Location.X, userPost.Location.Y + 240);

            // Add the controls to the form
            this.Controls.Add(reasonUserControl);
            this.Controls.Add(userPost);
        }
    }
}