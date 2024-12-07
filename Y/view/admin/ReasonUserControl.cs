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

namespace Y.view
{
    public partial class ReasonUserControl : UserControl
    {
        // Property to hold PostReport object
        private PostReport PostReport { get; set; }

        // Property to hold UserReport object
        private UserReport UserReport { get; set; }

        // Default constructor
        public ReasonUserControl()
        {
            InitializeComponent();
        }

        // Constructor that initializes with a PostReport object
        public ReasonUserControl(PostReport postReport)
        {
            InitializeComponent();
            PostReport = postReport;
            reasonLabel.Text = postReport.Reason;
            dateLabel.Text = postReport.DateReported.ToString();
            var reporter = getReporter(postReport.ReportingUserId);
            switch (CultureInfo.CurrentUICulture.ToString())
            {
                case "fr-CA":
                    reporterLabel.Text = "Signalé par: " + reporter.Name;
                    break;
                default:
                    reporterLabel.Text = "Reported by: " + reporter.Name;
                    break;
            }
        }

        // Constructor that initializes with a UserReport object
        public ReasonUserControl(UserReport userReport)
        {
            InitializeComponent();
            UserReport = userReport;
            reasonLabel.Text = userReport.Reason;
            dateLabel.Text = userReport.DateReported.ToString();
            var reporter = getReporter(userReport.ReportingUserId);
            switch (CultureInfo.CurrentUICulture.ToString())
            {
                case "fr-CA":
                    reporterLabel.Text = "Signalé par: " + reporter.Name;
                    break;
                default:
                    reporterLabel.Text = "Reported by: " + reporter.Name;
                    break;
            }
        }

        // Method to get the reporter's UserAccount object by ID
        private UserAccount getReporter(int id)
        {
            for (int i = 0; i < ReportSystem.Instance.GetUserAccounts().Count; i++)
            {
                if (ReportSystem.Instance.GetUserAccounts()[i].Id == id)
                {
                    return ReportSystem.Instance.GetUserAccounts()[i];
                }
            }
            return null;
        }
    }
}
