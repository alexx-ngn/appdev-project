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
        private int userId;
        private int reportedPostId;

        public NewPostReport(int userId, int reportedPostId)
        {
            InitializeComponent();
            this.userId = userId;
            this.reportedPostId = reportedPostId;
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
                        MessageBox.Show("La postulation a été signalée.");
                        break;
                    default:
                        MessageBox.Show("Post has been reported.");
                        break;
                }
                SendReport();
                this.Close();
            }
        }
        private void SendReport()
        {
            Report report = new PostReport(userId, reportTextBox.Text, reportedPostId);
            ReportSystem.Instance.FileReport(report);
        }
    }
}
