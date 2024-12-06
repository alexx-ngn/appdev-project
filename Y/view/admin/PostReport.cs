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
        private Y.PostReport postReport;

        public event EventHandler dismissClicked;
        public event EventHandler banClicked;
        public PostReport()
        {
            InitializeComponent();
        }

        public PostReport(Y.PostReport postReport)
        {
            InitializeComponent();
            this.postReport = postReport;
        }

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
            ReportSystem.Instance.removeReport(postReport);
            this.Close();
        }
        private void banButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            var culture = CultureInfo.CurrentUICulture.ToString();
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("La publication est supprimée.");
                    break;
                default:
                    MessageBox.Show("The post is removed.");
                    break;
            }
            ReportSystem.Instance.removeReport(postReport);
            ReportSystem.Instance.removePost(postReport.ReportedPostId);
            UserOverviewSystem.Instance.removePosts(postReport.ReportedPostId);
            this.Close();
        }

        private void PostReport_Load(object sender, EventArgs e)
        {
            reasonUserControl.Hide();
            userPost.Hide();
            reasonUserControl = new ReasonUserControl(postReport);
            userPost = new UserPost(ReportSystem.Instance.getPostFromId(postReport.ReportedPostId));
            userPost.Location = new Point(userPost.Location.X, userPost.Location.Y + 240);
            this.Controls.Add(reasonUserControl);
            this.Controls.Add(userPost);
        }
    }
}