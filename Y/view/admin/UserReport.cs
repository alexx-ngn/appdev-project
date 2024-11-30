using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.view.admin;

namespace Y.view.admin
{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        public event EventHandler dismissClicked;
        public event EventHandler banClicked;

        private void allowButton_Click(object sender, EventArgs e)
        {
            dismissClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Report has been dismissed.");
            this.Close();
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("User has been banned.");
            this.Close();
        }
    }
}
