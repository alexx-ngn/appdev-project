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
        private PostReport PostReport { get; set; }
        public ReasonUserControl()
        {
            InitializeComponent();
        }

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
