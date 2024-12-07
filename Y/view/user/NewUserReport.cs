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

namespace Y
{
    public partial class NewUserReport : Form
    {
        // Private properties for user and report details
        private int userId { get; set; }
        private int reportedUserId { get; set; }
        private bool userReport { get; set; }

        // Default constructor
        public NewUserReport()
        {
            InitializeComponent();
        }

        // Parameterized constructor
        public NewUserReport(int userId, int reportedUserId, bool userReport)
        {
            InitializeComponent();
            this.userId = userId;
            this.reportedUserId = reportedUserId;
            this.userReport = userReport;
        }

        // Event handler for report button click
        private void reportButton_Click(object sender, EventArgs e)
        {
            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();

            // Check if the report text box is empty
            if (reportTextBox.Text == "")
            {
                // Show message based on culture
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
                // Show message based on culture
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("L'utilisateur a été signalé.");
                        break;
                    default:
                        MessageBox.Show("User has been reported.");
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
            Report report;
            // Create a report based on the type of report
            if (userReport)
            {
                report = new UserReport(userId, reportTextBox.Text, reportedUserId);
            }
            else
            {
                report = new PostReport(userId, reportTextBox.Text, reportedUserId);
            }
            // File the report using the report system
            ReportSystem.Instance.FileReport(report);
        }
    }
}
