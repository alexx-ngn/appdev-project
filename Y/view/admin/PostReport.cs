using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y.view.admin
{
    public partial class PostReport : Form
    {

        public event EventHandler dismissClicked;
        public event EventHandler banClicked;
        public PostReport()
        {
            InitializeComponent();
        }

        private void allowButton_Click(object sender, EventArgs e)
        {
            dismissClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Report has been dismissed.");
            this.Close();
        }
        private void banButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Post has been removed.");
            this.Close();
        }
    }
}