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

namespace Y.view.user
{
    public partial class NewPostReport : Form
    {
        // Private fields to store user ID and reported post ID
        private int userId;
        private int reportedPostId;

        // Constructor to initialize the form with user ID and reported post ID
        public NewPostReport(int userId, int reportedPostId)
        {
            InitializeComponent();
            this.userId = userId;
            this.reportedPostId = reportedPostId;
        }

        // Event handler for the report button click event
        private void reportButton_Click(object sender, EventArgs e)
        {
            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();

            // Check if the report text box is empty
            if (reportTextBox.Text == "")
            {
                // Show message based on the current culture
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("Veuillez entrez votre raison.");
                        break;
                    default:
                        MessageBox.Show("Please enter your statement.");
                        break;
                }
            }
            else
            {
                // Show message based on the current culture
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("La postulation a été signalée.");
                        break;
                    default:
                        MessageBox.Show("Post has been reported.");
                        break;
                }
                // Send the report and close the form
                SendReport();
                this.Close();
            }
        }

        // Method to send the report
        private void SendReport()
        {
            // Create a new report object
            Report report = new PostReport(userId, reportTextBox.Text, reportedPostId);
            // File the report using the report system
            ReportSystem.Instance.FileReport(report);
        }
    }
}
