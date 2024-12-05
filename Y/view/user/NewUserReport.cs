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
        private int userId { get; set; }
        private int reportedUserId { get; set; }
        private bool userReport { get; set; }
        public NewUserReport()
        {
            InitializeComponent();
        }
        public NewUserReport(int userId, int reportedUserId, bool userReport)
        {
            InitializeComponent();
            this.userId = userId;
            this.reportedUserId = reportedUserId;
            this.userReport = userReport;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentUICulture.ToString();
            if (reportTextBox.Text == "")
            {
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
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("L'utilisateur a été signalé.");
                        break;
                    default:
                        MessageBox.Show("User has been reported.");
                        break;
                }
                SendReport();
                this.Close();
            }
        }
        private void SendReport()
        {
            Report report;
            if (userReport)
            {
                report = new UserReport(userId, reportTextBox.Text, reportedUserId);
            }
            else
            {
                report = new PostReport(userId, reportTextBox.Text, reportedUserId);
            }
            ReportSystem.Instance.FileReport(report);
        }
    }
}
