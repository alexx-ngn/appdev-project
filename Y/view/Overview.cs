using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y;

namespace Overview
{
    public partial class Overview : Form
    {
        public Overview()
        {
            try
            {
                InitializeComponent(); // Add try-catch to identify specific initialization errors
            }
            catch (Exception ex)
            {
                // Log or display the specific initialization error
                MessageBox.Show($"Initialization Error: {ex.Message}");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
